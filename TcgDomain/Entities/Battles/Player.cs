using TcgDomain.Entities.Cards.Abstract;

namespace TcgDomain.Entities.Battles
{
    public class Player
    {
        public string Username { get; set; }

        public int PointLife { get; set; }

        public DuelDeck Deck { get; set; }


        public MonsterCard[] MonstersField = new MonsterCard[5];

        public Card[] SpecialField = new Card[5];
    }
}
