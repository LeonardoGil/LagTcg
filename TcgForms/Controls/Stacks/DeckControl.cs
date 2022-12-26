using TcgDomain.Enums;
using TcgForms.Forms;

namespace TcgForms.Controls.Stacks
{
    public partial class DeckControl : StackOfCardsControl
    {
        public DeckControl()
        {
            InitializeComponent();
        }

        private void menuItemDraw_Click(object sender, EventArgs e)
        {
            var duelField = ParentForm as DuelFieldForm;

            duelField.DrawCardPlayer();
            duelField.NextPhase();
        }

        private void contextMenuDeck_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var duelField = ParentForm as DuelFieldForm;

            menuItemDraw.Enabled = duelField.Phase == PhaseEnum.DrawPhase && duelField.PhasePlayer == PhasePlayerEnum.Player;
        }
    }
}
