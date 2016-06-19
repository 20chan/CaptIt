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
    public partial class SettingForm : Form
    {
        Settings _setting;
        public SettingForm(Settings setting)
        {
            InitializeComponent();
            _setting = setting;
        }

        private void InitSettings()
        {
            //설정을 바탕으로 폼의 컨트롤을 조정.
        }
    }
}
