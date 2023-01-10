using TcgDomain.Enums;
using TcgInfra.CustomExceptions;
using TcgInfra.CustomMessages;

namespace TcgDomain.Entities.Cards.Abstract
{
    public abstract class MonsterCard : Card
    {
        public event EventHandler ChangeDuelPosition;

        public MonsterCard()
        {
            CanAttack = true;
        }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Level { get; set; }

        public bool CanAttack { get; set; }

        public bool CanChangePosition { get; set; }

        public AttributeEnum Attribute { get; set; }

        public MonsterTypeEnum Type { get; set; }

        public MonsterRangeLevelEnum RangeMonsterLevel
        {
            get
            {
                if (Level >= 1 && Level <= 4)
                    return MonsterRangeLevelEnum.OneToFour;

                if (Level == 5 || Level == 6)
                    return MonsterRangeLevelEnum.FiveAndSix;

                if (Level >= 7)
                    return MonsterRangeLevelEnum.SevenOrMore;

                throw new BusinessException(ErrorMessage.LevelMonsterCardInvalid);
            }
        }

        protected DuelPositionEnum _duelPosition;

        public DuelPositionEnum DuelPosition
        {
            get => _duelPosition;
            set
            {
                if (_duelPosition != value)
                {
                    _duelPosition = value;
                    ChangeDuelPosition?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public void ResetAction()
        {
            CanAttack = true;
            CanChangePosition = true;
        }
    }
}
