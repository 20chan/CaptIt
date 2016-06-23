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
                cbClipboard.Text = setting.ClipboardType.ToString();
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
    }
}
