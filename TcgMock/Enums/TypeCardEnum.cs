using System.ComponentModel;

namespace TcgMock.Enums
{
    public enum TypeCardEnum
    {
        [Description("Normal Monster")]
        NormalMonster = 0,

        [Description("Effect Monster")]
        EffectMonster = 1,

        [Description("Fusion Monster")]
        FusionMonster = 2,
        
        [Description("Spell Card")]
        SpellCard = 3,

        [Description("Trap Card")]
        TrapCard = 4,
    }
}
