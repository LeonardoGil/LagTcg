using System.ComponentModel;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Extensions;
using TcgForms.Forms;

namespace TcgForms.Controls
{
    public partial class CardControl : UserControl
    {
        protected const int SizeX = 100;

        protected const int SizeY = 140;

        public readonly dynamic OriginalCard;

        public Card Card { get => OriginalCard as Card; }


        public CardControl(dynamic originalCard, bool set = false)
        {
            InitializeComponent();

            OriginalCard = originalCard;

            if (set)
            {
                Verse();
            }
            else if (Card.Image is not null)
            {
                BackgroundImage = new Bitmap(Card.Image.GetStream());
            }
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
