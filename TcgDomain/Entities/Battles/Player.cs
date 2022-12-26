using TcgDomain.Entities.Cards.Abstract;
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

        public bool CanInvoke { get; set; }

        public Deck Deck;

        public Deck ExtraDeck;

        public List<dynamic> Graveyard;

        public dynamic[] MonstersField; 

        public dynamic[] SpecialField;

        public void ResetAction()
        {
            CanInvoke = true;

            MonstersField.OfType<MonsterCard>().ToList().ForEach(x => x.ResetAction());
        }
    }
}
