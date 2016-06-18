using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaptIt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CaptureFullScreenShot()
        {
            Captured(ScreenShot.FullScreenShot());
        }

        private void CaptureDragScreenShot()
        {
            Captured(ScreenShot.DragScreenShot());
        }

        private void CaptureWindowScreenShot()
        {
            Captured(ScreenShot.WindowHandleScreenShot());
        }

        private void Captured(Image image)
        {
            GC.Collect();
            if (image == null) return;
            ImageSave.SaveImage(image, "D:\\img.png", System.Drawing.Imaging.ImageFormat.Png);
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
    }
}
