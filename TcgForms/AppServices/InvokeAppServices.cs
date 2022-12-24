using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards;

namespace TcgForms.AppServices
{
    public class InvokeAppServices
    {
        public bool CanInvokeNormalMonster(NormalCard card, Player player)
        {
            switch (card.RangeMonsterLevel)
            {
                case TcgDomain.Enums.RangeMonsterLevelEnum.OneToFour:
                    return true;

                case TcgDomain.Enums.RangeMonsterLevelEnum.FiveAndSix:
                    return CanInvokeMonsterLevelFiveAndSix(player);

                case TcgDomain.Enums.RangeMonsterLevelEnum.SevenOrMore:
                    return CanInvokeMonsterLevelSevenOrMore(player);

                default:
                    return false;
            }
        }

        public bool CanInvokeMonsterLevelFiveAndSix(Player player)
        {
            return player.MonstersField.Any(x => x is not null);
        }

        public bool CanInvokeMonsterLevelSevenOrMore(Player player)
        {
            return player.MonstersField.Count(x => x is not null) >= 2;
        }
    }
}
