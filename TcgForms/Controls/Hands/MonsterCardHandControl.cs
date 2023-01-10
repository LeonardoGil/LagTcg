using System.ComponentModel;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgApplication.AppServices;
using TcgForms.Forms;
using TcgInfra.CustomMessages;

namespace TcgForms.Controls.Hands
{
    public partial class MonsterCardHandControl : CardControl
    {
        public event EventHandler Remove;

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

        #region Private Methods

        private void Invoke(MonsterCard monsterCard)
        {
            var player = (ParentForm as CardsHandForm).DuelFieldForm.Player;

            var numberCardForSacrifice = 0;

            switch (monsterCard.RangeMonsterLevel)
            {
                case TcgDomain.Enums.MonsterRangeLevelEnum.OneToFour:
                    InvokeAppServices.Invoke(player, OriginalCard);
                    Remove?.Invoke(this, EventArgs.Empty);
                    return;

               
                case TcgDomain.Enums.MonsterRangeLevelEnum.FiveAndSix:
                    numberCardForSacrifice = 1;
                    break;

                case TcgDomain.Enums.MonsterRangeLevelEnum.SevenOrMore:
                    numberCardForSacrifice = 2;
                    break;
            }

            var cardsForSacrifice = default(List<Card>);

            if (MessageBox.Show(string.Format(DialogMessage.InvokeAttribute, numberCardForSacrifice), "Invoke", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var message = $"Selecione {numberCardForSacrifice} carta(s)";

                var cards = player.DuelField.MonstersField.All.OfType<Card>().ToList();

                using (var selectCardForm = new SelectCardForm(cards, message, numberCardForSacrifice))
                {
                    selectCardForm.ShowDialog();
                    if (selectCardForm.DialogResult == DialogResult.OK)
                    {
                        cardsForSacrifice = selectCardForm.CardsSelected;
                    }
                }
            }

            if (cardsForSacrifice is null || !cardsForSacrifice.Any())
                return;

            InvokeAppServices.InvokeSacrifice(player, cardsForSacrifice, OriginalCard);

            Remove?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Events

        private void menuItemInvoke_Click(object sender, EventArgs e)
        {
            Invoke(MonsterCard);
        }

        private void menuItemSpecialInvoke_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuItemSet_Click(object sender, EventArgs e)
        {
            MonsterCard.Set = true;

            Invoke(MonsterCard);
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
