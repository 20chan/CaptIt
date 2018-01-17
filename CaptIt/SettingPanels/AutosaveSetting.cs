using System;
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

        private void cbAutosave_CheckedChanged(object sender, EventArgs e)
        {
            tbPath.Enabled = tbNameFormat.Enabled = cbAutosave.Checked;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                this.tbPath.Text = fbd.SelectedPath;
            }
        }
    }
}
