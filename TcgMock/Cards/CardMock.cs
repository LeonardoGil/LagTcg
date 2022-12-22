namespace TcgMock.Cards
{
    public class CardMock
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }
        public string name_en { get; set; }
        public Card_Images[] card_images { get; set; }
    }

    public class Card_Images
    {
        public int id { get; set; }
        public string image_url { get; set; }
        public string image_url_small { get; set; }
    }
}
