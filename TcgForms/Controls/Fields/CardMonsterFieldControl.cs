using System.ComponentModel;
using TcgDomain.Entities.Cards;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgForms.Forms;

namespace TcgForms.Controls.Fields
{
    public partial class CardMonsterFieldControl : CardControl
    {
        public MonsterCard MonsterCard { get => OriginalCard as MonsterCard; }

        public int Position { get; set; }

        public CardMonsterFieldControl()
        {
            InitializeComponent();
        }

        public CardMonsterFieldControl(NormalCard card, int position, bool set = false) : base(card, set)
        {
            InitializeComponent();

            Position = position;
            Card.Set = set;
        }

        public CardMonsterFieldControl(EffectCard card, int position, bool set = false) : base(card, set)
        {
            InitializeComponent();

            Position = position;
            Card.Set = set;
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
            menuItemChangePosition.Visible = !Card.Set && MonsterCard.CanChangePosition;
            
            menuItemAttack.Visible = MonsterCard.CanAttack && MonsterCard.DuelPosition == DuelPositionEnum.Atk;
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

        #endregion
    }
}
