﻿using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;

namespace TcgForms.AppServices
{
    public class InvokeAppServices
    {
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
