using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;

namespace TcgForms.AppServices
{
    public class BattleAppService
    {
        public void Battle(Player playerAttack, Player playerDefense, MonsterCard monsterAttack, MonsterCard monsterDefense)
        {
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
                    playerDefense.MonstersField.RemoveCard(monsterDefense);
                    break;

                case BattleResultEnum.Defeat:
                    playerAttack.Damage(monsterDefense.Attack - monsterAttack.Attack);
                    playerAttack.MonstersField.RemoveCard(monsterAttack);
                    break;

                case BattleResultEnum.Tie:
                    playerAttack.MonstersField.RemoveCard(playerAttack);
                    playerDefense.MonstersField.RemoveCard(playerDefense);
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
                    playerDefense.MonstersField.RemoveCard(monsterDefense);
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
