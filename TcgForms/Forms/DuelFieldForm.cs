using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgForms.AppServices;
using TcgForms.Controls.Fields;
using TcgForms.Controls.Hands;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services

        private readonly DrawAppServices DrawAppServices = new DrawAppServices();

        private readonly InvokeAppServices InvokeAppServices = new InvokeAppServices();

        #endregion

        #region Property & Constructor

        public PhasePlayerEnum PhasePlayer { get; set; }

        public PhaseEnum Phase { get; set; }

        public Player Player { get; set; }

        public Player Opponent { get; set; }

        public BattleField BattleField { get; set; }

        public DuelFieldForm(Player user, Player opponent)
        {
            InitializeComponent();

            Player = user;
            Opponent = opponent;
            BattleField = new BattleField();

            PhasePlayer = PhasePlayerEnum.Player;
            Phase = PhaseEnum.DrawPhase;
            
            LoadInfo();

            Player.Deck.Shuffle();
            DrawCard(5);
        }

        #endregion

        #region Public Methods

        public void InvokePlayerMonster(CardMonsterHandControl cardHandControl)
        {
            flowPanelHands.Controls.Remove(cardHandControl);
            
            flowPanelHands.SuspendLayout();

            flowPanelHands.ResumeLayout(false);

            var position = InvokeAppServices.Invoke(Player, cardHandControl.OriginalCard);

            var cardFieldControl = new CardMonsterFieldControl(cardHandControl.OriginalCard);

            tableLayoutPlayerMain.Controls.Add(cardFieldControl, position, 0);

            tableLayoutPlayerMain.SuspendLayout();

            tableLayoutPlayerMain.ResumeLayout(false);
        }

        public void DrawCard(int quantity = 1)
        {
            var cards = DrawAppServices.DrawCards(Player, quantity);

            foreach (var card in cards)
            {
                var basicCard = (card as Card);

                var control = default(Control);

                if (basicCard.IsMonsterCard())
                {
                    var cardControl = new CardMonsterHandControl(card);

                    flowPanelHands.Controls.Add(cardControl);

                    control = cardControl;
                }

                if (basicCard.IsSpecialCard())
                {
                    throw new NotImplementedException();
                }

                flowPanelHands.SuspendLayout();

                control.Name = $"Card-{basicCard.Id}-{Guid.NewGuid()}";
                
                flowPanelHands.ResumeLayout(false);
            }
        }

        public void NextPhase()
        {
            if (Phase == PhaseEnum.EndPhase)
                Phase = PhaseEnum.DrawPhase;
            else
                Phase = Phase + 1;

            LoadInfo();
        }

        #endregion

        #region Private Methods

        private void LoadInfo()
        {
            labelPlayerName.Text = Player.Username;
            labelPlayerPointLife.Text = Player.PointLife.ToString();

            labelPhase.Text = Phase.GetDescription();
            labelPhasePlayer.Text = PhasePlayer.ToString();
        }

        #endregion

        #region Events

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            DrawCard();
            NextPhase();
        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            NextPhase();
        }
        
        #endregion
    }
}