using TcgDomain.Entities.Decks;
using TcgDomain.Enums;
using TcgInfra.CustomExceptions;

namespace TcgDomain.Entities.Battles
{
    public class Player
    {
        public event EventHandler ChangePointLife;

        public event EventHandler Lose;

        public Player()
        {
            CanInvoke = true;

            PointLife = 8000;

            DuelField = new DuelField();
        }

        public string Username { get; set; }

        public int PointLife { get; private set; }

        public TypePlayerEnum Type { get; set; }

        public Deck Deck { get; set; }

        public DuelField DuelField { get; set; }

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
    }
}
