using TcgDomain.Entities.Cards.Abstract;

namespace TcgForms.Controls.Hands
{
    public partial class CardMonsterHandControl : CardControl
    {
        public CardMonsterHandControl()
        {
            InitializeComponent();
        }

        public CardMonsterHandControl(MonsterCard card) : base(card)
        {
            InitializeComponent();
        }
    }
}
