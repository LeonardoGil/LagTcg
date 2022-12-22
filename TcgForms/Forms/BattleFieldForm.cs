using TcgDomain.Entities.Battles;

namespace TcgForms.Forms
{
    public partial class BattleFieldForm : Form
    {
        protected Player User { get; set; }

        protected Player Opponent { get; set; }

        public BattleFieldForm(Player user, Player opponent)
        {
            InitializeComponent();

            User = user;
            Opponent = opponent;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            var card = User.Deck.Draw();
        }
    }
}