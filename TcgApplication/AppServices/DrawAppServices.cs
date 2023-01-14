using TcgDomain.Entities.Battles;

namespace TcgApplication.AppServices
{
    public class DrawAppServices : BaseAppServices
    {
        public void DrawCards(Player player, int quantity)
        {
            for (var i = 0; i < quantity; i++)
                player.Deck.Draw();
        }
    }
}
