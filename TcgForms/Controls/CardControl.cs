using TcgDomain.Extensions;
using TcgInfra.CustomExceptions;
using TcgInfra.CustomMessages;

namespace TcgForms.Controls
{
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            //if (((object)card).IsCard())
            //    throw new BusinessException(ErrorMessage.DynamicCardInvalid);

            InitializeComponent();
        }
    }
}
