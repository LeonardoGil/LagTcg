using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgForms.AppServices;
using TcgForms.Controls;
using TcgForms.Controls.Hands;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services

        private readonly DrawAppServices DrawAppServices = new DrawAppServices();

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
        }

        #endregion

        #region Public Methods

        public void InvokePlayerMonster(CardMonsterHandControl cardControl)
        {
            flowPanelHands.SuspendLayout();
            tableLayoutPlayerMain.SuspendLayout();

            flowPanelHands.Controls.Remove(cardControl);

            foreach (var monster in Player.MonstersField.Select((card, index) => new { Card = card, Index = index}))
            {
                if (monster.Card is not null)
                    continue;

                Player.MonstersField[monster.Index] = cardControl.OriginalCard;
                tableLayoutPlayerMain.Controls.Add(cardControl, monster.Index, 0);
                break;
            }

            flowPanelHands.ResumeLayout(false);
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
                    control = cardControl;
                    
                    flowPanelHands.Controls.Add(cardControl);
                }

                if (basicCard.IsSpecialCard())
                {
                    throw new NotImplementedException();
                }

                flowPanelHands.SuspendLayout();

                control.Name = $"Card-{basicCard.Description}-{Guid.NewGuid()}";

                flowPanelHands.ResumeLayout(false);
            }
        }

        #endregion

        #region Events

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            DrawCard();

            Phase = PhaseEnum.MainPhaseOne;
        }

        #endregion
    }
}