﻿using TcgDomain.Entities.Battles;

namespace TcgForms.AppServices
{
    public class DrawAppServices
    {
        public void DrawCards(Player player, int quantity)
        {
            for (var i = 0; i < quantity; i++)
                player.Deck.Draw();
        }
    }
}
