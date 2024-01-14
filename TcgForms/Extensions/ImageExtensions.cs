namespace TcgForms.Extensions
{
    public static class ImageExtensions
    {
        public static Image IntensifyColor(this Image image, int alpha, Color color)
        {
            using (Graphics graphic = Graphics.FromImage(image))
            using (Brush cloud_brush = new SolidBrush(Color.FromArgb(alpha, color)))
            {
                graphic.FillRectangle(cloud_brush, new Rectangle(0, 0, image.Width, image.Height));
            }

            return image;
        }
    }
}
