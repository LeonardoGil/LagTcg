using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgForms.AppServices;
using TcgForms.Forms;

namespace TcgForms.Controls
{
    public partial class CardControl : UserControl
    {
        public readonly dynamic OriginalCard; 

        public readonly Card Card; 
        
        public readonly TypeCardEnum TypeCard;

        private readonly InvokeAppServices InvokeAppServices;
        
        public CardControl(dynamic originalCard)
        {
            (originalCard as object).OnlyCard();

            InitializeComponent();

            OriginalCard = originalCard;
            Card = originalCard as Card;
            BackgroundImage = new Bitmap(Card.Image.GetStream());
            TypeCard = Card.GetTypeCard();

            InvokeAppServices = new InvokeAppServices();
        }

        public CardControl()
        {
            InitializeComponent();
        }

        private void MenuItemInvokeNormalCard_Click(object sender, EventArgs e)
        {
            (ParentForm as DuelFieldForm).InvokePlayerMonster(this);
        }

        private void contextMenuCard_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var card = OriginalCard as NormalCard;
            var player = (ParentForm as DuelFieldForm).Player;

            MenuItemInvokeNormalCard.Visible = InvokeAppServices.CanInvokeNormalMonster(card, player);
        }
    }
}
