using TcgDomain.Entities.Decks;

namespace TcgDomain.Entities.Battles
{
    public class Bot : Player
    {
        public Bot(Deck deck) : base(deck)
        {
            Type = Enums.PlayerTypeEnum.Opponent;
        }
    }
}
