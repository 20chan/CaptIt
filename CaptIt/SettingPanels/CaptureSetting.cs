using System;
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
            this.cbSoundEffect.Checked = setting.IsCaptureSoundEffect;
            cbSound.Text = setting.CaptureSoundEffect;
            if (setting.IsCaptureSoundEffect)
                cbSound.Enabled = true;
            else
                cbSound.Enabled = false;

            if (setting.ClipboardType == ClipboardType.NONE)
            {
                cbClip.Checked = false;
                cbClipboard.Enabled = false;
            }
            else
            {
                cbClip.Checked = true;
                if (setting.ClipboardType == ClipboardType.COPYIMAGE) cbClipboard.Text = "이미지 복사";
                else if (setting.ClipboardType == ClipboardType.COPYPATH) cbClipboard.Text = "이미지 경로 복사";
            }

            btnColor.BackColor = setting.DragCaptureBackGroundColor;
            tbOpacity.Value = (int)(100 * setting.DragCaptureOpcaity);
            base.LoadSettings(setting);
        }

        public override void SaveSettings(Settings setting)
        {
            setting.IsCaptureSoundEffect = this.cbSoundEffect.Checked;
            setting.CaptureSoundEffect = this.cbSound.Text;

            if (!cbClip.Checked) setting.ClipboardType = ClipboardType.NONE;
            else
            {
                if (cbClipboard.Text == "이미지 복사") setting.ClipboardType = ClipboardType.COPYIMAGE;
                else if (cbClipboard.Text == "이미지 경로 복사") setting.ClipboardType = ClipboardType.COPYPATH;
            }

            setting.DragCaptureBackGroundColor = btnColor.BackColor;
            setting.DragCaptureOpcaity = (double)tbOpacity.Value / 100.0;
            base.SaveSettings(setting);
        }

        private void cbSoundEffect_CheckedChanged(object sender, EventArgs e)
        {
            cbSound.Enabled = cbSoundEffect.Checked;
        }

        private void cbClip_CheckedChanged(object sender, EventArgs e)
        {
            cbClipboard.Enabled = cbClip.Checked;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.btnColor.BackColor = cd.Color;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MainForm.Main.PlaySound(cbSound.Text);
        }
    }
}
