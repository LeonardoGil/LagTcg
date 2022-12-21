using TcgDomain.Enums;

namespace TcgDomain.Entities.Cards.Abstract
{
    public abstract class MonsterCard : Card
    {
        public uint Attack { get; set; }

        public uint Defense { get; set; }

        public byte Level { get; set; }

        public AttributeEnum Attribute { get; set; }
        
        public TypeMonsterEnum Type { get; set; }
    }
}
