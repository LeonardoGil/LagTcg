using TcgDomain.Entities.Cards.Abstract;

namespace TcgDomain.Entities.Battles
{
    public class DuelField
    {
        public DuelField()
        {
            MonstersField = new CardsFieldCollection<MonsterCard>(5);
            SpecialField = new CardsFieldCollection<SpecialCard>(5);

            Graveyard = new List<dynamic>();
        }

        public List<dynamic> Graveyard { get; set; }

        public CardsFieldCollection<MonsterCard> MonstersField { get; set; }

        public CardsFieldCollection<SpecialCard> SpecialField { get; set; }

        public SpecialCard FieldCard { get; set; }
    }
}
