using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgInfra.CustomExceptions;

namespace TcgForms.AppServices
{
    public class InvokeAppServices
    {
        /// <returns>Retorna a posição de invocação</returns>
        public int Invoke(Player player, dynamic card)
        {
            foreach (var monster in player.MonstersField.Select((card, index) => new { Card = card, Index = index }))
            {
                if (monster.Card is not null)
                    continue;

                player.MonstersField[monster.Index] = card;
                return monster.Index;
            }

            throw new BusinessException("Não há posição disponivel em campo");
        }

        public bool CanInvokeMonster(MonsterCard card, Player player)
        {
            switch (card.RangeMonsterLevel)
            {
                case TcgDomain.Enums.RangeMonsterLevelEnum.OneToFour:
                    return HasSpaceInField(player);

                case TcgDomain.Enums.RangeMonsterLevelEnum.FiveAndSix:
                    return CanInvokeMonsterForAttribute(player, 1);

                case TcgDomain.Enums.RangeMonsterLevelEnum.SevenOrMore:
                    return CanInvokeMonsterForAttribute(player, 2);

                default:
                    return false;
            }
        }

        public bool CanInvokeMonster(PhaseEnum phase, PhasePlayerEnum phasePlayer)
        {
            return phasePlayer == PhasePlayerEnum.Player && (phase == PhaseEnum.MainPhaseOne || phase == PhaseEnum.MainPhaseTwo);
        }

        public static bool CanInvokeMonsterForAttribute(Player player, int attributes)
        {
            return player.MonstersField.Count(x => x is not null) >= attributes;
        }

        public static bool HasSpaceInField(Player player)
        {
            return player.MonstersField.Any(x => x is null);
        }
    }
}
