﻿using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Extensions;
using TcgForms.Forms;

namespace TcgForms.Controls
{
    public partial class CardControl : UserControl
    {
        public readonly dynamic OriginalCard; 

        public readonly Card Card; 
        
        public CardControl(dynamic originalCard)
        {
            InitializeComponent();

            OriginalCard = originalCard;
            Card = originalCard as Card;

            if (Card.Image is not null)
                BackgroundImage = new Bitmap(Card.Image.GetStream());
        }

        public CardControl()
        {
            InitializeComponent();
        }

        private void CardControl_DoubleClick(object sender, EventArgs e)
        {
            using (var form = new InfoCardForm(Card))
            {
                form.ShowDialog();
            }
        }
    }
}
