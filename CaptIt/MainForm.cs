using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void CaptureDragScreenShot()
        {
            Rectangle rect = DragForm.DragScreen();
        }

        private void CaptureWindowScreenShot()
        {

        }
    }
}
