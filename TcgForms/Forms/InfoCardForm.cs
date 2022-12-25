using TcgDomain.Entities.Cards.Abstract;
using TcgForms.Controls;

namespace TcgForms.Forms
{
    public partial class InfoCardForm : Form
    {
        public InfoCardForm(Card card)
        {
            InitializeComponent();

            LoadCardControl(card);
        }

        private void LoadCardControl(Card card)
        {
            var control = new CardControl(card);

            Controls.Add(control);

            SuspendLayout();

            control.Dock = DockStyle.Fill;

            control.Click += new EventHandler(InfoCardForm_Close);
            
            control.DoubleClick += new EventHandler(InfoCardForm_Close);

            ResumeLayout(false);
        }

        private void InfoCardForm_Close(object sender, EventArgs e) => Close();
    }
}
