using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Extensions;
using TcgForms.Controls;

namespace TcgForms.Forms
{
    public partial class InfoCardForm : Form
    {
        public InfoCardForm(Card card)
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(card.Image.GetStream());
        }

        private void InfoCardForm_Close(object sender, EventArgs e) => Close();
    }
}
