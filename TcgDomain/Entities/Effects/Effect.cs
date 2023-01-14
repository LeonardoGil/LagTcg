using TcgDomain.Entities.Battles;

namespace TcgDomain.Entities.Effects
{
    public abstract class Effect 
    {
        public abstract void Active(Player player, Player opponent, params object[] param);

        protected abstract void ValidateParams(object[] param);
    }
}
