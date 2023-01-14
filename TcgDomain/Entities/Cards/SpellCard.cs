using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Entities.Effects;
using TcgDomain.Enums;

namespace TcgDomain.Entities.Cards
{
    public class SpellCard : SpecialCard
    {
        public SpellCardTypeEnum Type { get; set; }

        public List<EffectCollection> Effects { get; set; }
    }
}