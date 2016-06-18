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
    public partial class DragForm : Form
    {
        public DragForm()
        {
            InitializeComponent();
        }

        public static Rectangle DragScreen()
        {
            //DragForm 을 띄어서 영역 지정을 끝낼 때까지 기다린 후
            //영역 지정이 끝나면 그 영역을 리턴
            throw new NotImplementedException();
        }
    }
}
