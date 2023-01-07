using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Entities.Cards;
using TcgForms.Controls.Hands;
using TcgForms.Controls;
using System.Windows.Forms;

namespace TcgForms.Forms
{
    public partial class CardsHandForm : Form
    {
        public DuelFieldForm DuelFieldForm { get; set; }

        private Point Point;

        public CardsHandForm()
        {
            InitializeComponent();
        }

        public void AddCard(object sender, EventArgs e)
        {
            var card = sender as Card;

            if (card.IsMonsterCard())
            {
                var cardControl = new MonsterCardHandControl(sender as NormalCard);
                AddCardFromHand(cardControl);
            }

            if (card.IsSpecialCard())
            {
                throw new NotImplementedException();
            }
        }

        public void AddCardFromHand(MonsterCardHandControl cardControl)
        {
            flowLayoutPanelHands.Controls.Add(cardControl);
        }
        
        public void RemoveCardFromHand(MonsterCardHandControl cardControl)
        {
            flowLayoutPanelHands.Controls.Remove(cardControl);
        }

        #region Events 

        private void CardsHandForm_MouseDown(object sender, MouseEventArgs e)
        {
            Point = e.Location;
        }

        private void CardsHandForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Point.X;
                Top += e.Y - Point.Y;
            }
        }

        private void CardsHandForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Space)
            {
                Close();
            }
        }

        private void CardsHandForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        #endregion
    }
}
