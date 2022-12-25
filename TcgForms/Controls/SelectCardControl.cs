using TcgDomain.Entities.Cards.Abstract;

namespace TcgForms.Controls
{
    public partial class SelectCardControl : CardControl
    {
        public bool Selected { get; set; }

        public SelectCardControl()
        {
            InitializeComponent();
        }

        public SelectCardControl(Card card) : base(card)
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Selected = checkBox.Checked;
        }
    }
}
