using TcgDomain.Entities.Battles;

namespace TcgDomain.Scripts
{
    public class BasicScript
    {
        public void On(InputData data)
        {
            switch (data.Phase)
            {
                case Enums.PhaseEnum.DrawPhase:
                    DrawPhaseScript(data.Bot);
                    break;

                case Enums.PhaseEnum.MainPhaseOne:
                    break;

                case Enums.PhaseEnum.BattlePhase:
                    break;

                case Enums.PhaseEnum.MainPhaseTwo:
                    break;
            }
        }

        private void DrawPhaseScript(Player player)
        {

        }

        private void MainPhaseScript()
        {

        }

        private void BattlePhaseScript()
        {

        }

        private void MainPhaseTwoScript()
        {

        }
    }
}
