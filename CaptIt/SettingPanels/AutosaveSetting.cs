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
    public partial class AutosaveSetting : SettingPanel
    {
        public AutosaveSetting()
        {
            InitializeComponent();
        }

        public override void LoadSettings(Settings setting)
        {
            this.cbAutosave.Checked = setting.IsSaveAuto;
            this.tbPath.Text = setting.AutoSavePath;
            this.tbNameFormat.Text = setting.SaveFileNameFormat;
            if(!setting.IsSaveAuto)
            {
                tbPath.Enabled = tbNameFormat.Enabled = btnBrowse.Enabled = false;
            }

            cbExtension.Text = setting.ImageFormat.ToString();
            //TODO: 이미지 크기 관련 로드.
            base.LoadSettings(setting);
        }

        public override void SaveSettings(Settings setting)
        {
            //TODO: 올바른 경로인지, 올바른 파일 이름 포맷인지 검사. 아니면 리턴.
            
            base.LoadSettings(setting);
        }
    }
}
