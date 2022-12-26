using System.ComponentModel;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgForms.AppServices;
using TcgForms.Forms;

namespace TcgForms.Controls.Hands
{
    public partial class CardMonsterHandControl : CardControl
    {
        private readonly InvokeAppServices InvokeAppServices = new InvokeAppServices();

        public CardMonsterHandControl()
        {
            InitializeComponent();
        }

        public CardMonsterHandControl(NormalCard card) : base(card)
        {
            InitializeComponent();
        }

        public CardMonsterHandControl(EffectCard card) : base(card)
        {
            InitializeComponent();
        }

        #region Public Methods

        #endregion

        #region Events

        private void menuItemInvoke_Click(object sender, EventArgs e)
        {
            var monsterCard = OriginalCard as MonsterCard;

            switch (monsterCard.RangeMonsterLevel)
            {
                case TcgDomain.Enums.RangeMonsterLevelEnum.OneToFour:
                    (ParentForm as MyCardsForm).DuelFieldForm.InvokePlayerMonster(this);
                    break;

                case TcgDomain.Enums.RangeMonsterLevelEnum.FiveAndSix:
                    (ParentForm as MyCardsForm).DuelFieldForm.InvokePlayerMonsterAttribute(this, 1);
                    break;

                case TcgDomain.Enums.RangeMonsterLevelEnum.SevenOrMore:
                    (ParentForm as MyCardsForm).DuelFieldForm.InvokePlayerMonsterAttribute(this, 2);
                    break;
            }
        }

        private void menuItemSpecialInvoke_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuItemSet_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void contextMenuCardMonster_Opening(object sender, CancelEventArgs e)
        {
            var card = OriginalCard as MonsterCard;
            var myCardsForm = ParentForm as MyCardsForm;
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
