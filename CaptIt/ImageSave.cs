using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace CaptIt
{
    public static class ImageSave
    {
        /// <summary>
        /// 이미지를 파일로 저장.
        /// </summary>
        /// <param name="img">저장할 이미지</param>
        /// <param name="directory">이미지가 저장될 경로. (디렉터리)</param>
        /// <param name="nameFormat">이미지 이름 (포맷)</param>
        /// <param name="format">이미지 저장 포맷</param>
        public static void SaveImage(Image img, string directory, string nameFormat, ImageFormat format)
        {
            string name = NameFormat(directory, nameFormat);
            img.Save(directory + name, format);
        }

        private static string NameFormat(string directory, string name)
        {
            string result = name;
            //날짜 및 시간
            result = result.Replace("{yyyy}", DateTime.Now.ToString("yyyy"));
            result = result.Replace("{MM}", DateTime.Now.ToString("MM"));
            result = result.Replace("{dd}", DateTime.Now.ToString("dd"));
            result = result.Replace("{tt}", DateTime.Now.ToString("tt"));
            result = result.Replace("{hh}", DateTime.Now.ToString("hh"));
            result = result.Replace("{HH}", DateTime.Now.ToString("HH"));
            result = result.Replace("{mm}", DateTime.Now.ToString("mm"));
            result = result.Replace("{ss}", DateTime.Now.ToString("ss"));

            if (result.Contains("{c}"))
            {
                string[] split = result.Split(new string[] { "{c}" }, StringSplitOptions.None);
                string head = split[0];
                string tail = split[1];
                int i = 1;
                for (; ; i++)
                {
                    if (!File.Exists(directory + head + i.ToString() + tail))
                    {
                        break;
                    }
                }

                result = head + i.ToString() + tail;
            }

            return result;
        }
    }
}