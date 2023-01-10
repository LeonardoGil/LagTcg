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

        public PlayerTypeEnum NextPhasePlayer(PlayerTypeEnum phasePlayer)
        {
            switch (phasePlayer)
            {
                case PlayerTypeEnum.Player:
                    return PlayerTypeEnum.Opponent;

                case PlayerTypeEnum.Opponent:
                    return PlayerTypeEnum.Player;

                default:
                    throw new BusinessException("Fase não definida");
            }
        }
    }
}
