using TcgDomain.Enums;
using TcgInfra.CustomExceptions;

namespace TcgForms.AppServices
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

        public PhasePlayerEnum NextPhasePlayer(PhasePlayerEnum phasePlayer)
        {
            switch (phasePlayer)
            {
                case PhasePlayerEnum.Player:
                    return PhasePlayerEnum.Opponent;

                case PhasePlayerEnum.Opponent:
                    return PhasePlayerEnum.Player;

                default:
                    throw new BusinessException("Fase não definida");
            }
        }
    }
}
