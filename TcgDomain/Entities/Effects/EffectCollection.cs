using TcgDomain.Entities.Battles;
using TcgDomain.Enums;

namespace TcgDomain.Entities.Effects
{
    public class EffectCollection
    {
        public bool Enable { get; set; }

        public List<ActiveEffectTypeEnum> ActiveEffectType { get; set; }

        private List<Func<Player, bool>> RequirementsPlayer { get; set; }
        
        private List<Func<Player, bool>> RequirementsOpponent { get; set; }

        public virtual bool CanActive(Player player, Player opponent)
        {
            foreach (var requirement in RequirementsPlayer)
            {
                if (!requirement.Invoke(player))
                    return false;
            }

            foreach (var requirement in RequirementsOpponent)
            {
                if (!requirement.Invoke(opponent))
                    return false;
            }    
            
            return true;
        }

        public virtual List<Effect> Effects { get; set; }
    }
}
