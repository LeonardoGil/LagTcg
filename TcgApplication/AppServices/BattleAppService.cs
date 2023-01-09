using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;

namespace TcgApplication.AppServices
{
    public class BattleAppService
    {
        public void Battle(Player playerAttack, Player playerDefense, MonsterCard monsterAttack, MonsterCard monsterDefense)
        {
            monsterAttack.CanAttack = false;

            if (monsterDefense is null)
            {
                playerDefense.Damage(monsterAttack.Attack);
                return;
            }

            switch (monsterDefense.DuelPosition)
            {
                case DuelPositionEnum.Atk:
                    BattlingAttackMonster(playerAttack, playerDefense, monsterAttack, monsterDefense);
                    break;
             
                case DuelPositionEnum.Def:
                    BattlingDefenseMonster(playerAttack, playerDefense, monsterAttack, monsterDefense);
                    break;
            }
        }

        private void BattlingAttackMonster(Player playerAttack, Player playerDefense, MonsterCard monsterAttack, MonsterCard monsterDefense)
        {
            switch (CalcBattle(monsterAttack.Attack, monsterDefense.Attack))
            {
                case BattleResultEnum.Win:
                    playerDefense.Damage(monsterAttack.Attack - monsterDefense.Attack);
                    playerDefense.DuelField.MonstersField.RemoveMonsterCard(monsterDefense);
                    break;

                case BattleResultEnum.Defeat:
                    playerAttack.Damage(monsterDefense.Attack - monsterAttack.Attack);
                    playerAttack.DuelField.MonstersField.RemoveMonsterCard(monsterAttack);
                    break;

                case BattleResultEnum.Tie:
                    playerAttack.DuelField.MonstersField.RemoveMonsterCard(monsterAttack);
                    playerDefense.DuelField.MonstersField.RemoveMonsterCard(monsterDefense);
                    break;

                default:
                    break;
            }
        }

        private void BattlingDefenseMonster(Player playerAttack, Player playerDefense, MonsterCard monsterAttack, MonsterCard monsterDefense)
        {
            switch (CalcBattle(monsterAttack.Attack, monsterDefense.Defense))
            {
                case BattleResultEnum.Win:
                    playerDefense.DuelField.MonstersField.RemoveMonsterCard(monsterDefense);
                    break;

                case BattleResultEnum.Defeat:
                    playerAttack.Damage(monsterDefense.Defense - monsterAttack.Attack);
                    break;

                case BattleResultEnum.Tie:
                    break;

                default:
                    break;
            }
        }

        private BattleResultEnum CalcBattle(int atk, int def)
        {
            if (atk == def)
                return BattleResultEnum.Tie;

            if (atk > def)
                return BattleResultEnum.Win;

            if (def > atk)
                return BattleResultEnum.Defeat;

            throw new NotImplementedException();
        }
    }
}
