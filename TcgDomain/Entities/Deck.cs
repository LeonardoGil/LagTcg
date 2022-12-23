using TcgDomain.Extensions;
using TcgInfra.CustomExceptions;
using TcgInfra.CustomMessages;

namespace TcgDomain.Entities
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<dynamic>();
        }

        public string Description { get; set; }

        public List<dynamic> Cards { get; private set; }

        public void AddCard(dynamic card)
        {
            if (((object)card).IsCard())
                throw new BusinessException(ErrorMessage.DynamicCardInvalid);

            var numberCards = Cards.Count(c => c == card);

            if (numberCards >= 3)
                throw new BusinessException("Já possui 3 cards iguais no Deck.");

            Cards.Add(card);
        }
        
        public void RemoveCard(dynamic card)
        {
            Cards.Remove(card);
        }
    }
}
