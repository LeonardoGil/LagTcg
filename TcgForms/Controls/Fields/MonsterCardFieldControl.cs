using System.ComponentModel;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgApplication.AppServices;
using TcgForms.Forms;

namespace TcgForms.Controls.Fields
{
    public partial class MonsterCardFieldControl : CardControl
    {
        private readonly BattleAppServices BattleAppService = new BattleAppServices();

        public MonsterCard MonsterCard { get => OriginalCard as MonsterCard; }

        public int Position { get; set; }

        public MonsterCardFieldControl()
        {
            InitializeComponent();
        }

        public MonsterCardFieldControl(NormalCard card, int position, bool set = false) : base(card, set)
        {
            InitializeComponent();
            DefaultConstructor(position, set);
        }

        public MonsterCardFieldControl(EffectCard card, int position, bool set = false) : base(card, set)
        {
            InitializeComponent();
            DefaultConstructor(position, set);
        }

        #region Public Methods

        public void SetAttack(bool initialize = false)
        {
            if (!initialize)
                BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

            ChangeSizeControl(SizeX, SizeY, 25, 10);
        }

        public void SetDefense()
        {
            BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);

            ChangeSizeControl(SizeY, SizeX, 5, 30);
        }

        #endregion

        #region Private Methods

        private void DefaultConstructor(int position, bool set)
        {
            ContextMenuStrip.Items.Add(GetMenuItemZoom());

            MonsterCard.ChangeDuelPosition += new EventHandler(MonsterCard_ChangeDuelPosition);

            Position = position;
            Card.Set = set;

            if (Card.Set)
            {
                SetDefense();
            }
            else
            {
                SetAttack(true);
            }
        }

        private void ChangeSizeControl(int sizeX, int sizeY, int positionX, int positionY)
        {
            Size = new Size(sizeX, sizeY);

            Anchor = AnchorStyles.None;
            Location = new Point(positionX + (150 * Position), positionY);
        }

        #endregion

        #region Events

        private void MonsterCard_ChangeDuelPosition(object sender, EventArgs e)
        {
            var card = sender as MonsterCard;
            
            switch (card.DuelPosition)
            {
                case DuelPositionEnum.Atk:
                    SetAttack();
                    break;

                case DuelPositionEnum.Def:
                    SetDefense();
                    break;
            }
        }

        private void contextMenuMonsterCard_Opening(object sender, CancelEventArgs e)
        {
            var duelFieldForm = ParentForm as DuelFieldForm;

            menuItemChangePosition.Visible = 
                duelFieldForm.PhasePlayer == PlayerTypeEnum.Player &&
                !Card.Set && 
                MonsterCard.CanChangePosition &&
                (duelFieldForm.Phase == PhaseEnum.MainPhaseOne || duelFieldForm.Phase == PhaseEnum.MainPhaseTwo);

            menuItemAttack.Visible = 
                duelFieldForm.Turn > 1 &&
                duelFieldForm.Phase == PhaseEnum.BattlePhase &&
                duelFieldForm.PhasePlayer == PlayerTypeEnum.Player &&
                MonsterCard.CanAttack &&
                MonsterCard.DuelPosition == DuelPositionEnum.Atk;
        }

        private void menuItemChangePosition_Click(object sender, EventArgs e)
        {
            switch (MonsterCard.DuelPosition)
            {
                case DuelPositionEnum.Atk:
                    MonsterCard.DuelPosition = DuelPositionEnum.Def;
                    break;

                case DuelPositionEnum.Def:
                    MonsterCard.DuelPosition = DuelPositionEnum.Atk;
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
