using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgInfra.CustomExceptions;

namespace TcgDomain.Entities
{
    public class Deck
    {
        public string Description { get; set; }

        public List<dynamic> Cards { get; private set; }

        public void AddCard(dynamic card)
        {
            if (card is not MonsterCard || card is not EffectCard)
                throw new BusinessException("Tipo de objeto não e compatível com Deck.");

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
