using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgForms.Controls;
using TcgForms.Services;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services

        private readonly DrawAppServices cardInHandServices;

        #endregion

        protected Player User { get; set; }

        protected Player Opponent { get; set; }

        public DuelFieldForm(Player user, Player opponent)
        {
            InitializeComponent();

            User = user;
            Opponent = opponent;

            cardInHandServices = new DrawAppServices();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            var card = User.Deck.Draw() as Card;

            var cardInHand = new CardControl();

            //FieldPlayerPanel.SuspendLayout();
            //MyHandsFlowPanel.SuspendLayout();
            //SuspendLayout();

            cardInHandServices.LoadCardForControl(cardInHand, MyHandsFlowPanel);

            //FieldPlayerPanel.ResumeLayout(false);
            //MyHandsFlowPanel.ResumeLayout(false);
            //ResumeLayout(false);
        }
    }
}