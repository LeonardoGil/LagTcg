using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Cards.Abstract;
using TcgDomain.Enums;
using TcgInfra.CustomExceptions;
using TcgInfra.CustomMessages;

namespace TcgApplication.AppServices
{
    public class InvokeAppServices
    {
        private readonly int[] _Position = { 2, 1, 3, 0, 4 };
        private readonly int[] _SortPosition = { 0, 1, 2, 3, 4 };

        public void Invoke(Player player, dynamic card)
        {
            foreach (var position in _Position)
            {
                var monster = player.DuelField.MonstersField[position];

                if (monster is not null)
                    continue;

                player.DuelField.MonstersField[position] = card;
                player.CanInvoke = false;
                return;
            }

            throw new BusinessException("Não há posição disponivel em campo");
        }

        public void SacrificeForInvoke(Player player, List<Card> sacrifice, dynamic card)
        {
            foreach (var position in _SortPosition)
            {
                var monster = player.DuelField.MonstersField[position];

                if (monster is null)
                    continue;

                var monsterCard = monster as Card;

                if (sacrifice.Contains(monsterCard))
                {
                    player.DuelField.Graveyard.Add(player.DuelField.MonstersField[position]);
                    player.DuelField.MonstersField[position] = null;
                }
            }

            Invoke(player, card);
        }
        
        public List<Card> SelectCardsForAttribute(List<Card> cardsAvailable, int quantity)
        {
            var dialog = string.Format(DialogMessage.InvokeAttribute, quantity);

            //ADD evento

            //if (MessageBox.Show(dialog, "Invoke", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    var message = $"Selecione {quantity} carta(s)";

            //    using (var selectCardForm = new SelectCardForm(cardsAvailable, message, quantity))
            //    {
            //        selectCardForm.ShowDialog();
            //        if (selectCardForm.DialogResult == DialogResult.OK)
            //        {
            //            return selectCardForm.CardsSelected;
            //        }
            //    }
            //}

            return new List<Card>();
        }

        public bool CanInvokeMonster(MonsterCard card, Player player)
        {
            if (!player.CanInvoke)
                return false;

            switch (card.RangeMonsterLevel)
            {
                case TcgDomain.Enums.RangeMonsterLevelEnum.OneToFour:
                    return HasSpaceInField(player);

                case TcgDomain.Enums.RangeMonsterLevelEnum.FiveAndSix:
                    return CanInvokeMonsterForAttribute(player, 1);

                case TcgDomain.Enums.RangeMonsterLevelEnum.SevenOrMore:
                    return CanInvokeMonsterForAttribute(player, 2);

                default:
                    return false;
            }
        }

        public bool CanInvokeMonster(PhaseEnum phase, TypePlayerEnum phasePlayer)
        {
            return phasePlayer == TypePlayerEnum.Player && (phase == PhaseEnum.MainPhaseOne || phase == PhaseEnum.MainPhaseTwo);
        }

        public bool CanInvokeMonsterForAttribute(Player player, int attributes)
        {
            return player.DuelField.MonstersField.All.Count(x => x is not null) >= attributes;
        }

        public bool HasSpaceInField(Player player)
        {
            return player.DuelField.MonstersField.All.Any(x => x is null);
        }
    }
}
