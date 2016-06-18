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
            using (Bitmap screen = (Bitmap)CaptureLib.CaptureScreen())
            {
                Rectangle rect = DragForm.DragScreen(screen);
                if (rect == Rectangle.Empty) return null;
                return screen.Clone(rect, screen.PixelFormat);
            }
        }

        public static Image WindowHandleScreenShot()
        {
            IntPtr handle = HandleForm.GetWindowHandle();
            if (handle == IntPtr.Zero)
                return null;
            return CaptureLib.CaptureWindow(handle);
        }
    }
}
