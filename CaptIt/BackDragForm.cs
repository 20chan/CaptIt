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
        }

        private void BackDragForm_Shown(object sender, EventArgs e)
        {
            _form.ShowDialog();
        }

        private void BackDragForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.Close();
            _form.Dispose();
        }
    }
}
