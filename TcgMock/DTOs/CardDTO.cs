using Newtonsoft.Json;

namespace TcgMock.DTOs
{
    public class CardDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        [JsonProperty("atk")]
        public int Atk { get; set; }
        
        [JsonProperty("def")]
        public int Def { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("name_en")]
        public string Name_en { get; set; }

        [JsonProperty("card_images")]
        public Card_Images[] Images { get; set; }
    }

    public class Card_Images
    {
        [JsonProperty("image_url")]
        public string Url { get; set; }

        [JsonProperty("image_url_small")]
        public string UrlSmall { get; set; }
    }
}
