using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgApplication.AppServices;
using TcgForms.Controls.Fields;
using TcgInfra.CustomEventArgs;
using TcgApplication.BotScripts;
using TcgDomain.Entities.Scripts;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services & Forms

        private readonly MainScript BotScript = new MainScript();

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
            PrepareDuel();
        }

        #endregion

        #region Public Methods

        public void NextPhase()
        {
            if (Phase == PhaseEnum.EndPhase)
            {
                PhasePlayer = PhaseAppServices.NextPhasePlayer(PhasePlayer);

                labelPhasePlayer.Invoke(() => { labelPhasePlayer.Text = PhasePlayer.ToString(); });

                Turn++;
                labelTurn.Invoke(() => { labelTurn.Text = string.Concat("Turn: ", Turn); });

                Player.ResetAction();
                Opponent.ResetAction();
            }

            Phase = PhaseAppServices.NextPhase(Phase);

            labelPhase.Invoke(() => { labelPhase.Text = Phase.GetDescription(); });

            buttonNextPhase.Enabled = Phase != PhaseEnum.DrawPhase && PhasePlayer == TypePlayerEnum.Player;

            if (Phase == PhaseEnum.DrawPhase && PhasePlayer == TypePlayerEnum.Opponent)
                backgroundWorkerBot.RunWorkerAsync();
        }

        #endregion

        #region Private Methods

        private void PrepareDuel()
        {
            Player.Deck.Shuffle();
            Opponent.Deck.Shuffle();

            for (int i = 0; i < 5; i++)
            {
                Player.Deck.Draw();
                Opponent.Deck.Draw();
            }
        }

        private void LoadEvents()
        {
            Player.Deck.DrawCard += new EventHandler(PlayerCardsHandForm.CardsHand_Add);

            Player.DuelField.MonstersField.Remove += new EventHandler<InvokeEventArgs>(Player_RemoveMonster);
            Opponent.DuelField.MonstersField.Remove += new EventHandler<InvokeEventArgs>(Opponent_RemoveMonster);

            Player.DuelField.MonstersField.Put += new EventHandler<InvokeEventArgs>(Player_InvokeMonster);
            Opponent.DuelField.MonstersField.Put += new EventHandler<InvokeEventArgs>(Opponent_InvokeMonster);

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

            tableLayoutPlayerMain.Invoke(() => { tableLayoutPlayerMain.Controls.Add(control, control.Position, 0); });
        }

        public void Opponent_InvokeMonster(object sender, InvokeEventArgs e)
        {
            var control = new MonsterCardFieldControl(sender as NormalCard, e.Position, e.Set);

            tableLayoutOpponentMain.Invoke(() => { tableLayoutOpponentMain.Controls.Add(control, control.Position, 1); });
        }

        public void Player_RemoveMonster(object sender, InvokeEventArgs e)
        {
            var control = tableLayoutPlayerMain.Controls.OfType<MonsterCardFieldControl>().ToList().FirstOrDefault(x => x.Position == e.Position);

            tableLayoutPlayerMain.Invoke(() => { tableLayoutPlayerMain.Controls.Remove(control); });
        }

        public void Opponent_RemoveMonster(object sender, InvokeEventArgs e)
        {
            var control = tableLayoutOpponentMain.Controls.OfType<MonsterCardFieldControl>().ToList().FirstOrDefault(x => x.Position == e.Position);

            tableLayoutOpponentMain.Invoke(() => { tableLayoutOpponentMain.Controls.Remove(control); });
        }

        public void Players_ChangePointLife(object sender, EventArgs e)
        {
            var player = sender as Player;

            var label = default(Label);

            switch (player.Type)
            {
                case TypePlayerEnum.Player:
                    label = labelPlayerPointLife;
                    break;

                case TypePlayerEnum.Opponent:
                    label = labelOpponentPointLife;
                    break;
            }

            label.Invoke(() => 
            { 
                label.Text = player.PointLife.ToString();

                Task.Run(() =>
                {
                    label.ForeColor = Color.Maroon;

                    Thread.Sleep(TimeSpan.FromSeconds(0.5));

                    label.ForeColor = Color.Red;

                    Thread.Sleep(TimeSpan.FromSeconds(0.5));

                    label.ForeColor = Color.White;
                });
            });
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

        private void backgroundWorkerBot_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            do
            {
                var inputData = new InputData()
                {
                    Bot = Opponent,
                    Opponent = Player,
                    Phase = Phase
                };

                BotScript.On(inputData);

                NextPhase();

                Thread.Sleep(TimeSpan.FromSeconds(1.5));

            } while (PhasePlayer == TypePlayerEnum.Opponent);
        }

        #endregion
    }
}