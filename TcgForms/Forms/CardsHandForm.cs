using TcgForms.Controls.Hands;

namespace TcgForms.Forms
{
    public partial class CardsHandForm : Form
    {
        public List<dynamic> CardControls { get; set; }

        public List<CardMonsterHandControl> CardMonsterControls { get => CardControls.Where(x => x is CardMonsterHandControl).OfType<CardMonsterHandControl>().ToList(); }

        public DuelFieldForm DuelFieldForm { get; set; }

        private Point Point;

        public CardsHandForm()
        {
            InitializeComponent();

            CardControls = new List<dynamic>();
        }

        public void AddCard(dynamic cardControl)
        {
            CardControls.Add(cardControl);
        }

        public void RemoveCard(dynamic cardControl)
        {
            CardControls.Remove(cardControl);
        }

        public void AddCardFromHand(CardMonsterHandControl cardControl)
        {
            flowLayoutPanelHands.Controls.Add(cardControl);
        }
        
        public void RemoveCardFromHand(CardMonsterHandControl cardControl)
        {
            flowLayoutPanelHands.Controls.Remove(cardControl);
        }

        private void MyCardsForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanelHands.Controls.Clear();

            foreach (var control in CardControls)
            {
                AddCardFromHand(control);
            }
        }

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
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }
    }
}
