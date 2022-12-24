using TcgDomain.Services;

namespace TcgDomain.Entities.Cards.Abstract
{
    public abstract class Card
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        ///
        /// Image 
        ///

        public byte[] Image { get; set; }

        protected string urlImage;

        public string UrlImage 
        {
            get => urlImage; 
            set
            {
                urlImage = value;
                SetImage(value);
            }
        }

        protected async Task SetImage(string url)
        {
            try
            {
                var bytes = DownloadServices.Image(url);
                Image = bytes;
            }
            catch (Exception) { }
        }
    }
}
