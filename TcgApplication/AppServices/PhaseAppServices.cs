using TcgDomain.Enums;
using TcgInfra.CustomExceptions;

namespace TcgApplication.AppServices
{
    public class PhaseAppServices
    {
        public PhaseEnum NextPhase(PhaseEnum phase)
        {
            if (phase == PhaseEnum.EndPhase)
            {
                phase = PhaseEnum.DrawPhase;
            }
            else
            {
                phase = phase + 1;
            }

            return phase;
        }

        public TypePlayerEnum NextPhasePlayer(TypePlayerEnum phasePlayer)
        {
            switch (phasePlayer)
            {
                case TypePlayerEnum.Player:
                    return TypePlayerEnum.Opponent;

                case TypePlayerEnum.Opponent:
                    return TypePlayerEnum.Player;

                default:
                    throw new BusinessException("Fase não definida");
            }
        }
    }
}
