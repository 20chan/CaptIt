using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptIt.SettingPanels
{
    public class SettingPanel : UserControl
    {
        public SettingPanel()
        {
            this.Size = SettingForm.SettingPanelSize;
        }

        public virtual void LoadSettings(Settings setting)
        {

        }
        public virtual void SaveSettings(Settings setting)
        {

        }
    }
}
