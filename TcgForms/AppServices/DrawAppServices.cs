using System.ComponentModel;
using TcgForms.Controls;

namespace TcgForms.Services
{
    public class DrawAppServices
    {
        private readonly ComponentResourceManager resources;

        public DrawAppServices()
        {
            resources = new ComponentResourceManager(typeof(CardControl));
        }

        public void LoadCardForControl(CardControl cardInHand, Control control)
        {
            control.Controls.Add(cardInHand);
            control.SuspendLayout();

            cardInHand.BackgroundImageLayout = ImageLayout.Stretch;
            cardInHand.Name = "Card";
            cardInHand.Size = new Size(100, 140);

            control.ResumeLayout(false);
        }
    }
}
