using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Entities.Cards;

namespace TcgDomain.Extensions
{
    public static class DynamicCardExtensions
    {
        public static bool IsCard(this object card)
        {
            return card is not MonsterCard || card is not EffectCard;
        }
    }
}
