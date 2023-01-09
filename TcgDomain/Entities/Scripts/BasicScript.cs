using TcgDomain.Entities.Battles;

namespace TcgDomain.Entities.Scripts
{
    public abstract class BasicScript
    {
        public abstract void On(InputData data);

        protected abstract void DrawPhaseScript(Player bot);

        protected abstract void MainPhaseScript(Player bot, Player opponent);

        protected abstract void BattlePhaseScript(Player bot, Player opponent);

        protected abstract void MainPhaseTwoScript(Player bot, Player opponent);
    }
}