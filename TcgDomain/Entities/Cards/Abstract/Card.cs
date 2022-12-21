namespace TcgDomain.Entities.Cards.Abstract
{
    public abstract class Card
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
