using System.ComponentModel;
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
        #region Services & Forms

        private readonly DrawAppServices DrawAppServices = new DrawAppServices();

        private readonly InvokeAppServices InvokeAppServices = new InvokeAppServices();

        private readonly PhaseAppServices PhaseAppServices = new PhaseAppServices();

        private readonly BattleAppService BattleAppService = new BattleAppService();

        private readonly CardsHandForm PlayerCardsHandForm = new CardsHandForm();

        #endregion

        #region Property & Constructor

        public int Turn { get; private set; }

        public TypePlayerEnum PhasePlayer { get; private set; }

        public PhaseEnum Phase { get; private set; }

        public Player Player { get; private set; }

        public Player Opponent { get; private set; }

        public DuelFieldForm(Player user, Player opponent)
        {
            BackgroundImage = Properties.Resources.BackgroundDigitalDuel;

            InitializeComponent();

            Player = user;
            Opponent = opponent;

            Player.Deck.DrawCard += new EventHandler(PlayerCardsHandForm.AddCard);

            PhasePlayer = TypePlayerEnum.Player;
            Phase = PhaseEnum.DrawPhase;

            PlayerCardsHandForm.DuelFieldForm = this;

            PlayerCardsHandForm.Show();

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

        public void Battle(MonsterCard playerMonster, MonsterCard opponentMonster)
        {
            BattleAppService.Battle(Player, Opponent, playerMonster, opponentMonster);

            RemoveCardsAfterBattle(Player, tableLayoutPlayerMain);

            LoadInfo();
        }

        public void InvokePlayerMonster(MonsterCardHandControl cardHandControl, bool set = false)
        {
            PlayerCardsHandForm.RemoveCardFromHand(cardHandControl);

            InvokeMonster(Player, cardHandControl.OriginalCard, set);
        }

        public void InvokePlayerMonsterAttribute(MonsterCardHandControl cardHandControl, int quantity, bool set = false)
        {
            var cardsInField = Player.MonstersField.OfType<Card>().ToList();

            var cardsForSacrifice = InvokeAppServices.SelectCardsForAttribute(cardsInField, quantity);

            if (!cardsForSacrifice.Any())
                return;

            PlayerCardsHandForm.RemoveCardFromHand(cardHandControl);

            InvokeMonsterAttribute(Player, cardHandControl, cardsForSacrifice, set);
        }

        public void DrawCardPlayer(int quantity = 1)
        {
            DrawAppServices.DrawCards(Player, quantity);
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

            buttonNextPhase.Enabled = Phase != PhaseEnum.DrawPhase || PhasePlayer == TypePlayerEnum.Opponent;
        }

        #endregion

        #region Private Methods

        private void RemoveCardsAfterBattle(Player player, TableLayoutPanel table)
        {
            for (int i = 0; i < player.MonstersField.Length; i++)
            {
                if (player.MonstersField[i] is null)
                {
                    var cardMonsterControl = GetCardMonsterOnField(table, i);
                    
                    if (cardMonsterControl is not null)
                    {
                        RemoveCardMonsterOnField(table, cardMonsterControl);
                    }
                }
            }
        }

        private void AddCardMonsterOnField(TableLayoutPanel table, MonsterCardFieldControl cardFieldControl, int position, bool set = false)
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

        private void RemoveCardMonsterOnField(TableLayoutPanel table, MonsterCardFieldControl cardFieldControl)
        {
            table.Controls.Remove(cardFieldControl);
        }

        private MonsterCardFieldControl GetCardMonsterOnField(TableLayoutPanel table, int position)
        {
            return table.Controls.OfType<MonsterCardFieldControl>().FirstOrDefault(x => x.Position == position);
        }

        private void InvokeMonster(Player player, dynamic originalCard, bool set = false)
        {
            var position = InvokeAppServices.Invoke(player, originalCard);

            var cardFieldControl = new MonsterCardFieldControl(originalCard, position, set);

            var table = player.Type == TypePlayerEnum.Player ? tableLayoutPlayerMain : tableLayoutOpponentMain;

            AddCardMonsterOnField(table, cardFieldControl, position, set);

            player.CanInvoke = false;
        }

        private void InvokeMonsterAttribute(Player player, MonsterCardHandControl cardHandControl, List<Card> cardsForSacrifice, bool set = false)
        {
            InvokeAppServices.SacrificeForInvoke(player, cardsForSacrifice, cardHandControl.OriginalCard);

            var tableMain = player.Type == TypePlayerEnum.Player ? tableLayoutPlayerMain : tableLayoutOpponentMain;

            var cardsMonsterField = tableMain.Controls.OfType<MonsterCardFieldControl>()
                                                                  .Where(x => !player.MonstersField.OfType<Card>().Contains(x.Card))
                                                                  .ToList();

            cardsMonsterField.ForEach(card => RemoveCardMonsterOnField(tableMain, card));

            CheckGraveyardControl(player);

            InvokeMonster(player, cardHandControl.OriginalCard, set);
        }

        private void LoadInfo()
        {
            labelPlayerName.Text = Player.Username;
            labelOpponentName.Text = Opponent.Username;
            labelPlayerPointLife.Text = Player.PointLife.ToString();
            labelOpponentPointLife.Text = Opponent.PointLife.ToString();

            labelPhase.Text = Phase.GetDescription();
            labelPhasePlayer.Text = PhasePlayer.ToString();
            labelTurn.Text = string.Concat("Turn: ", Turn);
        }

        private void CheckGraveyardControl(Player player)
        {
            if (player.Graveyard.Any())
            {
                var control = player.Type == TypePlayerEnum.Player ? GraveyardPlayerControl : null;

                if (!control.Visible)
                {
                    GraveyardPlayerControl.Visible = true;
                    GraveyardPlayerControl.Enabled = true;

                    SuspendLayout();
                    ResumeLayout(false);
                }
            }
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
            PlayerCardsHandForm.Show();
            PlayerCardsHandForm.Activate();
        }

        #endregion
    }
}