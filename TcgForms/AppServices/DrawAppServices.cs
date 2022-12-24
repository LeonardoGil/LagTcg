using System.ComponentModel;
using TcgForms.Controls;

namespace TcgForms.AppServices
{
    public class DrawAppServices
    {
        public DrawAppServices() { }

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
