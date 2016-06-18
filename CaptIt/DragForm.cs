using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Capture;

namespace CaptIt
{
    public partial class DragForm : Form
    {
        static bool isAlreadyDragging = false;
        ManualResetEvent waitUntilDrag = new ManualResetEvent(false);

        Rectangle result;
        public DragForm()
        {
            InitializeComponent();

            this.Size = CaptureLib.FullScreensSize();
            this.BackgroundImage = CaptureLib.CaptureScreen();
        }
        
        Point firstPoint;
        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = new Point(e.X, e.Y);
        }

        private void DragForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (firstPoint.X == e.X || firstPoint.Y == e.Y)
            {
                result = Rectangle.Empty;
                waitUntilDrag.Set();
            }

            int x, y, width, height;

            x = Math.Min(firstPoint.X, e.X);
            y = Math.Min(firstPoint.Y, e.Y);
            width = Math.Max(firstPoint.X, e.X) - x;
            height = Math.Max(firstPoint.Y, e.Y) - y;

            result = new Rectangle(x, y, width, height);
            waitUntilDrag.Set();
        }

        private static void ShowDragForm(object f)
        {
            ((DragForm)f).ShowDialog();
        }

        /// <summary>
        /// 드래그 폼을 띄우고, 그 드래그 값을 리턴.
        /// </summary>
        /// <returns>텅 빈 사각형이면 Rectangle.Empty 를 리턴.</returns>
        public static Rectangle DragScreen()
        {
            CheckForIllegalCrossThreadCalls = false;
            if (isAlreadyDragging) return Rectangle.Empty;
            isAlreadyDragging = true;

            DragForm form = new DragForm();
            Thread t = new Thread(new ParameterizedThreadStart(ShowDragForm));
            t.Start(form);
            form.waitUntilDrag.WaitOne();
            form.waitUntilDrag.Reset();

            Rectangle rect = form.result;
            form.Close();
            form.BackgroundImage.Dispose();
            form.Dispose();
            isAlreadyDragging = false;
            return rect;
        }
    }
}