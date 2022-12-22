using TcgDomain.Entities;
using TcgDomain.Entities.Cards;
using TcgDomain.Enums;

namespace TcgMock.Decks
{
    public static class BlueEyesDeck
    {
        public static Deck Get()
        {
            var deck = new Deck
            {
                Description = "Blue-Eyes White Dragon Deck"
            };

            deck.AddCard(BlueEyesWhiteDragonCard());
            deck.AddCard(BlueEyesWhiteDragonCard());
            deck.AddCard(BlueEyesWhiteDragonCard());

            deck.AddCard(HitotsuMeGiant());
            deck.AddCard(HitotsuMeGiant());
            deck.AddCard(HitotsuMeGiant());

            deck.AddCard(RyuKishin());
            deck.AddCard(RyuKishin());
            deck.AddCard(RyuKishin());

            return deck;
        }

        private static dynamic BlueEyesWhiteDragonCard()
        {
            return new NormalCard
            {
                Id = Guid.NewGuid(),
                Title = "Blue Eyes White Dragon",
                Description = "This legendary dragon is a powerful engine of destruction. Virtually invincible, very few have faced this awesome creature and lived to tell the tale.",
                Attack = 3000,
                Defense = 2500,
                Attribute = AttributeEnum.Light,
                Level = 8,
                Type = TypeMonsterEnum.Dragon
            };
        }

        private static dynamic HitotsuMeGiant()
        {
            return new NormalCard
            {
                Id = Guid.NewGuid(),
                Title = "Hitotsu-Me Giant",
                Description = "A one-eyed behemoth with thick, powerful arms made for delivering punishing blows.",
                Attack = 1200,
                Defense = 1000,
                Attribute = AttributeEnum.Earth,
                Level = 4,
                Type = TypeMonsterEnum.BeastWarrior
            };
        }

        private static dynamic RyuKishin()
        {
            return new NormalCard
            {
                Id = Guid.NewGuid(),
                Title = "Ryu-Kishin",
                Description = "A very elusive creature that looks like a harmless statue until it attacks.",
                Attack = 1000,
                Defense = 500,
                Attribute = AttributeEnum.Dark,
                Level = 3,
                Type = TypeMonsterEnum.Fiend
            };
        }
    }
}

/*
    private static dynamic BlueEyesWhiteDragonCard()
    {
        return new NormalCard
        {
            Id = Guid.NewGuid(),
            Title = "",
            Description = "",
            Attack = 3000,
            Defense = 2500,
            Attribute = AttributeEnum.Light,
            Level = 8,
            Type = TypeMonsterEnum.Dragon
        };
    }
*/