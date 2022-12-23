using System.ComponentModel;
using TcgForms.Controls;

namespace TcgForms.Services
{
    public class DrawServices
    {
        private readonly ComponentResourceManager resources;

        public DrawServices()
        {
            resources = new ComponentResourceManager(typeof(CardControl));
        }

        public void LoadCardForControl(CardControl cardInHand, Control control)
        {
            control.Controls.Add(cardInHand);
            control.SuspendLayout();

            cardInHand.BackgroundImageLayout = ImageLayout.Stretch;
            cardInHand.Name = "Card";
            cardInHand.Size = new Size(80, 120);

            control.ResumeLayout(false);
        }
    }
}
