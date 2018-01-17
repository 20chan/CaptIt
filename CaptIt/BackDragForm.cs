using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Capture;

namespace CaptIt
{
    public partial class BackDragForm : Form
    {
        public ManualResetEvent WaitUntilDrag { get { return _form.WaitUntilDrag; } }
        DragForm _form;

        public Rectangle Result { get { return _form.result; } }

        public BackDragForm(Image back)
        {
            InitializeComponent();
            this.Size = CaptureLib.FullScreensSize();
            this.BackgroundImage = back;

            _form = new DragForm();
            Thread t = new Thread(new ParameterizedThreadStart(showForm));
            t.Start(_form);
            //여기서 그냥 _form 을 실행시켰더니 폼이 꺼질때까지 생성자가 끝나지 않아, 결국 ManualResetEvent 가 Set되었음에도 불구하고
            //폼이 종료되기 전까지 아무것도 되지 않던 버그가 있었다. 스레드로 해결.
            //_form.ShowDialog();
        }
        
        private void showForm(object f)
        {
            ((DragForm)f).ShowDialog();
        }

        public void DisposeDragForm()
        {
            _form.DisposeBack();
            _form.Dispose();
        }

        private void BackDragForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.Close();
            _form.Dispose();
        }

        private void BackDragForm_Load(object sender, EventArgs e)
        {
            //로드이벤트 안에 넣었더니 삭제된 개체에 접근 오류.
            //_form.ShowDialog();
        }
    }
}
