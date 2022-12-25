using TcgDomain.Entities.Battles;

namespace TcgForms.AppServices
{
    public class DrawAppServices
    {
        public List<dynamic> DrawCards(Player player, int quantity)
        {
            var cards = new List<dynamic>();

            for (var i = 0; i < quantity; i++)
                cards.Add(player.Deck.Draw());

            return cards;
        }
    }
}
