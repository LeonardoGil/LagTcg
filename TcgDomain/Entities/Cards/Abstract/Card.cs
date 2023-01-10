using TcgDomain.Enums;
using TcgDomain.Services;

namespace TcgDomain.Entities.Cards.Abstract
{
    public abstract class Card
    {
        public Guid Id { get; private set; }

        public Card()
        {
            Id = Guid.NewGuid();
        }

        public int Serie { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Set { get; set; }

        #region TypeCard

        public CardTypeEnum TypeCard { get; set; }

        public bool IsMonsterCard()
        {
            return TypeCard == CardTypeEnum.NormalMonster ||
                    TypeCard == CardTypeEnum.EffectMonster ||
                    TypeCard == CardTypeEnum.RitualMonster ||
                    TypeCard == CardTypeEnum.FusionMonster;
        }

        public bool IsSpecialCard()
        {
            return TypeCard == CardTypeEnum.SpellCard ||
                    TypeCard == CardTypeEnum.TrapCard;
        }

        #endregion

        #region Image

        public byte[] Image { get; set; }

        public string UrlImage { get; set; }

        public async Task SetImage()
        {
            try
            {
                if (string.IsNullOrEmpty(UrlImage) || string.IsNullOrWhiteSpace(UrlImage))
                    return;

                var bytes = DownloadServices.Image(UrlImage);
                Image = await bytes;
            }
            catch (Exception) { }
        }

        #endregion
    }
}
