using TcgDomain.Entities.Cards.Abstract;

namespace TcgDomain.Entities.Battles
{
    public class Player
    {
        public Player()
        {
            ResetAction();
        }

        public string Username { get; set; }

        public int PointLife { get; set; }

        public DuelDeck Deck { get; set; }

        public bool CanInvoke { get; set; }


        public dynamic[] MonstersField = new dynamic[5];

        public dynamic[] SpecialField = new dynamic[5];

        public void ResetAction()
        {
            CanInvoke = true;

            MonstersField.OfType<MonsterCard>().ToList().ForEach(x => x.ResetAction());
        }
    }
}
