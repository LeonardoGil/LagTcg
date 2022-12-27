using TcgDomain.Entities.Cards.Abstract;

namespace TcgForms.Controls
{
    public partial class SelectTheCardsControl : CardControl
    {
        public bool Selected { get; set; }

        public SelectTheCardsControl()
        {
            InitializeComponent();
        }

        public SelectTheCardsControl(Card card) : base(card)
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Selected = checkBox.Checked;
        }

        private void SelectTheCardsControl_DoubleClick(object sender, EventArgs e)
        {
            Selected = checkBox.Checked = !checkBox.Checked; 
        }
    }
}
