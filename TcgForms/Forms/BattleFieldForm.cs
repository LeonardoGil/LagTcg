using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgForms.Controls;
using TcgForms.Properties;

namespace TcgForms.Forms
{
    public partial class BattleFieldForm : Form
    {
        protected Player User { get; set; }

        protected Player Opponent { get; set; }

        public BattleFieldForm(Player user, Player opponent)
        {
            InitializeComponent();

            User = user;
            Opponent = opponent;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            var card = User.Deck.Draw() as Card;

            CardsInHands = new CardInHandControl();

            FieldPlayerPanel.SuspendLayout();
            MyHandsFlowPanel.SuspendLayout();
            SuspendLayout();

            MyHandsFlowPanel.Controls.Add(CardsInHands);
            SetCardInHand(CardsInHands);

            FieldPlayerPanel.ResumeLayout(false);
            MyHandsFlowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private CardInHandControl SetCardInHand(CardInHandControl cardInHand)
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CardInHandControl));

            cardInHand.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            cardInHand.BackgroundImageLayout = ImageLayout.Stretch;
            cardInHand.Name = "CardsInHands";
            cardInHand.Size = new Size(80, 120);
            cardInHand.Location = new Point(3, 3);

            return cardInHand;
        }
    }
}