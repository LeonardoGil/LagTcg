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

        public static CardTypeEnum GetTypeCard(this object card)
        {
            if (card is NormalCard)
                return CardTypeEnum.NormalMonster;

            if (card is EffectCard)
                return CardTypeEnum.EffectMonster;

            if (card is SpellCard)
                return CardTypeEnum.SpellCard;

            if (card is TrapCard)
                return CardTypeEnum.TrapCard;

            throw new BusinessException("Object não e um tipo Card");
        }
    }
}
