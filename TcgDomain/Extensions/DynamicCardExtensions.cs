using TcgDomain.Entities.Cards;
using TcgDomain.Enums;
using TcgInfra.CustomExceptions;
using TcgInfra.CustomMessages;

namespace TcgDomain.Extensions
{
    public static class DynamicCardExtensions
    {
        public static void OnlyCard(this object card)
        {
            if (!IsCard(card))
                throw new BusinessException(ErrorMessage.DynamicCardInvalid);
        }

        public static bool IsCard(this object card)
        {
            return card is NormalCard || card is EffectCard;
        }

        public static TypeCardEnum GetTypeCard(this object card)
        {
            if (card is NormalCard)
                return TypeCardEnum.NormalMonster;

            if (card is EffectCard)
                return TypeCardEnum.EffectMonster;

            if (card is MagicCard)
                return TypeCardEnum.SpellCard;

            if (card is TrapCard)
                return TypeCardEnum.TrapCard;

            throw new BusinessException("Object não e um tipo Card");
        }
    }
}
