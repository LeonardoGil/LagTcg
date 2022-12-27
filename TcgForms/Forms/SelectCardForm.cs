using TcgDomain.Entities.Cards.Abstract;
using TcgForms.Controls;

namespace TcgForms.Forms
{
    public partial class SelectCardForm : Form
    {
        public List<Card> CardsSelected { get; set; }

        public int Quantity { get; set; }

        public bool Exceed { get; set; }
        
        private Point Point;

        public SelectCardForm(List<Card> cards, string text, int quantity = 1, bool exceed = false)
        {
            InitializeComponent();

            cards.ForEach(LoadCard);

            labelText.Text = text;

            Quantity = quantity;
            Exceed = exceed;
         }

        public void LoadCard(Card card)
        {
            var control = new SelectTheCardsControl(card);

            flowLayoutPanelCards.Controls.Add(control);

            flowLayoutPanelCards.SuspendLayout();

            flowLayoutPanelCards.ResumeLayout(false);
        }

        #region Events
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            var cardsControl = flowLayoutPanelCards.Controls.OfType<dynamic>()
                                                            .Where(x => x is SelectTheCardsControl)
                                                            .Select(x => x as SelectTheCardsControl)
                                                            .Where(x => x.Selected)
                                                            .Select(x => x.Card)
                                                            .ToList();
            
            if (cardsControl.Count < Quantity)
            {
                MessageBox.Show("Selecione todas as cartas necessarias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cardsControl.Count > Quantity && !Exceed)
            {
                MessageBox.Show("Selecione somente a quantidade de cartas necessarias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CardsSelected = cardsControl;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void SelectCardForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Point.X;
                Top += e.Y - Point.Y;
            }
        }

        private void SelectCardForm_MouseDown(object sender, MouseEventArgs e)
        {
            Point = e.Location;
        }

        #endregion
    }
}
