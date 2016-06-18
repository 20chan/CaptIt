using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace CaptIt
{
    public static class ImageSave
    {
        public static void SaveImage(Image img, string path, ImageFormat format)
        {
            img.Save(path, format);
        }
    }
}
