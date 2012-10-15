using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CSharpImageUtil
{
    public class Resizing
    {
        public static Bitmap Resize(Bitmap imageBitmap, int width, int height, Color backgroundColor)
        {
            Image Canvas = new Bitmap(width, height);
            using (Graphics Graphic = Graphics.FromImage(Canvas))
            {
                Graphic.InterpolationMode = InterpolationMode.HighQualityBilinear;
                Graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                Graphic.SmoothingMode = SmoothingMode.HighQuality;
                Graphic.CompositingQuality = CompositingQuality.HighQuality;
                Graphic.Clear(backgroundColor);
                int X = 0, Y = 0;
                float Percent = 0,
                    PercentWidth = (float)width / (float)imageBitmap.Width,
                    PercentHeight = (float)height / (float)imageBitmap.Height;
                if (PercentHeight < PercentWidth)
                {
                    Percent = PercentHeight;
                    X = Convert.ToInt16((width - (imageBitmap.Width * Percent)) / 2);
                }
                else
                {
                    Percent = PercentWidth;
                    Y = Convert.ToInt16((height - (imageBitmap.Height * Percent)) / 2);
                }
                int FinalWidth = (int)(imageBitmap.Width * Percent);
                int FinalHeight = (int)(imageBitmap.Height * Percent);
                Graphic.DrawImage(imageBitmap,
                    new Rectangle(X, Y, FinalWidth, FinalHeight),
                    new Rectangle(0, 0, imageBitmap.Width, imageBitmap.Height),
                    GraphicsUnit.Pixel);
            }
            return new Bitmap(Canvas);
        }
        public static Bitmap Resize(Bitmap imageBitmap, Size imageSize, Color backgroundColor)
        {
            return Resize(imageBitmap, imageSize.Width, imageSize.Height, backgroundColor);
        }
        public static Bitmap Resize(Bitmap imageBitmap, Point imageSize, Color backgroundColor)
        {
            return Resize(imageBitmap, imageSize.X, imageSize.Y, backgroundColor);
        }
        public static Bitmap Resize(Bitmap imageBitmap, int width, int height)
        {
            return Resize(imageBitmap, width, height, Color.White);
        }
        public static Bitmap Resize(Bitmap imageBitmap, Size imageSize)
        {
            return Resize(imageBitmap, imageSize.Width, imageSize.Height);
        }
        public static Bitmap Resize(Bitmap imageBitmap, Point imageSize)
        {
            return Resize(imageBitmap, imageSize.X, imageSize.Y);
        }

        public static Bitmap Resize(Stream imageStream, int width, int height, Color backgroundColor)
        {
            using (Bitmap ImageBitmap = new Bitmap(imageStream))
            {
                return Resize(ImageBitmap, width, height, backgroundColor);
            }
        }
        public static Bitmap Resize(Stream imageStream, Size imageSize, Color backgroundColor)
        {
            return Resize(imageStream, imageSize.Width, imageSize.Height, backgroundColor);
        }
        public static Bitmap Resize(Stream imageStream, Point imageSize, Color backgroundColor)
        {
            return Resize(imageStream, imageSize.X, imageSize.Y, backgroundColor);
        }
        public static Bitmap Resize(Stream imageStream, int width, int height)
        {
            return Resize(imageStream, width, height, Color.White);
        }
        public static Bitmap Resize(Stream imageStream, Size imageSize)
        {
            return Resize(imageStream, imageSize.Width, imageSize.Height);
        }
        public static Bitmap Resize(Stream imageStream, Point imageSize)
        {
            return Resize(imageStream, imageSize.X, imageSize.Y);
        }

        public static Bitmap Resize(Byte[] imageBytes, int width, int height, Color backgroundColor)
        {
            using (Stream ImageStream = new MemoryStream(imageBytes))
            {
                return Resize(ImageStream, width, height, backgroundColor);
            }
        }
        public static Bitmap Resize(Byte[] imageBytes, Size imageSize, Color backgroundColor)
        {
            return Resize(imageBytes, imageSize.Width, imageSize.Height, backgroundColor);
        }
        public static Bitmap Resize(Byte[] imageBytes, Point imageSize, Color backgroundColor)
        {
            return Resize(imageBytes, imageSize.X, imageSize.Y, backgroundColor);
        }
        public static Bitmap Resize(Byte[] imageBytes, int width, int height)
        {
            return Resize(imageBytes, width, height, Color.White);
        }
        public static Bitmap Resize(Byte[] imageBytes, Size imageSize)
        {
            return Resize(imageBytes, imageSize.Width, imageSize.Height);
        }
        public static Bitmap Resize(Byte[] imageBytes, Point imageSize)
        {
            return Resize(imageBytes, imageSize.X, imageSize.Y);
        }

        public static Bitmap ResizeByPercent(Bitmap imageBitmap, float percent)
        {
            Size ImageSize = Sizing.GetSize(imageBitmap);
            return Resize(imageBitmap, (int)(ImageSize.Width * 100 / percent), (int)(ImageSize.Height * 100 / percent));
        }
        public static Bitmap ResizeByPercent(Stream imageStream, float percent)
        {
            using (Bitmap ImageBitmap = new Bitmap(imageStream))
            {
                return ResizeByPercent(ImageBitmap, percent);
            }
        }
        public static Bitmap ResizeByPercent(Byte[] imageBytes, float percent)
        {
            using (Stream ImageStream = new MemoryStream(imageBytes))
            {
                return ResizeByPercent(ImageStream, percent);
            }
        }
    }
}
