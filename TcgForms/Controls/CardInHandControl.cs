using TcgDomain.Extensions;
using TcgInfra.CustomExceptions;
using TcgInfra.CustomMessages;

namespace TcgForms.Controls
{
    public partial class CardInHandControl : UserControl
    {
        public CardInHandControl()
        {
            //if (((object)card).IsCard())
            //    throw new BusinessException(ErrorMessage.DynamicCardInvalid);

            InitializeComponent();
        }
    }
}
