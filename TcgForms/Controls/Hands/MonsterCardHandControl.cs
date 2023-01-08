using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgForms.AppServices;
using TcgForms.Forms;

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

            var cardsForSacrifice = default(List<Card>);

            switch (monsterCard.RangeMonsterLevel)
            {
                case TcgDomain.Enums.RangeMonsterLevelEnum.OneToFour:
                    InvokeAppServices.Invoke(player, OriginalCard);
                    Remove?.Invoke(this, EventArgs.Empty);
                    return;

               
                case TcgDomain.Enums.RangeMonsterLevelEnum.FiveAndSix:
                    cardsForSacrifice = InvokeAppServices.SelectCardsForAttribute(player.DuelField.MonstersField.All.OfType<Card>().ToList(), 1);
                    break;

                case TcgDomain.Enums.RangeMonsterLevelEnum.SevenOrMore:
                    cardsForSacrifice = InvokeAppServices.SelectCardsForAttribute(player.DuelField.MonstersField.All.OfType<Card>().ToList(), 2);
                    break;
            }


            if (cardsForSacrifice is null || !cardsForSacrifice.Any())
                return;

            InvokeAppServices.SacrificeForInvoke(player, cardsForSacrifice, OriginalCard);

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
