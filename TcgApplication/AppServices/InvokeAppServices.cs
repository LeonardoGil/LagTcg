using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgInfra.CustomExceptions;
using TcgInfra.CustomMessages;

namespace TcgApplication.AppServices
{
    public class InvokeAppServices
    {
        private readonly int[] _Position = { 2, 1, 3, 0, 4 };
        private readonly int[] _SortPosition = { 0, 1, 2, 3, 4 };

        public void Invoke(Player player, dynamic card)
        {
            player.DuelField.Invoke(card);
            player.CanInvoke = false;
            player.Cards.Remove(card);
        }

        public void InvokeSacrifice(Player player, List<Card> sacrifices, dynamic card)
        {
            player.DuelField.InvokeSacrifice(card, sacrifices);
            player.CanInvoke = false;
            player.Cards.Remove(card);
        }

        public bool CanInvokeMonster(MonsterCard card, Player player)
        {
            if (!player.CanInvoke)
                return false;

            switch (card.RangeMonsterLevel)
            {
                case TcgDomain.Enums.MonsterRangeLevelEnum.OneToFour:
                    return HasSpaceInField(player);

                case TcgDomain.Enums.MonsterRangeLevelEnum.FiveAndSix:
                    return CanInvokeMonsterForAttribute(player, 1);

                case TcgDomain.Enums.MonsterRangeLevelEnum.SevenOrMore:
                    return CanInvokeMonsterForAttribute(player, 2);

                default:
                    return false;
            }
        }

        public bool CanInvokeMonster(PhaseEnum phase, PlayerTypeEnum phasePlayer)
        {
            return phasePlayer == PlayerTypeEnum.Player && (phase == PhaseEnum.MainPhaseOne || phase == PhaseEnum.MainPhaseTwo);
        }

        public bool CanInvokeMonsterForAttribute(Player player, int attributes)
        {
            return player.DuelField.MonstersField.All.Count(x => x is not null) >= attributes;
        }

        public bool HasSpaceInField(Player player)
        {
            return player.DuelField.MonstersField.All.Any(x => x is null);
        }
    }
}
