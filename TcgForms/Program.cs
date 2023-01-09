using TcgDomain.Entities.Battles;
using TcgForms.Forms;
using TcgMock;
using TcgMock.Decks;

namespace TcgForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var cards = MockService.LoadInitialCards();

            var player = new Player(YugiMutoDeck.Get(cards))
            {
                Username = "Leonardo",
            };

            var opponent = new Bot(YugiMutoDeck.Get(cards))
            {
                Username = "Machine",
            };

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new DuelFieldForm(player, opponent));
        }
    }
}