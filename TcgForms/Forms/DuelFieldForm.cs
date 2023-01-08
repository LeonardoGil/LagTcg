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

        private readonly DrawAppServices DrawAppServices = new DrawAppServices();

        private readonly PhaseAppServices PhaseAppServices = new PhaseAppServices();

        private readonly BattleAppService BattleAppService = new BattleAppService();

        private readonly CardsHandForm PlayerCardsHandForm = new CardsHandForm();

        #endregion

        #region Property & Constructor

        public int Turn { get; private set; }

        public TypePlayerEnum PhasePlayer { get; private set; }

        public PhaseEnum Phase { get; private set; }

        public Player Player { get; private set; }

        public Player Opponent { get; private set; }

        public DuelFieldForm(Player user, Player opponent)
        {
            BackgroundImage = Properties.Resources.BackgroundDigitalDuel;

            InitializeComponent();

            Player = user;
            Opponent = opponent;

            Player.Deck.DrawCard += new EventHandler(PlayerCardsHandForm.CardsHand_Add);
            Player.DuelField.MonstersField.Put += new EventHandler<InvokeEventArgs>(Player_InvokeMonster);
            Player.DuelField.MonstersField.Remove += new EventHandler<InvokeEventArgs>(Player_RemoveMonster);

            PhasePlayer = TypePlayerEnum.Player;
            Phase = PhaseEnum.DrawPhase;

            PlayerCardsHandForm.DuelFieldForm = this;

            PlayerCardsHandForm.Show();

            Player.Deck.Shuffle();
            DrawCardPlayer(5);

            Turn++;

            LoadInfo();
        }

        #endregion

        #region Public Methods

        public void Battle(MonsterCard playerMonster, MonsterCard opponentMonster)
        {
            BattleAppService.Battle(Player, Opponent, playerMonster, opponentMonster);
        }

        public void DrawCardPlayer(int quantity = 1)
        {
            DrawAppServices.DrawCards(Player, quantity);
        }

        public void NextPhase()
        {
            if (Phase == PhaseEnum.EndPhase)
            {
                PhasePlayer = PhaseAppServices.NextPhasePlayer(PhasePlayer);

                Player.ResetAction();
                Opponent.ResetAction();
            }

            Phase = PhaseAppServices.NextPhase(Phase);

            LoadInfo();

            buttonNextPhase.Enabled = Phase != PhaseEnum.DrawPhase || PhasePlayer == TypePlayerEnum.Opponent;
        }

        #endregion

        #region Private Methods

        private void LoadInfo()
        {
            labelPlayerName.Text = Player.Username;
            labelOpponentName.Text = Opponent.Username;
            labelPlayerPointLife.Text = Player.PointLife.ToString();
            labelOpponentPointLife.Text = Opponent.PointLife.ToString();

            labelPhase.Text = Phase.GetDescription();
            labelPhasePlayer.Text = PhasePlayer.ToString();
            labelTurn.Text = string.Concat("Turn: ", Turn);
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