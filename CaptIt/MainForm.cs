using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaptIt
{
    public partial class MainForm : Form
    {
        public static MainForm Main;
        public Settings _settings;
        private ShortCutManager _hotkey;

        private Image CamNormal;
        private Image CamBright;
        private Image CamDark;
        public MainForm()
        {
            InitializeComponent();
            Main = this;
            _settings = Settings.Default();
            _settings.AutoSavePath = "D:\\Captured\\";
            _hotkey = new ShortCutManager();

            this.CamNormal = Resources1.CamNormal;
            this.CamBright = Resources1.CamBright;
            this.CamDark = Resources1.CamDark;
            
            //this.MinimumSize = this.MaximumSize = this.Size;

            this.btnCamera.FlatAppearance.BorderColor =
                this.btnClose.FlatAppearance.BorderColor =
                this.btnMinimize.FlatAppearance.BorderColor =
                this.btnHouse.FlatAppearance.BorderColor =
                this.btnSetting.FlatAppearance.BorderColor =
                Color.FromArgb(0, 255, 255, 255);

            //HideBeforeShow();
        }

        private void HideBeforeShow()
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
        }

        private void CancelHiding()
        {
            this.Opacity = 1;
            this.ShowInTaskbar = true;
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

            (new System.Media.SoundPlayer(Resources1.camera1)).Play();
            
            ImageSave.SaveImage(image, _settings.AutoSavePath, _settings.SaveFileNameFormat, _settings.ImageFormat);
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

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 설정SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm(_settings);
            sf.Show();
        }
        
        Point old = new Point();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (old.X - e.X),
                    this.Top - (old.Y - e.Y));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = new Point(e.X, e.Y);
        }

        private void btnCamera_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnCamera.Image = CamBright;
        }

        private void btnCamera_MouseUp(object sender, MouseEventArgs e)
        {
            this.btnCamera.Image = CamDark;
        }

        private void btnCamera_MouseEnter(object sender, EventArgs e)
        {
            this.btnCamera.Image = CamDark;
        }

        private void btnCamera_MouseLeave(object sender, EventArgs e)
        {
            this.btnCamera.Image = CamNormal;
        }

        private void btnHouse_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = Resources1.house;
            bmp.MakeTransparent(Color.FromArgb(240, 113, 81));
            int x = (btnHouse.Width - bmp.Width) / 2;
            int y = (btnHouse.Height - bmp.Height) / 2;
            e.Graphics.DrawImage(bmp, x, y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            this.Hide();
            CaptureFullScreenShot();
            this.Show();
        }

        private void btnCamera_Enter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btnSetting_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = Resources1.Setting;
            bmp.MakeTransparent(Color.White);
            int x = (btnSetting.Width - bmp.Width) / 2;
            int y = (btnSetting.Height - bmp.Height) / 2;
            e.Graphics.DrawImage(bmp, x, y);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            설정SToolStripMenuItem_Click(null, null);
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.naver.com/phillyai");
        }
    }
}
