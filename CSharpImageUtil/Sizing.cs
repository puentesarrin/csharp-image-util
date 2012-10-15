using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CSharpImageUtil
{
    public class Sizing
    {
        public static void GetSize(Bitmap imageBitmap, out int width, out int height)
        {
            width = imageBitmap.Width;
            height = imageBitmap.Height;
        }
        public static void GetSize(Stream imageStream, out int width, out int height)
        {
            using (Bitmap ImageBitmap = new Bitmap(imageStream))
            {
                GetSize(ImageBitmap, out width, out height);
            }
        }
        public static void GetSize(Byte[] imageBytes, out int width, out int height)
        {
            using (Stream ImageStream = new MemoryStream(imageBytes))
            {
                GetSize(ImageStream, out width, out height);
            }
        }

        public static Size GetSize(Bitmap imageBitmap)
        {
            return new Size(imageBitmap.Width, imageBitmap.Height);
        }
        public static Size GetSize(Stream imageStream)
        {
            using (Bitmap ImageBitmap = new Bitmap(imageStream))
            {
                return GetSize(ImageBitmap);
            }
        }
        public static Size GetSize(Byte[] imageBytes)
        {
            using (Stream ImageStream = new MemoryStream(imageBytes))
            {
                return GetSize(ImageStream);
            }
        }

        public static void GetSize(Bitmap imageBitmap, out Size imageSize)
        {
            imageSize = GetSize(imageBitmap);
        }
        public static void GetSize(Stream imageStream, out Size imageSize)
        {
            imageSize = GetSize(imageStream);
        }
        public static void GetSize(Byte[] imageBytes, out Size imageSize)
        {
            imageSize = GetSize(imageBytes);
        }

        public static bool IsSquared(Bitmap imageBitmap)
        {
            return (imageBitmap.Width == imageBitmap.Height);
        }
        public static bool IsSquared(Stream imageStream)
        {
            using (Bitmap ImageBitmap = new Bitmap(imageStream))
            {
                return IsSquared(ImageBitmap);
            }
        }
        public static bool IsSquared(Byte[] imageBytes)
        {
            using (Stream ImageStream = new MemoryStream(imageBytes))
            {
                return IsSquared(ImageStream);
            }
        }

        public static void IsSquared(Bitmap imageBitmap, out bool result)
        {
            result = IsSquared(imageBitmap);
        }
        public static void IsSquared(Stream imageStream, out bool result)
        {
            result = IsSquared(imageStream);
        }
        public static void IsSquared(Byte[] imageBytes, out bool result)
        {
            result = IsSquared(imageBytes);
        }

        public static bool HasSize(Bitmap imageBitmap, int width, int height)
        {
            return (imageBitmap.Width == width && imageBitmap.Height == height);
        }
        public static bool HasSize(Stream imageStream, int width, int height)
        {
            using (Bitmap ImageBitmap = new Bitmap(imageStream))
            {
                return HasSize(ImageBitmap, width, height);
            }
        }
        public static bool HasSize(Byte[] imageBytes, int width, int height)
        {
            using (Stream ImageStream = new MemoryStream(imageBytes))
            {
                return HasSize(ImageStream, width, height);
            }
        }

        public static void HasSize(Bitmap imageBitmap, int width, int height, out bool result)
        {
            result = HasSize(imageBitmap, width, height);
        }
        public static void HasSize(Stream imageStream, int width, int height, out bool result)
        {
            result = HasSize(imageStream, width, height);
        }
        public static void HasSize(Byte[] imageBytes, int width, int height, out bool result)
        {
            result = HasSize(imageBytes, width, height);
        }
    }
}
