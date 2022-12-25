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

        #region TypeCard

        public TypeCardEnum TypeCard { get; set; }

        public bool IsMonsterCard()
        {
            return TypeCard == TypeCardEnum.NormalMonster ||
                    TypeCard == TypeCardEnum.EffectMonster ||
                    TypeCard == TypeCardEnum.RitualMonster ||
                    TypeCard == TypeCardEnum.FusionMonster;
        }

        public bool IsSpecialCard()
        {
            return TypeCard == TypeCardEnum.SpellCard ||
                    TypeCard == TypeCardEnum.TrapCard;
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
