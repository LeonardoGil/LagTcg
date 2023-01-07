using System.ComponentModel;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgForms.AppServices;
using TcgForms.Forms;

namespace TcgForms.Controls.Hands
{
    public partial class MonsterCardHandControl : CardControl
    {
        private readonly InvokeAppServices InvokeAppServices = new InvokeAppServices();

        public MonsterCard MonsterCard { get => OriginalCard as MonsterCard; }

        public MonsterCardHandControl()
        {
            InitializeComponent();
        }

        public MonsterCardHandControl(NormalCard card) : base(card)
        {
            InitializeComponent();
        }

        public MonsterCardHandControl(EffectCard card) : base(card)
        {
            InitializeComponent();
        }

        #region Public Methods

        #endregion

        #region Private Methods

        private void Invoke(MonsterCard monsterCard, bool set)
        {
            switch (monsterCard.RangeMonsterLevel)
            {
                case TcgDomain.Enums.RangeMonsterLevelEnum.OneToFour:
                    (ParentForm as CardsHandForm).DuelFieldForm.InvokePlayerMonster(this, set);
                    break;

                case TcgDomain.Enums.RangeMonsterLevelEnum.FiveAndSix:
                    (ParentForm as CardsHandForm).DuelFieldForm.InvokePlayerMonsterAttribute(this, 1, set);
                    break;

                case TcgDomain.Enums.RangeMonsterLevelEnum.SevenOrMore:
                    (ParentForm as CardsHandForm).DuelFieldForm.InvokePlayerMonsterAttribute(this, 2, set);
                    break;
            }
        }

        #endregion

        #region Events

        private void menuItemInvoke_Click(object sender, EventArgs e)
        {
            Invoke(MonsterCard, MonsterCard.Set);
        }

        private void menuItemSpecialInvoke_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuItemSet_Click(object sender, EventArgs e)
        {
            MonsterCard.Set = true;

            Invoke(MonsterCard, MonsterCard.Set);
        }

        private void contextMenuCardMonster_Opening(object sender, CancelEventArgs e)
        {
            var card = OriginalCard as MonsterCard;
            var myCardsForm = ParentForm as CardsHandForm;
            var duelFieldForm = myCardsForm.DuelFieldForm;

            var validateInvoke = InvokeAppServices.CanInvokeMonster(card, duelFieldForm.Player);
            var validatePhase = InvokeAppServices.CanInvokeMonster(duelFieldForm.Phase, duelFieldForm.PhasePlayer);

            var validate = validateInvoke && validatePhase;

            menuItemInvoke.Visible = validate;
            menuItemSpecialInvoke.Visible = false;
            menuItemSet.Visible = validate;
        }

        private void CardMonsterHandControl_Paint(object sender, PaintEventArgs e)
        {
            ContextMenuStrip.Items.Add(GetMenuItemZoom());
        }

        #endregion
    }
}
