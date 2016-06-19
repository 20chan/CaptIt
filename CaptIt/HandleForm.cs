using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace CaptIt
{
    public partial class HandleForm : Form
    {
        static bool isAlreadyHandling = false;

        private static class API
        {
            public enum GetSystem_Metrics : int
            {
                SM_CXBORDER = 5,
                SM_CXFULLSCREEN = 16,
                SM_CYFULLSCREEN = 17
            }
            [DllImport("user32.dll")]
            public static extern int GetSystemMetrics(int smIndex);
            public enum RopMode : int
            {
                R2_NOT = 6
            }
            [DllImport("gdi32.dll")]
            public static extern int SetROP2(IntPtr hdc, int fnDrawMode);

            public enum PenStyles : int
            {
                PS_INSIDEFRAME = 6
            }
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreatePen(int fnPenStyle, int nWidth, uint crColor);

            [DllImport("gdi32.dll")]
            public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

            public enum StockObjects : int
            {
                NULL_BRUSH = 5
            }
            [DllImport("gdi32.dll")]
            public static extern IntPtr GetStockObject(int fnObject);

            [DllImport("gdi32.dll")]
            public static extern uint Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

            [DllImport("gdi32.dll")]
            public static extern bool DeleteObject(IntPtr hObject);

            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
                public Rectangle ToRectangle()
                {
                    return new Rectangle(Left, Top, Right - Left, Bottom - Top);
                }
            }

            [DllImport("user32.dll")]
            public static extern IntPtr WindowFromPoint(Point point);

            [DllImport("user32.dll")]
            public static extern bool ScreenToClient(IntPtr handle, ref Point point);

            [DllImport("user32.dll")]
            public static extern IntPtr ChildWindowFromPointEx(IntPtr hWndParent, Point pt, uint uFlags);

            [DllImport("user32.dll")]
            public static extern bool ClientToScreen(IntPtr hwnd, ref Point lpPoint);

            [DllImport("user32.dll")]
            public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern IntPtr GetParent(IntPtr hWnd);

            public enum GetWindow_Cmd : uint
            {
                GW_HWNDFIRST = 0,
                GW_HWNDLAST = 1,
                GW_HWNDNEXT = 2,
                GW_HWNDPREV = 3,
                GW_OWNER = 4,
                GW_CHILD = 5,
                GW_ENABLEDPOPUP = 6
            }
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

            [DllImport("user32.dll")]
            public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowDC(IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern int GetWindowTextLength(IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

            [DllImport("user32.dll")]
            public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

            [DllImport("user32.dll")]
            public static extern Int32 ReleaseDC(IntPtr hWnd, IntPtr hdc);

            // helper function return directly a Rectangle object
            public static Rectangle GetWindowRect(IntPtr hWnd)
            {
                RECT rect = new RECT();
                if (GetWindowRect(hWnd, ref rect) == false)
                    throw new Exception("GetWindowRect failed");
                return rect.ToRectangle();
            }

            public static string GetWindowText(IntPtr hWnd)
            {
                StringBuilder WindowText = new StringBuilder(GetWindowTextLength(hWnd) + 1);
                GetWindowText(hWnd, WindowText, WindowText.Capacity);
                return WindowText.ToString();
            }
        }
        public HandleForm()
        {
            InitializeComponent();
        }
        public ManualResetEvent WaitUntilDrag = new ManualResetEvent(false);
        bool isDown = false;
        IntPtr LastWindow;
        IntPtr FoundWindow;
        
        private void ShowInvertRectTracker(IntPtr window)
        {
            if (window != IntPtr.Zero)
            {
                // get the coordinates from the window on the screen
                Rectangle WindowRect = API.GetWindowRect(window);
                // get the window's device context
                IntPtr dc = API.GetWindowDC(window);

                // Create an inverse pen that is the size of the window border
                API.SetROP2(dc, (int)API.RopMode.R2_NOT);

                Color color = Color.FromArgb(0, 255, 0);
                IntPtr Pen = API.CreatePen((int)API.PenStyles.PS_INSIDEFRAME, 3 * API.GetSystemMetrics((int)API.GetSystem_Metrics.SM_CXBORDER), (uint)color.ToArgb());

                // Draw the rectangle around the window
                IntPtr OldPen = API.SelectObject(dc, Pen);
                IntPtr OldBrush = API.SelectObject(dc, API.GetStockObject((int)API.StockObjects.NULL_BRUSH));
                API.Rectangle(dc, 0, 0, WindowRect.Width, WindowRect.Height);

                API.SelectObject(dc, OldBrush);
                API.SelectObject(dc, OldPen);

                //release the device context, and destroy the pen
                API.ReleaseDC(window, dc);
                API.DeleteObject(Pen);
            }
        }

        private IntPtr ChildWindowFromPoint(Point point)
        {
            IntPtr WindowPoint = API.WindowFromPoint(point);
            if (WindowPoint == IntPtr.Zero)
                return IntPtr.Zero;

            if (API.ScreenToClient(WindowPoint, ref point) == false)
                throw new Exception("ScreenToClient failed");

            IntPtr Window = API.ChildWindowFromPointEx(WindowPoint, point, 0);
            if (Window == IntPtr.Zero)
                return WindowPoint;

            if (API.ClientToScreen(WindowPoint, ref point) == false)
                throw new Exception("ClientToScreen failed");

            if (API.IsChild(API.GetParent(Window), Window) == false)
                return Window;

            // create a list to hold all childs under the point
            ArrayList WindowList = new ArrayList();
            while (Window != IntPtr.Zero)
            {
                Rectangle rect = API.GetWindowRect(Window);
                if (rect.Contains(point))
                    WindowList.Add(Window);
                Window = API.GetWindow(Window, (uint)API.GetWindow_Cmd.GW_HWNDNEXT);
            }

            // search for the smallest window in the list
            int MinPixel = API.GetSystemMetrics((int)API.GetSystem_Metrics.SM_CXFULLSCREEN) * API.GetSystemMetrics((int)API.GetSystem_Metrics.SM_CYFULLSCREEN);
            for (int i = 0; i < WindowList.Count; ++i)
            {
                Rectangle rect = API.GetWindowRect((IntPtr)WindowList[i]);
                int ChildPixel = rect.Width * rect.Height;
                if (ChildPixel < MinPixel)
                {
                    MinPixel = ChildPixel;
                    Window = (IntPtr)WindowList[i];
                }
            }
            return Window;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                IntPtr FoundWindow = ChildWindowFromPoint(Cursor.Position);

                if (Control.FromHandle(FoundWindow) == null)
                {
                    if (FoundWindow != LastWindow)
                    {
                        ShowInvertRectTracker(LastWindow);
                        LastWindow = FoundWindow;
                        ShowInvertRectTracker(LastWindow);
                    }
                }
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;

            if(LastWindow != IntPtr.Zero)
            {
                WaitUntilDrag.Set();
                ShowInvertRectTracker(LastWindow);
            }
        }

        private static void ShowHandleForm(object form)
        {
            ((HandleForm)form).ShowDialog();
        }

        /// <summary>
        /// 핸들링 폼을 띄우고, 구한 윈도우의 핸들을 리턴.
        /// </summary>
        /// <returns>윈도우의 핸들. 만약 이미 다른 폼이 핸들링중이었다면 IntPtr.Zero 를 리턴.</returns>
        public static IntPtr GetWindowHandle()
        {
            CheckForIllegalCrossThreadCalls = false;
            if (isAlreadyHandling) return IntPtr.Zero;
            isAlreadyHandling = true;
            HandleForm form = new HandleForm();
            Thread t = new Thread(new ParameterizedThreadStart(ShowHandleForm));
            t.Start(form);
            form.WaitUntilDrag.WaitOne();
            form.WaitUntilDrag.Reset();

            form.Close();
            isAlreadyHandling = false;
            return form.LastWindow;
        }

    }
}
