using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgForms.AppServices;
using TcgForms.Controls.Fields;
using TcgInfra.CustomEventArgs;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services & Forms

        private readonly PhaseAppServices PhaseAppServices = new PhaseAppServices();

        private readonly CardsHandForm PlayerCardsHandForm = new CardsHandForm();

        #endregion

        #region Property & Constructor

        public int Turn { get; private set; }

        public TypePlayerEnum PhasePlayer { get; private set; }

        public PhaseEnum Phase { get; private set; }

        public Player Player { get; private set; }

        public Bot Opponent { get; private set; }

        public DuelFieldForm(Player user, Bot opponent)
        {
            BackgroundImage = Properties.Resources.BackgroundDigitalDuel;

            Player = user;
            Opponent = opponent;

            InitializeComponent();

            PlayerCardsHandForm.DuelFieldForm = this;
            PlayerCardsHandForm.Show();

            LoadInfo();
            LoadEvents();

            Player.Deck.Shuffle();

            deckControlPlayer.Draw(5);
        }

        #endregion

        #region Public Methods

        public void NextPhase()
        {
            if (Phase == PhaseEnum.EndPhase)
            {
                PhasePlayer = PhaseAppServices.NextPhasePlayer(PhasePlayer);
                
                labelPhasePlayer.Text = PhasePlayer.ToString();

                Turn++;
                labelTurn.Text = string.Concat("Turn: ", Turn);

                Player.ResetAction();
                Opponent.ResetAction();
            }

            Phase = PhaseAppServices.NextPhase(Phase);

            labelPhase.Text = Phase.GetDescription();

            buttonNextPhase.Enabled = Phase != PhaseEnum.DrawPhase || PhasePlayer == TypePlayerEnum.Opponent;
        }

        #endregion

        #region Private Methods

        private void LoadEvents()
        {
            Player.Deck.DrawCard += new EventHandler(PlayerCardsHandForm.CardsHand_Add);
            Player.DuelField.MonstersField.Put += new EventHandler<InvokeEventArgs>(Player_InvokeMonster);
            Player.DuelField.MonstersField.Remove += new EventHandler<InvokeEventArgs>(Player_RemoveMonster);

            Player.ChangePointLife += new EventHandler(Players_ChangePointLife);
            Opponent.ChangePointLife += new EventHandler(Players_ChangePointLife);
        }

        private void LoadInfo()
        {
            Turn++;

            PhasePlayer = TypePlayerEnum.Player;
            Phase = PhaseEnum.DrawPhase;

            labelPlayerName.Text = Player.Username;
            labelOpponentName.Text = Opponent.Username;

            labelPlayerPointLife.Text = Player.PointLife.ToString();
            labelOpponentPointLife.Text = Opponent.PointLife.ToString();

            labelPhase.Text = Phase.GetDescription();
            labelPhasePlayer.Text = PhasePlayer.ToString();
        }

        #endregion

        #region Events

        public void Player_InvokeMonster(object sender, InvokeEventArgs e)
        {
            var control = new MonsterCardFieldControl(sender as NormalCard, e.Position, e.Set);

            tableLayoutPlayerMain.Controls.Add(control, control.Position, 0);
        }
        
        public void Player_RemoveMonster(object sender, InvokeEventArgs e)
        {
            var control = tableLayoutPlayerMain.Controls.OfType<MonsterCardFieldControl>().ToList().FirstOrDefault(x => x.Position == e.Position);

            tableLayoutPlayerMain.Controls.Remove(control);
        }

        public void Players_ChangePointLife(object sender, EventArgs e)
        {
            var player = sender as Player;

            switch (player.Type)
            {
                case TypePlayerEnum.Player:
                    labelPlayerPointLife.Text = player.PointLife.ToString();
                    break;

                case TypePlayerEnum.Opponent:
                    labelOpponentPointLife.Text = player.PointLife.ToString();
                    break;
            }
        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            NextPhase();
        }

        private void buttonMyCards_Click(object sender, EventArgs e)
        {
            PlayerCardsHandForm.DuelFieldForm = this;
            PlayerCardsHandForm.Show();
            PlayerCardsHandForm.Activate();
        }

        #endregion
    }
}