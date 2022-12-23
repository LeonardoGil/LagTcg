namespace TcgDomain.Entities.Battles
{
    public class DuelDeck
    {
        private Deck OriginalDeck;

        private List<dynamic> Cards;

        public DuelDeck(Deck deck)
        {
            OriginalDeck = deck;
            Cards = OriginalDeck.Cards.ToList();
        }

        public dynamic Draw()
        {
            var card = Cards.First();
            Cards.Remove(card);

            return card;
        }

        public void Shuffle()
        {
            var random = new Random();
            Cards = Cards.OrderBy(x => random.Next()).ToList();
        }
    }
}
