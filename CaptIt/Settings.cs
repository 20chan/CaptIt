using System;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace CaptIt
{
    [Serializable]
    public class Settings
    {
        public bool isSaveAuto { get; set; }
        public string AutoSavePath { get; set; }
        public ImageFormat ImageFormat { get; set; }

        public Settings()
        {

        }

        public void SetStartup(bool enabled)
        {
            Microsoft.Win32.RegistryKey rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey
                        ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (enabled)
                rkey.SetValue("CaptIt", System.Windows.Forms.Application.ExecutablePath.ToString());
            else
                rkey.DeleteValue("CaptIt", false);
        }

        public void Save(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
            }
        }

        public static Settings Load(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (Settings)bf.Deserialize(fs);
            }
        }

        public static Settings Default()
        {
            return new Settings()
            {
                isSaveAuto = true,
                AutoSavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                ImageFormat = ImageFormat.Png
            };
        }
    }
}
