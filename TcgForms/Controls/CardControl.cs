using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;

namespace TcgForms.Controls
{
    public partial class CardControl : UserControl
    {
        public readonly dynamic OriginalCard; 

        public readonly Card Card; 
        
        public readonly TypeCardEnum TypeCard;

        public CardControl(dynamic originalCard)
        {
            (originalCard as object).OnlyCard();

            InitializeComponent();

            var card = originalCard as Card;

            Card = card;
            BackgroundImage = new Bitmap(card.Image.GetStream());
            TypeCard = card.GetTypeCard();
        }

        private void MenuItemInvokeNormalCard_Click(object sender, EventArgs e)
        {

        }
    }
}
