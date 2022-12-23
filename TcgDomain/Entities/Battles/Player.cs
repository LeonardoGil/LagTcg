namespace TcgDomain.Entities.Battles
{
    public class Player
    {
        public string Username { get; set; }

        public uint PointLife { get; set; }

        public DuelDeck Deck { get; set; }
    }
}
