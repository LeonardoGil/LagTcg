using TcgDomain.Entities.Battles;
using TcgForms.Controls;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Property & Constructor

        public Player Player { get; set; }

        public Player Opponent { get; set; }

        public BattleField BattleField { get; set; }

        public DuelFieldForm(Player user, Player opponent)
        {
            InitializeComponent();

            Player = user;
            Opponent = opponent;
            BattleField = new BattleField();
        }

        #endregion

        #region Public Methods

        public void InvokePlayerMonster(CardControl cardControl)
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

        #endregion

        #region Events

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            var card = Player.Deck.Draw();

            var cardControl = new CardControl(card);

            flowPanelHands.Controls.Add(cardControl);

            flowPanelHands.SuspendLayout();

            cardControl.Name = "Card";

            flowPanelHands.ResumeLayout(false);
        }

        #endregion
    }
}