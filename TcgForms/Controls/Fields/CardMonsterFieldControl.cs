using TcgDomain.Entities.Cards;

namespace TcgForms.Controls.Fields
{
    public partial class CardMonsterFieldControl : CardControl
    {
        public CardMonsterFieldControl()
        {
            InitializeComponent();
        }

        public CardMonsterFieldControl(NormalCard card) : base(card)
        {
            InitializeComponent();
        }

        public CardMonsterFieldControl(EffectCard card) : base(card)
        {
            InitializeComponent();
        }
    }
}
