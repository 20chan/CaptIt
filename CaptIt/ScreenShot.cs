using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Capture;

namespace CaptIt
{
    public static class ScreenShot
    {
        public static Image FullScreenShot()
        {
            return CaptureLib.CaptureScreen();
        }

        public static Image DragScreenShot()
        {
            Rectangle rect = DragForm.DragScreen();
            if (rect == Rectangle.Empty) return null;
            return CaptureLib.CaptureScreen(rect);
        }

        public static Image WindowHandleScreenShot()
        {
            IntPtr handle = HandleForm.GetWindowHandle();
            return CaptureLib.CaptureWindow(handle);
        }
    }
}
