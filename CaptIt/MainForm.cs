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

        }
    }
}
