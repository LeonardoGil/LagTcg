using TcgDomain.Entities.Battles;
using TcgForms.Controls;
using TcgForms.AppServices;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services

        private readonly DrawAppServices DrawAppServices;

        private readonly InvokeAppServices InvokeAppServices;

        #endregion

        protected Player User { get; set; }

        protected Player Opponent { get; set; }

        public DuelFieldForm(Player user, Player opponent)
        {
            InitializeComponent();

            User = user;
            Opponent = opponent;

            DrawAppServices = new DrawAppServices();
            InvokeAppServices = new InvokeAppServices();
        }

        public void InvokeCard(CardControl cardControl) => InvokeAppServices.Invoke(MyHandsFlowPanel, tableLayoutPlayerMain, cardControl);

        private void DrawButton_Click(object sender, EventArgs e)
        {
            var card = User.Deck.Draw();

            var cardControl = new CardControl(card);

            DrawAppServices.LoadCardForControl(cardControl, MyHandsFlowPanel);
        }
    }
}