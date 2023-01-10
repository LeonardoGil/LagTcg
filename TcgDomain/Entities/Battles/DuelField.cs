using System.Numerics;
using TcgDomain.Entities.Cards.Abstract;

namespace TcgDomain.Entities.Battles
{
    public class DuelField
    {
        private readonly int[] _Position = { 2, 1, 3, 0, 4 };

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

        public void Invoke(dynamic card)
        {
            foreach (var position in _Position)
            {
                var monster = MonstersField[position];

                if (monster is not null)
                    continue;

                MonstersField[position] = card;
                return;
            }
        }

        public void InvokeSacrifice(dynamic card, List<Card> sacrifices)
        {
            for (int position = 0; position < 5; position++)
            {
                var monster = MonstersField[position];

                if (monster is null)
                    continue;

                var monsterCard = monster as Card;

                if (sacrifices.Contains(monsterCard))
                {
                    Graveyard.Add(MonstersField[position]);
                    MonstersField[position] = null;
                }
            }

            Invoke(card);
        }
    }
}
