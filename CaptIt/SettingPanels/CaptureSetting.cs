using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptIt.SettingPanels
{
    public partial class CaptureSetting : SettingPanel
    {
        public CaptureSetting()
        {
            InitializeComponent();
        }

        public override void LoadSettings(Settings setting)
        {
            base.LoadSettings(setting);
        }

        public override void SaveSettings(Settings setting)
        {
            base.SaveSettings(setting);
        }
    }
}
