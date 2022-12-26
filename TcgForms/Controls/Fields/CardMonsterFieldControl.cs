using System.ComponentModel;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;

namespace TcgForms.Controls.Fields
{
    public partial class CardMonsterFieldControl : CardControl
    {
        public MonsterCard MonsterCard { get => OriginalCard as MonsterCard; }

        public bool Set { get; set; }

        public CardMonsterFieldControl()
        {
            InitializeComponent();
        }

        public CardMonsterFieldControl(NormalCard card, bool set = false) : base(card)
        {
            InitializeComponent();

            if (set) Verse();
        }

        public CardMonsterFieldControl(EffectCard card, bool set = false) : base(card)
        {
            InitializeComponent();

            if (set) Verse();
        }

        private void CardMonsterFieldControl_Paint(object sender, PaintEventArgs e)
        {
            ContextMenuStrip.Items.Add(GetMenuItemZoom());
        }

        private void contextMenuMonsterCard_Opening(object sender, CancelEventArgs e)
        {
            menuItemChangePosition.Visible = MonsterCard.CanChangePosition;
            menuItemAttack.Visible = MonsterCard.CanAttack && MonsterCard.DuelPosition == DuelPositionEnum.Atk;
        }

        private void menuItemChangePosition_Click(object sender, EventArgs e)
        {
            Verse();
            MonsterCard.CanChangePosition = false;
        }
    }
}
