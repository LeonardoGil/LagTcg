using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Decks;

namespace TcgMock.Decks
{
    public static class YugiMutoDeck
    {
        private static int[] CardIds => new int[] { 46986414, 6368038, 70781052, 28279543, 67724379, 91152256, 87796900, 41392891, 69669405, 32452818, 53829412, 15025844, 13039848, 40374923, 80813021, 95727991, 40640057 };
            
        public static Deck Get(List<NormalCard> cardsDto)
        {
            var deck = new Deck
            {
                Description = "Yugi-Muto Deck"
            };

            cardsDto.Where(x => CardIds.Contains(x.Serie)).ToList().ForEach(deck.AddCard);

            return deck;
        }

    }
}
 