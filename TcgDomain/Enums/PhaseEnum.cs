using System.ComponentModel;

namespace TcgDomain.Enums
{
    public enum PhaseEnum
    {
        [Description("DrawCard Phase")]
        DrawPhase = 0,

        [Description("Standby Phase")]
        StandbyPhase = 1,

        [Description("Main Phase 1")]
        MainPhaseOne = 2,

        [Description("Battle Phase")]
        BattlePhase = 3,

        [Description("Main Phase 2")]
        MainPhaseTwo = 4,

        [Description("End Phase")]
        EndPhase = 5
    }
}
