using TcgDomain.Entities.Battles;
using TcgDomain.Enums;
using TcgForms.AppServices;
using TcgForms.Forms;

namespace TcgForms.Controls.Stacks
{
    public partial class DeckControl : StackOfCardsControl
    {
        private readonly DrawAppServices DrawAppServices = new DrawAppServices();

        public DeckControl()
        {
            InitializeComponent();
        }

        public void Draw(int quantity = 1)
        {
            var duelField = ParentForm as DuelFieldForm;

            DrawAppServices.DrawCards(duelField.Player, quantity);
        }

        private void menuItemDraw_Click(object sender, EventArgs e)
        {
            Draw();

            (ParentForm as DuelFieldForm).NextPhase();
        }

        private void contextMenuDeck_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var duelField = ParentForm as DuelFieldForm;

            menuItemDraw.Enabled = duelField.Phase == PhaseEnum.DrawPhase && duelField.PhasePlayer == TypePlayerEnum.Player;
        }
    }
}
