using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgForms.AppServices;
using TcgForms.Controls;
using TcgForms.Controls.Fields;
using TcgForms.Controls.Hands;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services & Forms

        private readonly DrawAppServices DrawAppServices = new DrawAppServices();

        private readonly InvokeAppServices InvokeAppServices = new InvokeAppServices();

        private readonly PhaseAppServices PhaseAppServices = new PhaseAppServices();

        private readonly CardsHandForm MyCardsForm = new CardsHandForm();

        #endregion

        #region Property & Constructor

        public int Turn { get; private set; }

        public PhasePlayerEnum PhasePlayer { get; private set; }

        public PhaseEnum Phase { get; private set; }

        public Player Player { get; private set; }

        public Player Opponent { get; private set; }

        public DuelFieldForm(Player user, Player opponent)
        {
            BackgroundImage = Properties.Resources.BackgroundDigitalDuel;

            InitializeComponent();

            Player = user;
            Opponent = opponent;

            PhasePlayer = PhasePlayerEnum.Player;
            Phase = PhaseEnum.DrawPhase;

            Turn++;

            LoadInfo();

            Player.Deck.Shuffle();
            DrawCard(5);
        }

        #endregion

        #region Public Methods

        public void InvokePlayerMonster(CardMonsterHandControl cardHandControl)
        {
            MyCardsForm.RemoveCard(cardHandControl);
            MyCardsForm.RemoveCardFromHand(cardHandControl);

            InvokeMonster(Player, cardHandControl.OriginalCard);
        }

        public void InvokePlayerMonsterAttribute(CardMonsterHandControl cardHandControl, int quantity)
        {
            var cardsInField = Player.MonstersField.OfType<Card>().ToList();

            var cardsForSacrifice = InvokeAppServices.SelectCardsForAttribute(cardsInField, quantity);

            if (!cardsForSacrifice.Any())
                return;

            InvokeMonsterAttribute(Player, cardHandControl, cardsForSacrifice);
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
                    MyCardsForm.AddCard(cardControl);
                }

                if (basicCard.IsSpecialCard())
                {
                    throw new NotImplementedException();
                }
            }
        }

        public void NextPhase()
        {
            if (Phase == PhaseEnum.EndPhase)
            {
                PhasePlayer = PhaseAppServices.NextPhasePlayer(PhasePlayer);

                Player.ResetAction();
                Opponent.ResetAction();
            }

            Phase = PhaseAppServices.NextPhase(Phase);

            LoadInfo();

            buttonDraw.Enabled = Phase == PhaseEnum.DrawPhase;
            buttonNextPhase.Enabled = Phase != PhaseEnum.DrawPhase;
        }

        #endregion

        #region Private Methods

        private void AddCardMonsterOnField(TableLayoutPanel table, CardMonsterFieldControl cardFieldControl, int position)
        {
            table.Controls.Add(cardFieldControl, position, 0);

            table.SuspendLayout();

            cardFieldControl.Anchor = AnchorStyles.None;
            cardFieldControl.Location = new Point(20 + (140 * position), 10);

            table.ResumeLayout(false);
        }

        private void RemoveCardMonsterOnField(TableLayoutPanel table, CardMonsterFieldControl cardFieldControl)
        {
            table.Controls.Remove(cardFieldControl);

            table.SuspendLayout();

            table.ResumeLayout(false);
        }

        private void InvokeMonster(Player player, dynamic originalCard, bool opponent = false)
        {
            var position = InvokeAppServices.Invoke(player, originalCard);

            var cardFieldControl = new CardMonsterFieldControl(originalCard);

            var table = opponent ? tableLayoutOpponentMain : tableLayoutPlayerMain;

            AddCardMonsterOnField(table, cardFieldControl, position);

            player.CanInvoke = false;
        }

        private void InvokeMonsterAttribute(Player player, CardMonsterHandControl cardHandControl, List<Card> cardsForSacrifice, bool opponent = false)
        {
            InvokeAppServices.SacrificeForInvoke(player, cardsForSacrifice, cardHandControl.OriginalCard);

            var table = opponent ? tableLayoutOpponentMain : tableLayoutPlayerMain;

            var cardsMonsterField = table.Controls.OfType<CardMonsterFieldControl>()
                                                                  .Where(x => !player.MonstersField.OfType<Card>().Contains(x.Card))
                                                                  .ToList();

            cardsMonsterField.ForEach(card => RemoveCardMonsterOnField(table, card));

            InvokeMonster(player, cardHandControl.OriginalCard, opponent);
        }

        private void LoadInfo()
        {
            labelPlayerName.Text = Player.Username;
            labelPlayerPointLife.Text = Player.PointLife.ToString();

            labelPhase.Text = Phase.GetDescription();
            labelPhasePlayer.Text = PhasePlayer.ToString();
            labelTurn.Text = string.Concat("Turn: ", Turn);
        }

        #endregion

        #region Events

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            DrawCard();
            NextPhase();
        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            NextPhase();
        }

        private void buttonMyCards_Click(object sender, EventArgs e)
        {
            MyCardsForm.DuelFieldForm = this;
            MyCardsForm.ShowDialog();
        }

        #endregion
    }
}