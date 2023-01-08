using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Extensions;
using TcgInfra.CustomExceptions;

namespace TcgDomain.Entities.Decks
{
    public class Deck
    {
        public event EventHandler DrawCard;

        public Deck()
        {
            Cards = new List<dynamic>();
        }

        public string Description { get; set; }

        public List<dynamic> Cards { get; private set; }

        public void AddCard(dynamic card)
        {
            (card as object).OnlyCard();

            var numberCards = Cards.Count(c => c == card);

            if (numberCards >= 3)
                throw new BusinessException("Já possui 3 Cards iguais no Deck.");

            (card as Card).SetImage();

            Cards.Add(card);
        }

        public void RemoveCard(dynamic card)
        {
            Cards.Remove(card);
        }

        public dynamic Draw()
        {
            if (!Cards.Any())
                throw new FatalException("Acabou as cartas!");

            var card = Cards.First();
            Cards.Remove(card);

            DrawCard?.Invoke(card, EventArgs.Empty);

            return card;
        }

        public void Shuffle()
        {
            var random = new Random();
            Cards = Cards.OrderBy(x => random.Next()).ToList();
        }
    }
}
