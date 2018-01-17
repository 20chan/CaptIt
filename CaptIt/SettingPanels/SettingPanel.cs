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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.Name = "SettingPanel";
            this.Size = new System.Drawing.Size(640, 474);
            this.ResumeLayout(false);

        }
    }
}
