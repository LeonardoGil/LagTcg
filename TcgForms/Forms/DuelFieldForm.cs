using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgForms.AppServices;
using TcgForms.Controls.Fields;
using TcgForms.Controls.Hands;
using TcgForms.Controls.Stacks;

namespace TcgForms.Forms
{
    public partial class DuelFieldForm : Form
    {
        #region Services & Forms

        private readonly DrawAppServices DrawAppServices = new DrawAppServices();

        private readonly InvokeAppServices InvokeAppServices = new InvokeAppServices();

        private readonly PhaseAppServices PhaseAppServices = new PhaseAppServices();

        private readonly CardsHandForm PlayerCardsHandForm = new CardsHandForm();

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

            Player.Deck.Shuffle();
            DrawCardPlayer(5);

            Turn++;

            LoadInfo();
        }

        #endregion

        #region Public Methods

        public void RefreshPlayerTableMonster()
        {
            tableLayoutPlayerMain.SuspendLayout();

            tableLayoutPlayerMain.ResumeLayout(false);
        }

        public void InvokePlayerMonster(CardMonsterHandControl cardHandControl, bool set = false)
        {
            PlayerCardsHandForm.RemoveCard(cardHandControl);
            PlayerCardsHandForm.RemoveCardFromHand(cardHandControl);

            InvokeMonster(Player, cardHandControl.OriginalCard, false, set);
        }

        public void InvokePlayerMonsterAttribute(CardMonsterHandControl cardHandControl, int quantity, bool set = false)
        {
            var cardsInField = Player.MonstersField.OfType<Card>().ToList();

            var cardsForSacrifice = InvokeAppServices.SelectCardsForAttribute(cardsInField, quantity);

            if (!cardsForSacrifice.Any())
                return;

            PlayerCardsHandForm.RemoveCard(cardHandControl);
            PlayerCardsHandForm.RemoveCardFromHand(cardHandControl);

            InvokeMonsterAttribute(Player, cardHandControl, cardsForSacrifice, false, set);
        }

        public void DrawCardPlayer(int quantity = 1)
        {
            var cards = DrawAppServices.DrawCards(Player, quantity);

            foreach (var card in cards)
            {
                var basicCard = (card as Card);

                if (basicCard.IsMonsterCard())
                {
                    var cardControl = new CardMonsterHandControl(card);
                    PlayerCardsHandForm.AddCard(cardControl);
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

            buttonNextPhase.Enabled = Phase != PhaseEnum.DrawPhase || PhasePlayer == PhasePlayerEnum.Opponent;
        }

        #endregion

        #region Private Methods

        private void AddCardMonsterOnField(TableLayoutPanel table, CardMonsterFieldControl cardFieldControl, int position, bool set = false)
        {
            table.Controls.Add(cardFieldControl, position, 0);

            if (set)
            {
                cardFieldControl.SetDefense();
            }
            else
            {
                cardFieldControl.SetAttack();
            }
        }

        private void RemoveCardMonsterOnField(TableLayoutPanel table, CardMonsterFieldControl cardFieldControl)
        {
            table.Controls.Remove(cardFieldControl);
        }

        private void InvokeMonster(Player player, dynamic originalCard, bool opponent = false, bool set = false)
        {
            var position = InvokeAppServices.Invoke(player, originalCard);

            var cardFieldControl = new CardMonsterFieldControl(originalCard, position, set);

            var table = opponent ? tableLayoutOpponentMain : tableLayoutPlayerMain;

            AddCardMonsterOnField(table, cardFieldControl, position, set);

            player.CanInvoke = false;
        }

        private void InvokeMonsterAttribute(Player player, CardMonsterHandControl cardHandControl, List<Card> cardsForSacrifice, bool opponent = false, bool set = false)
        {
            InvokeAppServices.SacrificeForInvoke(player, cardsForSacrifice, cardHandControl.OriginalCard);

            var table = opponent ? tableLayoutOpponentMain : tableLayoutPlayerMain;

            var cardsMonsterField = table.Controls.OfType<CardMonsterFieldControl>()
                                                                  .Where(x => !player.MonstersField.OfType<Card>().Contains(x.Card))
                                                                  .ToList();

            cardsMonsterField.ForEach(card => RemoveCardMonsterOnField(table, card));

            InvokeMonster(player, cardHandControl.OriginalCard, opponent, set);
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

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            NextPhase();
        }

        private void buttonMyCards_Click(object sender, EventArgs e)
        {
            PlayerCardsHandForm.DuelFieldForm = this;
            PlayerCardsHandForm.ShowDialog();
        }

        #endregion
    }
}