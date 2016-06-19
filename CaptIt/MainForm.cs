using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaptIt
{
    public partial class MainForm : Form
    {
        public static MainForm Main;
        public Settings _settings;
        private HotKeyManager _hotkey;
        public MainForm()
        {
            InitializeComponent();
            Main = this;
            _settings = Settings.Default();
            _hotkey = new HotKeyManager();
        }

        public void CaptureFullScreenShot()
        {
            Captured(ScreenShot.FullScreenShot());
        }

        public void CaptureDragScreenShot()
        {
            Captured(ScreenShot.DragScreenShot());
        }

        public void CaptureWindowScreenShot()
        {
            Captured(ScreenShot.WindowHandleScreenShot());
        }

        private void Captured(Image image)
        {
            GC.Collect();
            if (image == null) return;

            (new System.Media.SoundPlayer(camsound.camera1)).Play();
            string format = "{yyyy}{MM}{dd}-{HH}{mm}{ss}.png";
            format = "Image {c}.png";
            ImageSave.SaveImage(image, "D:\\", format, System.Drawing.Imaging.ImageFormat.Png);
            //띠링~ 하는 사운드 실행
            //자동 저장
            //이미지 편집기를 띄움
            image.Dispose();
        }

        private void 전체화면FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureFullScreenShot();
        }

        private void 드래그영역DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureDragScreenShot();
        }

        private void 윈도우WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureWindowScreenShot();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SetStartup(checkBox1.Checked);
        }
    }
}
