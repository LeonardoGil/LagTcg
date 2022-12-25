using Newtonsoft.Json;
using TcgDomain.Entities.Cards;
using TcgDomain.Enums;
using TcgDomain.Extensions;
using TcgMock.DTOs;

namespace TcgMock
{
    public class MockService
    {
        public static List<NormalCard> LoadInitialCards()
        {
            try
            {
                var file = File.ReadAllText("C:\\Projetos\\LagTcg\\TcgMock\\Cards\\InitialCards.json");

                var cardsDto = JsonConvert.DeserializeObject<List<CardDTO>>(file) ?? new List<CardDTO>();

                return cardsDto.Where(x => x.Type == TypeCardEnum.NormalMonster.GetDescription()).Select(dto => new NormalCard
                {
                    Serie = dto.Id,
                    Attack = dto.Atk,
                    Defense = dto.Def,
                    Level = dto.Level,
                    Description = dto.Description,
                    Name = dto.Name,
                    UrlImage = dto.Images?.FirstOrDefault()?.Url ?? string.Empty
                })
                .ToList();
            }
            catch (Exception e)
            {
                var message = e.Message;
                return new List<NormalCard>();
            }
        }
    }
}
