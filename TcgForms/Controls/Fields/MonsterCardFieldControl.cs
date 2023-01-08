using System.ComponentModel;
using System.Windows.Forms;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgForms.AppServices;
using TcgForms.Forms;

namespace TcgForms.Controls.Fields
{
    public partial class MonsterCardFieldControl : CardControl
    {
        private readonly BattleAppService BattleAppService = new BattleAppService();

        public MonsterCard MonsterCard { get => OriginalCard as MonsterCard; }

        public int Position { get; set; }

        public MonsterCardFieldControl()
        {
            InitializeComponent();
        }

        public MonsterCardFieldControl(NormalCard card, int position, bool set = false) : base(card, set)
        {
            InitializeComponent();

            Position = position;
            Card.Set = set;

            if (Card.Set)
            {
                SetDefense();
            }
            else
            {
                SetAttack();
            }
        }

        public MonsterCardFieldControl(EffectCard card, int position, bool set = false) : base(card, set)
        {
            InitializeComponent();

            Position = position;
            Card.Set = set;

            if (Card.Set)
            {
                SetDefense();
            }
            else
            {
                SetAttack();
            }
        }

        #region Public Methods

        public void SetAttack()
        {
            if (MonsterCard.DuelPosition != DuelPositionEnum.Atk)
                BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

            ChangeSizeControl(SizeX, SizeY, 25, 10);

            MonsterCard.DuelPosition = DuelPositionEnum.Atk;
        }

        public void SetDefense()
        {
            if (MonsterCard.DuelPosition != DuelPositionEnum.Def)
                BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);

            ChangeSizeControl(SizeY, SizeX, 5, 30);

            MonsterCard.DuelPosition = DuelPositionEnum.Def;
        }

        #endregion

        #region Private Methods

        private void ChangeSizeControl(int sizeX, int sizeY, int positionX, int positionY)
        {
            Size = new Size(sizeX, sizeY);

            Anchor = AnchorStyles.None;
            Location = new Point(positionX + (150 * Position), positionY);
        }

        #endregion

        #region Events

        private void CardMonsterFieldControl_Paint(object sender, PaintEventArgs e)
        {
            ContextMenuStrip.Items.Add(GetMenuItemZoom());
        }

        private void contextMenuMonsterCard_Opening(object sender, CancelEventArgs e)
        {
            var duelFieldForm = ParentForm as DuelFieldForm;

            menuItemChangePosition.Visible = !Card.Set && MonsterCard.CanChangePosition;

            menuItemAttack.Visible = duelFieldForm.Turn > 1 && 
                                            MonsterCard.CanAttack && 
                                            MonsterCard.DuelPosition == DuelPositionEnum.Atk;
        }

        private void menuItemChangePosition_Click(object sender, EventArgs e)
        {
            switch (MonsterCard.DuelPosition)
            {
                case DuelPositionEnum.Atk:
                    SetDefense();
                    break;

                case DuelPositionEnum.Def:
                    SetAttack();
                    break;
            }

            MonsterCard.CanChangePosition = false;
        }

        private void menuItemAttack_Click(object sender, EventArgs e)
        {
            var duelFieldForm = ParentForm as DuelFieldForm;

            var monstersOpponent = duelFieldForm.Opponent.DuelField.MonstersField.All.OfType<Card>().ToList();

            if (monstersOpponent.Any())
            {
                using (var selectCardForm = new SelectCardForm(monstersOpponent, "Selecione uma Carta para atacar", 1))
                {
                    selectCardForm.ShowDialog();
                    if (selectCardForm.DialogResult == DialogResult.OK)
                    {
                        var monsterCardOpponent = selectCardForm.CardsSelected.First() as MonsterCard;

                        BattleAppService.Battle(duelFieldForm.Player, duelFieldForm.Opponent, MonsterCard, monsterCardOpponent);
                    }
                }
            }
            else
            {
                BattleAppService.Battle(duelFieldForm.Player, duelFieldForm.Opponent, MonsterCard, null);
            }
        }

        #endregion
    }
}
