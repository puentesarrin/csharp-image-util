using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CSharpImageUtil
{
    public class Saving
    {
        public static void Save(Bitmap imageBitmap, string fullImagePath, ImageFormat format)
        {
            if (File.Exists(fullImagePath))
                File.Delete(fullImagePath);
            imageBitmap.Save(fullImagePath, format);
        }
        public static void SaveAsBmp(Bitmap imageBitmap, string fullImagePath)
        {
            Save(imageBitmap, fullImagePath, ImageFormat.Bmp);
        }
        public static void SaveAsEmf(Bitmap imageBitmap, string fullImagePath)
        {
            Save(imageBitmap, fullImagePath, ImageFormat.Emf);
        }
        public static void SaveAsGif(Bitmap imageBitmap, string fullImagePath)
        {
            Save(imageBitmap, fullImagePath, ImageFormat.Gif);
        }
        public static void SaveAsIcon(Bitmap imageBitmap, string fullImagePath)
        {
            Save(imageBitmap, fullImagePath, ImageFormat.Icon);
        }
        public static void SaveAsJpeg(Bitmap imageBitmap, string fullImagePath)
        {
            Save(imageBitmap, fullImagePath, ImageFormat.Jpeg);
        }
        public static void SaveAsPng(Bitmap imageBitmap, string fullImagePath)
        {
            Save(imageBitmap, fullImagePath, ImageFormat.Png);
        }
        public static void SaveAsTiff(Bitmap imageBitmap, string fullImagePath)
        {
            Save(imageBitmap, fullImagePath, ImageFormat.Tiff);
        }

        public static void Save(Bitmap imageBitmap, string imagePath, string filename, ImageFormat format)
        {
            Save(imageBitmap, Path.Combine(imagePath, filename), format);
        }
        public static void SaveAsBmp(Bitmap imageBitmap, string imagePath, string filename)
        {
            SaveAsBmp(imageBitmap, Path.Combine(imagePath, filename));
        }
        public static void SaveAsEmf(Bitmap imageBitmap, string imagePath, string filename)
        {
            SaveAsEmf(imageBitmap, Path.Combine(imagePath, filename));
        }
        public static void SaveAsGif(Bitmap imageBitmap, string imagePath, string filename)
        {
            SaveAsGif(imageBitmap, Path.Combine(imagePath, filename));
        }
        public static void SaveAsIcon(Bitmap imageBitmap, string imagePath, string filename)
        {
            SaveAsIcon(imageBitmap, Path.Combine(imagePath, filename));
        }
        public static void SaveAsJpeg(Bitmap imageBitmap, string imagePath, string filename)
        {
            SaveAsJpeg(imageBitmap, Path.Combine(imagePath, filename));
        }
        public static void SaveAsPng(Bitmap imageBitmap, string imagePath, string filename)
        {
            SaveAsPng(imageBitmap, Path.Combine(imagePath, filename));
        }
        public static void SaveAsTiff(Bitmap imageBitmap, string imagePath, string filename)
        {
            SaveAsTiff(imageBitmap, Path.Combine(imagePath, filename));
        }

        public static void Save(Stream imageStream, string fullImagePath, ImageFormat format)
        {
            using (Bitmap ImageBitmap = new Bitmap(imageStream))
            {
                Save(ImageBitmap, fullImagePath, format);
            }
        }
        public static void SaveAsBmp(Stream imageStream, string fullImagePath)
        {
            Save(imageStream, fullImagePath, ImageFormat.Bmp);
        }
        public static void SaveAsEmf(Stream imageStream, string fullImagePath)
        {
            Save(imageStream, fullImagePath, ImageFormat.Emf);
        }
        public static void SaveAsGif(Stream imageStream, string fullImagePath)
        {
            Save(imageStream, fullImagePath, ImageFormat.Gif);
        }
        public static void SaveAsIcon(Stream imageStream, string fullImagePath)
        {
            Save(imageStream, fullImagePath, ImageFormat.Icon);
        }
        public static void SaveAsJpeg(Stream imageStream, string fullImagePath)
        {
            Save(imageStream, fullImagePath, ImageFormat.Jpeg);
        }
        public static void SaveAsPng(Stream imageStream, string fullImagePath)
        {
            Save(imageStream, fullImagePath, ImageFormat.Png);
        }
        public static void SaveAsTiff(Stream imageStream, string fullImagePath)
        {
            Save(imageStream, fullImagePath, ImageFormat.Tiff);
        }

        public static void Save(Stream imageStream, string imagePath, string filename, ImageFormat format)
        {
            Save(imageStream, Path.Combine(imagePath, filename), format);
        }
        public static void SaveAsBmp(Stream imageStream, string imagePath, string filename)
        {
            SaveAsBmp(imageStream, Path.Combine(imagePath, filename));
        }
        public static void SaveAsEmf(Stream imageStream, string imagePath, string filename)
        {
            SaveAsEmf(imageStream, Path.Combine(imagePath, filename));
        }
        public static void SaveAsGif(Stream imageStream, string imagePath, string filename)
        {
            SaveAsGif(imageStream, Path.Combine(imagePath, filename));
        }
        public static void SaveAsIcon(Stream imageStream, string imagePath, string filename)
        {
            SaveAsIcon(imageStream, Path.Combine(imagePath, filename));
        }
        public static void SaveAsJpeg(Stream imageStream, string imagePath, string filename)
        {
            SaveAsJpeg(imageStream, Path.Combine(imagePath, filename));
        }
        public static void SaveAsPng(Stream imageStream, string imagePath, string filename)
        {
            SaveAsPng(imageStream, Path.Combine(imagePath, filename));
        }
        public static void SaveAsTiff(Stream imageStream, string imagePath, string filename)
        {
            SaveAsTiff(imageStream, Path.Combine(imagePath, filename));
        }

        public static void Save(Byte[] imageBytes, string fullImagePath, ImageFormat format)
        {
            using (Stream ImageStream = new MemoryStream(imageBytes))
            {
                Save(ImageStream, fullImagePath, fullImagePath, format);
            }
        }
        public static void SaveAsBmp(Byte[] imageBytes, string fullImagePath)
        {
            Save(imageBytes, fullImagePath, ImageFormat.Bmp);
        }
        public static void SaveAsEmf(Byte[] imageBytes, string fullImagePath)
        {
            Save(imageBytes, fullImagePath, ImageFormat.Emf);
        }
        public static void SaveAsGif(Byte[] imageBytes, string fullImagePath)
        {
            Save(imageBytes, fullImagePath, ImageFormat.Gif);
        }
        public static void SaveAsIcon(Byte[] imageBytes, string fullImagePath)
        {
            Save(imageBytes, fullImagePath, ImageFormat.Icon);
        }
        public static void SaveAsJpeg(Byte[] imageBytes, string fullImagePath)
        {
            Save(imageBytes, fullImagePath, ImageFormat.Jpeg);
        }
        public static void SaveAsPng(Byte[] imageBytes, string fullImagePath)
        {
            Save(imageBytes, fullImagePath, ImageFormat.Png);
        }
        public static void SaveAsTiff(Byte[] imageBytes, string fullImagePath)
        {
            Save(imageBytes, fullImagePath, ImageFormat.Tiff);
        }

        public static void Save(Byte[] imageBytes, string imagePath, string filename, ImageFormat format)
        {
            Save(imageBytes, Path.Combine(imagePath, filename), format);
        }
        public static void SaveAsBmp(Byte[] imageBytes, string imagePath, string filename)
        {
            SaveAsBmp(imageBytes, Path.Combine(imagePath, filename));
        }
        public static void SaveAsEmf(Byte[] imageBytes, string imagePath, string filename)
        {
            SaveAsEmf(imageBytes, Path.Combine(imagePath, filename));
        }
        public static void SaveAsGif(Byte[] imageBytes, string imagePath, string filename)
        {
            SaveAsGif(imageBytes, Path.Combine(imagePath, filename));
        }
        public static void SaveAsIcon(Byte[] imageBytes, string imagePath, string filename)
        {
            SaveAsIcon(imageBytes, Path.Combine(imagePath, filename));
        }
        public static void SaveAsJpeg(Byte[] imageBytes, string imagePath, string filename)
        {
            SaveAsJpeg(imageBytes, Path.Combine(imagePath, filename));
        }
        public static void SaveAsPng(Byte[] imageBytes, string imagePath, string filename)
        {
            SaveAsPng(imageBytes, Path.Combine(imagePath, filename));
        }
        public static void SaveAsTiff(Byte[] imageBytes, string imagePath, string filename)
        {
            SaveAsTiff(imageBytes, Path.Combine(imagePath, filename));
        }
    }
}
