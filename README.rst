CSharp Image Util
=================

This is a library with many methods for image operations -and save time & work- such as: Resizing with/without a background color, saving as JPEG, BMP, PNG and other supported formats by .NET framework.

A usage example:


>>> int width = 50, height = 30;
>>> string path = "/home/puentesarrin/avatar.jpeg";
>>> CSharpImageUtil.ResizingAndSaving.ResizeAndSaveAsJpeg(BytesOfImage, path, width, height);
