using TcgDomain.Entities.Cards.Abstract;
using TcgInfra.CustomEventArgs;

namespace TcgDomain.Entities.Battles
{
    public class CardsFieldCollection<CardType> where CardType : Card
    {
        public event EventHandler<InvokeEventArgs> Put;

        public event EventHandler<InvokeEventArgs> Remove;

        private CardType[] Cards;

        private int Size;

        public CardsFieldCollection(int size)
        {
            Size = size;
            Cards = new CardType[size];
        }

        public CardType this[int position]
        {
            get
            {
                if (position >= Size)
                    throw new Exception("Posição invalida");

                return Cards[position];
            }
            set
            {
                if (position >= Size)
                    throw new Exception("Posição invalida");

                Cards[position] = value;

                var card = Cards[position];

                var eventArgs = new InvokeEventArgs() 
                { 
                    Position = position, 
                    Set = value?.Set ?? false 
                };

                if (value is not null)
                {
                    Put?.Invoke(card, eventArgs);
                }
                else
                {
                    Remove?.Invoke(card, eventArgs);
                }
            }
        }

        public List<CardType> All
        {
            get => Cards.ToList();
            set => Cards = value.ToArray();
        }

        public void RemoveMonsterCard(MonsterCard monsterCard)
        {
            for (int i = 0; i < Cards.Length; i++)
            {
                if (this[i] == monsterCard)
                {
                    this[i] = null;
                }
            }
        }
    }
}
