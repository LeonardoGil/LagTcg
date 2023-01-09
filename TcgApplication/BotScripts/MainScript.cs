using TcgApplication.AppServices;
using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Entities.Scripts;

namespace TcgApplication.BotScripts
{
    public class MainScript : BasicScript
    {
        #region AppServices

        private readonly BattleAppServices BattleAppServices = new BattleAppServices();
        private readonly DrawAppServices DrawAppServices = new DrawAppServices();
        private readonly InvokeAppServices InvokeAppServices = new InvokeAppServices();
        private readonly PhaseAppServices PhaseAppServices = new PhaseAppServices();

        #endregion

        public override void On(InputData data)
        {
            switch (data.Phase)
            {
                case TcgDomain.Enums.PhaseEnum.DrawPhase:
                    DrawPhaseScript(data.Bot);
                    break;

                case TcgDomain.Enums.PhaseEnum.MainPhaseOne:
                    MainPhaseScript(data.Bot, data.Opponent);
                    break;

                case TcgDomain.Enums.PhaseEnum.BattlePhase:
                    BattlePhaseScript(data.Bot, data.Opponent);
                    break;

                case TcgDomain.Enums.PhaseEnum.MainPhaseTwo:
                    break;
            }
        }

        protected override void BattlePhaseScript(Player bot, Player opponent)
        {
            var monsterField = bot.DuelField.MonstersField.All.Where(x => x is not null && x.CanAttack).ToList();
            var opponentField = opponent.DuelField.MonstersField.All.Where(x => x is not null).ToList();

            foreach (var monster in monsterField)
            {
                if (opponentField.Any())
                {
                    var monsterOpponent = opponentField.FirstOrDefault(x =>
                                                (x.DuelPosition == TcgDomain.Enums.DuelPositionEnum.Atk && monster.Attack > x.Attack) ||
                                                (x.DuelPosition == TcgDomain.Enums.DuelPositionEnum.Def && monster.Attack > x.Defense));

                    if (monsterOpponent is not null)
                    {
                        BattleAppServices.Battle(bot, opponent, monster, monsterOpponent);
                    }
                }
                else
                {
                    BattleAppServices.Battle(bot, opponent, monster, null);
                }
            }
        }

        protected override void DrawPhaseScript(Player bot)
        {
            DrawAppServices.DrawCards(bot, 1);
        }

        protected override void MainPhaseScript(Player bot, Player opponent)
        {
            if (bot.CanInvoke && bot.Cards.Any())
            {
                var monsterField = bot.DuelField.MonstersField.All.Where(x => x is not null).ToList();

                if (monsterField.Any())
                {

                }
                else
                {
                    var monsterCard = bot.Cards.OfType<MonsterCard>()
                                               .ToList()
                                               .Where(x => x.RangeMonsterLevel == TcgDomain.Enums.RangeMonsterLevelEnum.OneToFour)
                                               .OrderByDescending(x => x.Attack)
                                               .FirstOrDefault();

                    InvokeAppServices.Invoke(bot, monsterCard);
                }
            }
        }

        protected override void MainPhaseTwoScript(Player bot, Player opponent)
        {
            throw new NotImplementedException();
        }
    }
}
