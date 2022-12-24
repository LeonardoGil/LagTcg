namespace TcgDomain.Entities.Battles
{
    public class BattleField
    {
        public dynamic[] PlayerMonsterField = new dynamic[5];
        
        public dynamic[] OpponentMonsterField = new dynamic[5];

        public dynamic[] PlayerMagicTrapField = new dynamic[5];

        public dynamic[] OpponentMagicTrapField = new dynamic[5];

        public dynamic PlayerMagicField;

        public dynamic OpponentMagicField;
    }
}
