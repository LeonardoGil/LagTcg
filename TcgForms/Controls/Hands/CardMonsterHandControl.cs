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

        #region Events

        private void menuItemInvoke_Click(object sender, EventArgs e)
        {
            (ParentForm as DuelFieldForm).InvokePlayerMonster(this);
        }

        private void menuItemSpecialInvoke_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuItemSet_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        
        private async void contextMenuCardMonster_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var card = OriginalCard as MonsterCard;
            var duelFieldForm = (ParentForm as DuelFieldForm);

            var validateInvoke = InvokeAppServices.CanInvokeMonster(card, duelFieldForm.Player);
            var validatePhase = InvokeAppServices.CanInvokeMonster(duelFieldForm.Phase, duelFieldForm.PhasePlayer);

            var validate = validateInvoke && validatePhase;

            menuItemInvoke.Visible = validate;
            menuItemSpecialInvoke.Visible = false;
            menuItemSet.Visible = validate;
        }

        #endregion
    }
}
