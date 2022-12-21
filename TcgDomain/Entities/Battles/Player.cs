namespace TcgDomain.Entities.Battles
{
    public class Player
    {
        public string Username { get; private set; }

        public uint PointLife { get; private set; }

        public BattleDeck Deck { get; set; }
    }
}
