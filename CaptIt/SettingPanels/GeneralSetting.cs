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
    public partial class GeneralSetting : SettingPanel
    {
        public GeneralSetting() : base()
        {
            InitializeComponent();
        }

        public override void LoadSettings(Settings setting)
        {
            this.cbStartUp.Checked = setting.IsStartUp;
            this.cbCheckUpdate.Checked = setting.CheckForUpdate;
            base.LoadSettings(setting);
        }

        public override void SaveSettings(Settings setting)
        {
            setting.IsStartUp = this.cbStartUp.Checked;
            setting.CheckForUpdate = this.cbCheckUpdate.Checked;
            base.SaveSettings(setting);
        }
    }
}
