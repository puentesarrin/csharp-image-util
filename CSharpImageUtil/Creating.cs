using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CSharpImageUtil
{
    public class Creating
    {
        public static Bitmap CreateBitmap(int width, int height, Color fillColor)
        {
            Image Canvas = new Bitmap(width, height);
            using (Graphics Graphic = Graphics.FromImage(Canvas))
            {
                Graphic.Clear(fillColor);
            }
            return new Bitmap(Canvas);
        }
        public static Bitmap CreateBitmap(Size imageSize, Color fillColor)
        {
            return CreateBitmap(imageSize.Width, imageSize.Height, fillColor);
        }
        public static Bitmap CreateBitmap(Point imageSize, Color fillColor)
        {
            return CreateBitmap(imageSize.X, imageSize.Y, fillColor);
        }

        public static Image CreateImage(int width, int height, Color fillColor)
        {
            return (Image)CreateBitmap(width, height, fillColor);
        }
        public static Image CreateImage(Size imageSize, Color fillColor)
        {
            return CreateImage(imageSize.Width, imageSize.Height, fillColor);
        }
        public static Image CreateImage(Point imageSize, Color fillColor)
        {
            return CreateImage(imageSize.X, imageSize.Y, fillColor);
        }
    }
}
