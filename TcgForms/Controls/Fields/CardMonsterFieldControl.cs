using TcgDomain.Entities.Cards;
using TcgDomain.Enums;

namespace TcgForms.Controls.Fields
{
    public partial class CardMonsterFieldControl : CardControl
    {
        public DuelPositionEnum DuelPosition { get; set; }

        public bool Set { get; set; }

        public bool CanChangePosition { get; set; }

        public CardMonsterFieldControl()
        {
            InitializeComponent();
        }

        public CardMonsterFieldControl(NormalCard card, bool set = false) : base(card)
        {
            InitializeComponent();
        }

        public CardMonsterFieldControl(EffectCard card, bool set = false) : base(card)
        {
            InitializeComponent();
        }
    }
}
