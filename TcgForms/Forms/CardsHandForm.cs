using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Entities.Cards;
using TcgForms.Controls.Hands;
using TcgForms.Controls;

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

        public void CardsHand_Add(object sender, EventArgs e)
        {
            var card = sender as Card;

            if (card.IsMonsterCard())
            {
                var cardControl = new MonsterCardHandControl(sender as NormalCard);
                cardControl.Remove += new EventHandler(CardsHand_Remove);

                flowLayoutPanelHands.Controls.Add(cardControl);
            }

            if (card.IsSpecialCard())
            {
                throw new NotImplementedException();
            }
        }

        public void CardsHand_Remove(object sender, EventArgs e)
        {
            flowLayoutPanelHands.Controls.Remove(sender as MonsterCardHandControl);
        }

        #endregion
    }
}
