using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace CaptIt
{
    public static class ImageSave
    {
        public static void SaveImage(Image img, string directory, string nameFormat, ImageFormat format)
        {
            string name = NameFormat(nameFormat);
            img.Save(directory + name, format);
        }

        private static string NameFormat(string name)
        {
            string result = name;
            result = result.Replace("{yyyy}", DateTime.Now.ToString("yyyy"));
            result = result.Replace("{MM}", DateTime.Now.ToString("MM"));
            result = result.Replace("{dd}", DateTime.Now.ToString("dd"));
            result = result.Replace("{tt}", DateTime.Now.ToString("tt"));
            result = result.Replace("{hh}", DateTime.Now.ToString("hh"));
            result = result.Replace("{HH}", DateTime.Now.ToString("HH"));
            result = result.Replace("{mm}", DateTime.Now.ToString("mm"));
            result = result.Replace("{ss}", DateTime.Now.ToString("ss"));
            return result;
        }
    }
}
