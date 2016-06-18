using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
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
            backPanel = new Bitmap(Width, Height);
            _pen = new Pen(Color.Red, 1f);
        }

        bool isDown = false;
        bool isDone = false;
        Point firstPoint;
        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                firstPoint = new Point(e.X, e.Y);
                isDown = true;
            }
            else if(e.Button == MouseButtons.Right)
            {
                DoFail();
            }
        }

        Pen _pen;
        Bitmap backPanel;
        private void DragForm_MouseMove(object sender, MouseEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                using (Graphics g = Graphics.FromImage(backPanel))
                {
                    g.DrawImage(BackgroundImage, 0, 0);
                    if (isDown)
                    {
                        g.DrawLine(_pen, firstPoint.X, firstPoint.Y, e.X, firstPoint.Y);
                        g.DrawLine(_pen, firstPoint.X, firstPoint.Y, firstPoint.X, e.Y);
                        g.DrawLine(_pen, firstPoint.X, e.Y, e.X, e.Y);
                        g.DrawLine(_pen, e.X, firstPoint.Y, e.X, e.Y);
                    }
                    else
                    {
                        g.DrawLine(_pen, e.X, 0, e.X, Height);
                        g.DrawLine(_pen, 0, e.Y, Width, e.Y);
                    }
                }

                this.Invoke(new Action(() =>
                {
                    this.CreateGraphics().DrawImage(backPanel, 0, 0); 
                }));
            });
        }

        private void DragForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            if (firstPoint.X == e.X || firstPoint.Y == e.Y)
            {
                DoFail();
                return;
            }

            int x, y, width, height;

            x = Math.Min(firstPoint.X, e.X);
            y = Math.Min(firstPoint.Y, e.Y);
            width = Math.Max(firstPoint.X, e.X) - x;
            height = Math.Max(firstPoint.Y, e.Y) - y;
            result = new Rectangle(x, y, width, height);
            isDone = true;
            waitUntilDrag.Set();
        }

        private void DragForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDone)
            {
                DoFail();
            }
        }

        private void DoFail()
        {
            result = Rectangle.Empty;
            isDone = true;
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
            form.backPanel.Dispose();
            form.BackgroundImage.Dispose(); //요놈 잡느라고 30분 걸렸다!! ㅠㅠ
            form.Dispose();
            isAlreadyDragging = false;
            return rect;
        }
    }
}