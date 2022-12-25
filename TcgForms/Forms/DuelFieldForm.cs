using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgForms.AppServices;
using TcgForms.Controls.Fields;
using TcgForms.Controls.Hands;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services

        private readonly DrawAppServices DrawAppServices = new DrawAppServices();

        private readonly InvokeAppServices InvokeAppServices = new InvokeAppServices();

        #endregion

        #region Property & Constructor

        public int Turn { get; private set; }

        public PhasePlayerEnum PhasePlayer { get; private set; }

        public PhaseEnum Phase { get; private set; }

        public Player Player { get; private set; }

        public Player Opponent { get; private set; }

        public DuelFieldForm(Player user, Player opponent)
        {
            InitializeComponent();

            Player = user;
            Opponent = opponent;

            PhasePlayer = PhasePlayerEnum.Player;
            Phase = PhaseEnum.DrawPhase;

            LoadInfo();

            Player.Deck.Shuffle();
            DrawCard(5);
        }

        #endregion

        #region Public Methods

        public void InvokePlayerMonster(CardMonsterHandControl cardHandControl)
        {
            RemoveCardFromHand(cardHandControl);

            var position = InvokeAppServices.Invoke(Player, cardHandControl.OriginalCard);

            var cardFieldControl = new CardMonsterFieldControl(cardHandControl.OriginalCard);

            AddCardOnField(cardFieldControl, position);
        }

        public void InvokePlayerMonsterAttribute(CardMonsterHandControl cardHandControl, int quantity)
        {
            var cardsInField = Player.MonstersField.OfType<Card>().ToList();

            var cardsForSacrifice = InvokeAppServices.SelectCardsForAttribute(cardsInField, quantity);

            if (!cardsForSacrifice.Any())
                return;

            InvokeAppServices.SacrificeForInvoke(Player, cardsForSacrifice, cardHandControl.OriginalCard);

            var cardsMonsterField = tableLayoutPlayerMain.Controls.OfType<dynamic>()
                                                                  .Where(x => x is CardMonsterFieldControl)
                                                                  .OfType<CardMonsterFieldControl>()
                                                                  .Where(x => !Player.MonstersField.OfType<Card>().Contains(x.Card))
                                                                  .ToList();

            cardsMonsterField.ForEach(RemoveCardOnField);

            InvokePlayerMonster(cardHandControl);
        }

        public void DrawCard(int quantity = 1)
        {
            var cards = DrawAppServices.DrawCards(Player, quantity);

            foreach (var card in cards)
            {
                var basicCard = (card as Card);

                if (basicCard.IsMonsterCard())
                {
                    var cardControl = new CardMonsterHandControl(card);

                    flowPanelHands.Controls.Add(cardControl);
                }

                if (basicCard.IsSpecialCard())
                {
                    throw new NotImplementedException();
                }

                flowPanelHands.SuspendLayout();

                flowPanelHands.ResumeLayout(false);
            }
        }

        public void NextPhase()
        {
            if (Phase == PhaseEnum.EndPhase)
                Phase = PhaseEnum.DrawPhase;
            else
                Phase = Phase + 1;

            LoadInfo();
        }

        public void RemoveCardFromHand(CardMonsterHandControl cardHandControl)
        {
            flowPanelHands.Controls.Remove(cardHandControl);

            flowPanelHands.SuspendLayout();

            flowPanelHands.ResumeLayout(false);
        }

        public void AddCardOnField(CardMonsterFieldControl cardFieldControl, int position)
        {
            tableLayoutPlayerMain.Controls.Add(cardFieldControl, position, 0);

            tableLayoutPlayerMain.SuspendLayout();

            tableLayoutPlayerMain.ResumeLayout(false);
        }

        public void RemoveCardOnField(CardMonsterFieldControl cardFieldControl)
        {
            tableLayoutPlayerMain.Controls.Remove(cardFieldControl);

            tableLayoutPlayerMain.SuspendLayout();

            tableLayoutPlayerMain.ResumeLayout(false);
        }

        #endregion

        #region Private Methods

        private void LoadInfo()
        {
            labelPlayerName.Text = Player.Username;
            labelPlayerPointLife.Text = Player.PointLife.ToString();

            labelPhase.Text = Phase.GetDescription();
            labelPhasePlayer.Text = PhasePlayer.ToString();
        }

        #endregion

        #region Events

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            DrawCard();
            NextPhase();
        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            NextPhase();
        }

        #endregion
    }
}