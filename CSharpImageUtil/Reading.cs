using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CSharpImageUtil
{
    public class Reading
    {
        public static Bitmap ReadBitmap(Byte[] imageBytes)
        {
            using (Stream imageStream = new MemoryStream(imageBytes))
            {
                return new Bitmap(imageStream);
            }
        }
        public static Bitmap ReadBitmap(string fullImagePath)
        {
            return ReadBitmap(File.ReadAllBytes(fullImagePath));
        }
        public static Bitmap ReadBitmap(string imagePath, string filename)
        {
            return ReadBitmap(Path.Combine(imagePath, filename));
        }

        public static Image ReadImage(Byte[] imageBytes)
        {
            using (Stream imageStream = new MemoryStream(imageBytes))
            {
                return Bitmap.FromStream(imageStream);
            }
        }
        public static Image ReadImage(string fullImagePath)
        {
            return ReadImage(File.ReadAllBytes(fullImagePath));
        }
        public static Image ReadImage(string imagePath, string filename)
        {
            return ReadImage(Path.Combine(imagePath, filename));
        }
    }
}
