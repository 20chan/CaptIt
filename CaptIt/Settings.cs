using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace CaptIt
{
    [Serializable]
    public class Settings
    {
        #region GENERAL
        public bool IsStartUp { get; set; }
        public bool CheckForUpdate { get; set; }
        #endregion

        #region CAPTURE
        public bool IsCaptureSoundEffect { get; set; }
        public string CaptureSoundEffect { get; set; }
        public ClipboardType ClipboardType { get; set; }
        public Color DragCaptureBackGroundColor { get; set; }
        public double DragCaptureOpcaity { get; set; }
        #endregion;

        #region AUTOSAVE
        public bool IsSaveAuto { get; set; }
        public string AutoSavePath { get; set; }
        public string SaveFileNameFormat { get; set; } //수정할 때마다 올바른 포맷인지 검사를 할 필요 있음.
        public float SaveImageSize { get; set; }
        public ImageFormat ImageFormat { get; set; }
        #endregion

        #region KEYS
        public Keys FullScreenShotKey { get; set; }
        public Keys DragScreenShotKey { get; set; }
        public Keys WindowScreenShotKey { get; set; }
        #endregion

        public Settings()
        {

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
                IsStartUp = true,
                CheckForUpdate = true,

                DragCaptureBackGroundColor = Color.White,
                DragCaptureOpcaity = 0.5,
                IsCaptureSoundEffect = true,
                CaptureSoundEffect = "camera1",
                ClipboardType = ClipboardType.NONE,

                IsSaveAuto = true,
                AutoSavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                SaveFileNameFormat = "이미지 {c}.png",
                SaveImageSize = 1,
                ImageFormat = ImageFormat.Png,

                FullScreenShotKey = Keys.PrintScreen,
                DragScreenShotKey = Keys.PrintScreen | Keys.Shift,
                WindowScreenShotKey = Keys.PrintScreen | Keys.Control
            };
        }

        public static void SetStartup(bool enabled)
        {
            Microsoft.Win32.RegistryKey rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey
                        ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (enabled)
                rkey.SetValue("CaptIt", "\"" + Assembly.GetEntryAssembly().Location + "\"");
            else
                rkey.DeleteValue("CaptIt", false);

            rkey.Close();
        }
    }
}
