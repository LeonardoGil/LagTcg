using System.Linq;
using TcgForms.Controls.Hands;

namespace TcgForms.Forms
{
    public partial class CardsHandForm : Form
    {
        public List<dynamic> CardControls { get; set; }

        public List<CardMonsterHandControl> CardMonsterControls { get => CardControls.Where(x => x is CardMonsterHandControl).OfType<CardMonsterHandControl>().ToList(); }

        public DuelFieldForm DuelFieldForm { get; set; }

        public CardsHandForm()
        {
            InitializeComponent();

            CardControls = new List<dynamic>();
        }

        public void AddCard(dynamic cardControl)
        {
            CardControls.Add(cardControl);
        }

        public void RemoveCard(dynamic cardControl)
        {
            CardControls.Remove(cardControl);
        }

        public void AddCardFromHand(CardMonsterHandControl cardControl)
        {
            flowLayoutPanelHands.Controls.Add(cardControl);

            flowLayoutPanelHands.SuspendLayout();

            flowLayoutPanelHands.ResumeLayout(false);
        }
        
        public void RemoveCardFromHand(CardMonsterHandControl cardControl)
        {
            flowLayoutPanelHands.Controls.Remove(cardControl);

            flowLayoutPanelHands.SuspendLayout();

            flowLayoutPanelHands.ResumeLayout(false);
        }

        private void MyCardsForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanelHands.Controls.Clear();

            foreach (var control in CardControls)
            {
                AddCardFromHand(control);
            }
        }
    }
}
