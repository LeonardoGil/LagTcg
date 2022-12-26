using System.ComponentModel;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Extensions;
using TcgForms.Forms;

namespace TcgForms.Controls
{
    public partial class CardControl : UserControl
    {
        public readonly dynamic OriginalCard; 

        public readonly Card Card; 
        
        public CardControl(dynamic originalCard)
        {
            InitializeComponent();

            OriginalCard = originalCard;
            Card = originalCard as Card;

            if (Card.Image is not null)
                BackgroundImage = new Bitmap(Card.Image.GetStream());
        }

        public CardControl()
        {
            InitializeComponent();
        }

        public void Zoom()
        {
            using var form = new InfoCardForm(Card);
            
            form.ShowDialog();
        }

        public void Verse()
        {
            var resource = new ComponentResourceManager(typeof(CardControl));

            BackgroundImage = resource.GetObject("$this.VerseCard") as Image;

            SuspendLayout();

            ResumeLayout(false);
        }

        protected ToolStripMenuItem GetMenuItemZoom() => menuItemZoom;

        private void CardControl_DoubleClick(object sender, EventArgs e)
        {
            Zoom();
        }

        private void menuItemZoom_Click(object sender, EventArgs e)
        {
            Zoom();
        }
    }
}
