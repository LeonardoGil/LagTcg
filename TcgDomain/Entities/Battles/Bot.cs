using TcgDomain.Scripts;

namespace TcgDomain.Entities.Battles
{
    public class Bot : Player
    {
        public readonly BasicScript DuelScript = new BasicScript();

        public Bot() : base()
        {
            Type = Enums.TypePlayerEnum.Opponent;
        }
    }
}
