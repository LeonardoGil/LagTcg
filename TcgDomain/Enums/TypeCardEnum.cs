using System.ComponentModel;

namespace TcgDomain.Enums
{
    public enum TypeCardEnum
    {
        [Description("Normal Monster")]
        NormalMonster = 0,

        [Description("Effect Monster")]
        EffectMonster = 1,

        [Description("Ritual Monster")]
        RitualMonster = 2,

        [Description("Fusion Monster")]
        FusionMonster = 3,
        
        [Description("Spell Card")]
        SpellCard = 4,

        [Description("Trap Card")]
        TrapCard = 5,
    }
}
