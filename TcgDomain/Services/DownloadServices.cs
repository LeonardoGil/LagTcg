using System.Drawing;

namespace TcgDomain.Services
{
    public class DownloadServices
    {
        public static Task<byte[]> Image(string url)
        {
            var client = new HttpClient();
            var request = client.GetByteArrayAsync(url);

            return request;
        }
    }
}
