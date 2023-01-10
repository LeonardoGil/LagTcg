using TcgDomain.Entities.Decks;
using TcgDomain.Enums;
using TcgInfra.CustomExceptions;

namespace TcgDomain.Entities.Battles
{
    public class Player
    {
        public event EventHandler ChangePointLife;

        public event EventHandler Lose;

        public Player(Deck deck)
        {
            Cards = new List<dynamic>();

            CanInvoke = true;

            PointLife = 8000;

            DuelField = new DuelField();

            Deck = deck;
            Deck.DrawCard += new EventHandler(Cards_Add);
        }

        public string Username { get; set; }

        public int PointLife { get; private set; }

        public PlayerTypeEnum Type { get; protected set; }

        public List<dynamic> Cards { get; private set; }

        public Deck Deck { get; private set; }

        public DuelField DuelField { get; private set; }

        public bool CanInvoke { get; set; }

        public void ResetAction()
        {
            CanInvoke = true;

            DuelField.MonstersField.All.ForEach(x => x?.ResetAction());
        }

        public void Damage(int damage)
        {
            PointLife -= damage;

            ChangePointLife?.Invoke(this, EventArgs.Empty);

            if (PointLife <= 0)
                throw new FatalException("Perdeu");
        }

        private void Cards_Add(object sender, EventArgs e)
        {
            Cards.Add(sender);
        }
    }
}
