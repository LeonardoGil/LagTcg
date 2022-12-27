using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgInfra.CustomExceptions;

namespace TcgDomain.Entities.Battles
{
    public class Player
    {
        public Player()
        {
            CanInvoke = true;

            MonstersField = new dynamic[5];
            SpecialField = new dynamic[5];

            Graveyard = new List<dynamic>();
        }

        public string Username { get; set; }

        public int PointLife { get; set; }

        public TypePlayerEnum Type { get; set; }

        public Deck Deck { get; set; }

        public Deck ExtraDeck { get; set; }

        public List<dynamic> Graveyard { get; set; }

        public dynamic[] MonstersField { get; set; }

        public dynamic[] SpecialField { get; set; }

        public bool CanInvoke { get; set; }

        public void ResetAction()
        {
            CanInvoke = true;

            MonstersField.OfType<MonsterCard>().ToList().ForEach(x => x.ResetAction());
        }
    }
}
