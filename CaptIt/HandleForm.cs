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
    public partial class HandleForm : Form
    {
        public HandleForm()
        {
            InitializeComponent();
        }

        public static IntPtr GetWindowHandle()
        {
            //마우스가 위치해있는 윈도우의 핸들을 가져옴.
            return IntPtr.Zero;
        }
    }
}
