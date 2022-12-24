using System.Drawing;

namespace TcgDomain.Services
{
    public class DownloadServices
    {
        public static byte[] Image(string url)
        {
            var client = new HttpClient();
            var request = client.GetByteArrayAsync(url);

            request.Wait();

            return request.Result;
        }
    }
}
