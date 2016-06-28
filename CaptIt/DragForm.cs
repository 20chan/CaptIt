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
        public ManualResetEvent WaitUntilDrag = new ManualResetEvent(false);
        public Rectangle result;
        public DragForm()
        {
            InitializeComponent();

            this.Size = CaptureLib.FullScreensSize();
            back = new Bitmap(Size.Width, Size.Height);

            this.Opacity = MainForm.Main.Settings.DragCaptureOpcaity;
            this.BackColor = MainForm.Main.Settings.DragCaptureBackGroundColor;
        }

        bool isDown = false;
        bool isDone = false;
        Point firstPoint;
        Bitmap back;
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

        private void DragForm_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (isDown)
                {
                    int x, y, width, height;

                    x = Math.Min(firstPoint.X, e.X);
                    y = Math.Min(firstPoint.Y, e.Y);
                    width = Math.Max(firstPoint.X, e.X) - x;
                    height = Math.Max(firstPoint.Y, e.Y) - y;

                    this.panel1.Location = new Point(x + 1, y + 1);
                    this.panel1.Size = new Size(width + 1, height + 1);
                    /*
                    Graphics g = Graphics.FromImage(back);
                    g.Clear(BackColor);
                    g.DrawRectangle(Pens.Red, x, y, width, height);
                    this.CreateGraphics().DrawImage(back, 0, 0);
                    */
                }
            }
            catch
            { }
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
            WaitUntilDrag.Set();
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
            WaitUntilDrag.Set();
        }

        public void DisposeBack()
        {
            back.Dispose();
        }

        private static void ShowBackDragForm(object f)
        {
            ((BackDragForm)f).ShowDialog();
        }

        /// <summary>
        /// 드래그 폼을 띄우고, 그 드래그 값을 리턴.
        /// </summary>
        /// <returns>텅 빈 사각형이면 Rectangle.Empty 를 리턴.</returns>
        public static Rectangle DragScreen(Image fullScreenShot)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (isAlreadyDragging) return Rectangle.Empty;
            isAlreadyDragging = true;

            BackDragForm form = new BackDragForm(fullScreenShot);
            Thread t = new Thread(new ParameterizedThreadStart(ShowBackDragForm));
            t.Start(form);
            form.WaitUntilDrag.WaitOne();
            form.WaitUntilDrag.Reset();

            Rectangle rect = form.Result;

            form.Close();
            //두번째 메모리 릭도 고쳤다. DragForm 에서 back 이미지 판넬 (더블 버퍼링용)이 Dispose되지 않았던 것이었다.
            form.DisposeDragForm();
            //바뀌었다. 원래는 Dispose를 했어야 하지만, 이제는 ScreenShot 클래스에서 사용하기 때문에 그대로 내보낸다.
            //form.BackgroundImage.Dispose(); //요놈 잡느라고 30분 걸렸다!! ㅠㅠ
            form.Dispose();
            isAlreadyDragging = false;
            return rect;
        }
    }
}