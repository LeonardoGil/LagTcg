using System.ComponentModel;

namespace TcgDomain.Extensions
{
    public static class EnumsExtensions
    {
        public static string? GetDescription<T>(this T value) where T : struct
        {
            var type = typeof(T);

            if (!type.IsEnum)
            {
                return null;
            }

            var fi = type.GetField(value.ToString());

            if (fi == null)
            {
                return string.Empty;
            }

            var attribute = Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute?.Description ?? value.ToString();
        }
    }
}
