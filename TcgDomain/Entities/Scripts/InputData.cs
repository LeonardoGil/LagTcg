using TcgDomain.Entities.Battles;
using TcgDomain.Enums;

namespace TcgDomain.Entities.Scripts
{
    public class InputData
    {
        public PhaseEnum Phase { get; set; }

        public Player Opponent { get; set; }

        public Bot Bot { get; set; }
    }
}
