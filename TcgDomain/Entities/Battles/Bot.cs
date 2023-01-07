namespace TcgDomain.Entities.Battles
{
    public class Bot : Player
    {
        public Bot() : base()
        {
            Type = Enums.TypePlayerEnum.Opponent;
        }
    }
}
