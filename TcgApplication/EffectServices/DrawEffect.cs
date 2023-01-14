using TcgApplication.AppServices;
using TcgDomain.Entities.Battles;
using TcgDomain.Entities.Effects;
using TcgInfra.CustomExceptions;

namespace TcgApplication.EffectServices
{
    public class DrawEffect : Effect
    {
        public override void Active(Player player, Player opponent, params object[] param)
        {
            ValidateParams(param);

            using (var draw = new DrawAppServices())
            {
                var quantity = (param[0] as int?).Value;

                draw.DrawCards(player, quantity);
            }
        }

        protected override void ValidateParams(object[] param)
        {
            if (param is null || param.Length != 1 || param[0] is not int)
                throw new BusinessException("Parametro invalido");
        }
    }
}
