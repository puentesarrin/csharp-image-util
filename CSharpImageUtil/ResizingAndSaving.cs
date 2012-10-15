using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CSharpImageUtil
{
    public class ResizingAndSaving
    {
        public static void ResizeAndSave(Stream imageStream, string fullImagePath, int width, int height, ImageFormat format)
        {
            using (Bitmap ImageBitmap = Resizing.Resize(imageStream, width, height))
            {
                Saving.Save(ImageBitmap, fullImagePath, format);
            }
        }
        public static void ResizeAndSaveAsBmp(Stream imageStream, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageStream, fullImagePath, width, height, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Stream imageStream, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageStream, fullImagePath, width, height, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Stream imageStream, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageStream, fullImagePath, width, height, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Stream imageStream, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageStream, fullImagePath, width, height, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Stream imageStream, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageStream, fullImagePath, width, height, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Stream imageStream, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageStream, fullImagePath, width, height, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Stream imageStream, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageStream, fullImagePath, width, height, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Stream imageStream, string imagePath, string filename, int width, int height, ImageFormat format)
        {
            ResizeAndSave(imageStream, Path.Combine(imagePath, filename), width, height, format);
        }
        public static void ResizeAndSaveAsBmp(Stream imageStream, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageStream, Path.Combine(imagePath, filename), width, height, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Stream imageStream, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageStream, Path.Combine(imagePath, filename), width, height, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Stream imageStream, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageStream, Path.Combine(imagePath, filename), width, height, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Stream imageStream, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageStream, Path.Combine(imagePath, filename), width, height, ImageFormat.Icon);
        }
        public static void ResizeAndSaveJpeg(Stream imageStream, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageStream, Path.Combine(imagePath, filename), width, height, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Stream imageStream, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageStream, Path.Combine(imagePath, filename), width, height, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Stream imageStream, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageStream, Path.Combine(imagePath, filename), width, height, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Stream imageStream, string fullImagePath, Size imageSize, ImageFormat format)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize.Width, imageSize.Height, format);
        }
        public static void ResizeAndSaveAsBmp(Stream imageStream, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Stream imageStream, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Stream imageStream, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Stream imageStream, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Stream imageStream, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Stream imageStream, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Stream imageStream, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Stream imageStream, string fullImagePath, Point imageSize, ImageFormat format)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize.X, imageSize.Y, format);
        }
        public static void ResizeAndSaveAsBmp(Stream imageStream, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Stream imageStream, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Stream imageStream, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Stream imageStream, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Stream imageStream, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Stream imageStream, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Stream imageStream, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageStream, fullImagePath, imageSize, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Byte[] imageBytes, string fullImagePath, int width, int height, ImageFormat format)
        {
            using (Stream ImageStream = new MemoryStream(imageBytes))
            {
                ResizeAndSave(ImageStream, fullImagePath, width, height, format);
            }
        }
        public static void ResizeAndSaveAsBmp(Byte[] imageBytes, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageBytes, fullImagePath, width, height, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Byte[] imageBytes, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageBytes, fullImagePath, width, height, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Byte[] imageBytes, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageBytes, fullImagePath, width, height, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Byte[] imageBytes, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageBytes, fullImagePath, width, height, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Byte[] imageBytes, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageBytes, fullImagePath, width, height, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Byte[] imageBytes, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageBytes, fullImagePath, width, height, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Byte[] imageBytes, string fullImagePath, int width, int height)
        {
            ResizeAndSave(imageBytes, fullImagePath, width, height, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Byte[] imageBytes, string imagePath, string filename, int width, int height, ImageFormat format)
        {
            ResizeAndSave(imageBytes, Path.Combine(imagePath, filename), width, height, format);
        }
        public static void ResizeAndSaveAsBmp(Byte[] imageBytes, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageBytes, imagePath, filename, width, height, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Byte[] imageBytes, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageBytes, imagePath, filename, width, height, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Byte[] imageBytes, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageBytes, imagePath, filename, width, height, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Byte[] imageBytes, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageBytes, imagePath, filename, width, height, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Byte[] imageBytes, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageBytes, imagePath, filename, width, height, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Byte[] imageBytes, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageBytes, imagePath, filename, width, height, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Byte[] imageBytes, string imagePath, string filename, int width, int height)
        {
            ResizeAndSave(imageBytes, imagePath, filename, width, height, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Byte[] imageBytes, string fullImagePath, Size imageSize, ImageFormat format)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize.Width, imageSize.Height, format);
        }
        public static void ResizeAndSaveAsBmp(Byte[] imageBytes, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Byte[] imageBytes, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Byte[] imageBytes, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Byte[] imageBytes, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Byte[] imageBytes, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Byte[] imageBytes, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Byte[] imageBytes, string fullImagePath, Size imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Byte[] imageBytes, string fullImagePath, Point imageSize, ImageFormat format)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize.X, imageSize.Y, format);
        }
        public static void ResizeAndSaveAsBmp(Byte[] imageBytes, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Byte[] imageBytes, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Byte[] imageBytes, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Byte[] imageBytes, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Byte[] imageBytes, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Byte[] imageBytes, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Byte[] imageBytes, string fullImagePath, Point imageSize)
        {
            ResizeAndSave(imageBytes, fullImagePath, imageSize, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Byte[] imageBytes, string imagePath, string filename, Size imageSize, ImageFormat format)
        {
            ResizeAndSave(imageBytes, Path.Combine(imagePath, filename), imageSize.Width, imageSize.Height, format);
        }
        public static void ResizeAndSaveAsBmp(Byte[] imageBytes, string imagePath, string filename, Size imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Byte[] imageBytes, string imagePath, string filename, Size imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Byte[] imageBytes, string imagePath, string filename, Size imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Byte[] imageBytes, string imagePath, string filename, Size imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Byte[] imageBytes, string imagePath, string filename, Size imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Byte[] imageBytes, string imagePath, string filename, Size imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Byte[] imageBytes, string imagePath, string filename, Size imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Tiff);
        }

        public static void ResizeAndSave(Byte[] imageBytes, string imagePath, string filename, Point imageSize, ImageFormat format)
        {
            ResizeAndSave(imageBytes, Path.Combine(imagePath, filename), imageSize.X, imageSize.Y, format);
        }
        public static void ResizeAndSaveAsBmp(Byte[] imageBytes, string imagePath, string filename, Point imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Bmp);
        }
        public static void ResizeAndSaveAsEmf(Byte[] imageBytes, string imagePath, string filename, Point imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Emf);
        }
        public static void ResizeAndSaveAsGif(Byte[] imageBytes, string imagePath, string filename, Point imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Gif);
        }
        public static void ResizeAndSaveAsIcon(Byte[] imageBytes, string imagePath, string filename, Point imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Icon);
        }
        public static void ResizeAndSaveAsJpeg(Byte[] imageBytes, string imagePath, string filename, Point imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Jpeg);
        }
        public static void ResizeAndSaveAsPng(Byte[] imageBytes, string imagePath, string filename, Point imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Png);
        }
        public static void ResizeAndSaveAsTiff(Byte[] imageBytes, string imagePath, string filename, Point imageSize)
        {
            ResizeAndSave(imageBytes, imagePath, filename, imageSize, ImageFormat.Tiff);
        }
    }
}
