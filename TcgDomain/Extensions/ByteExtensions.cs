namespace TcgDomain.Extensions
{
    public static class ByteExtensions
    {
        public static Stream GetStream(this byte[] bytes)
        {
            return new MemoryStream(bytes);
        }
    }
}
