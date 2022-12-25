using TcgDomain.Entities.Cards.Abstract;
using TcgForms.Controls;

namespace TcgForms.Forms
{
    public partial class SelectCardForm : Form
    {
        public List<Card> CardsSelected { get; set; }

        public int Quantity { get; set; }

        public bool Exceed { get; set; }

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
            var control = new SelectCardControl(card);

            flowLayoutPanelCards.Controls.Add(control);

            flowLayoutPanelCards.SuspendLayout();

            flowLayoutPanelCards.ResumeLayout(false);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var cardsControl = flowLayoutPanelCards.Controls.OfType<dynamic>()
                                                            .Where(x => x is SelectCardControl)
                                                            .Select(x => x as SelectCardControl)
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
    }
}
