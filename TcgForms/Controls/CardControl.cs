using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Extensions;
using TcgInfra.CustomExceptions;
using TcgInfra.CustomMessages;

namespace TcgForms.Controls
{
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }

        public CardControl(Card card)
        {
            if (card.IsCard())
                throw new BusinessException(ErrorMessage.DynamicCardInvalid);
        }
    }
}
