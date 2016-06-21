using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaptIt.SettingPanels;

namespace CaptIt
{
    public partial class SettingForm : Form
    {
        public static Size SettingPanelSize;
        Settings _setting;

        List<Button> panelButtons;
        List<SettingPanel> panels;

        public SettingForm(Settings setting)
        {
            InitializeComponent();
            _setting = setting;
            SettingPanelSize = this.pForm.Size;

            InitSettings();
        }

        private void InitSettings()
        {
            panelButtons = new List<Button>()
            {
                btnGeneral, btnCapture, btnAutosave, btnShortcut
            };

            panels = new List<SettingPanel>()
            {
                new GeneralSetting(),
                new CaptureSetting(),
                new AutosaveSetting(),
                new ShortcutSetting()
            };

            foreach(SettingPanel p in panels)
            {
                p.Parent = pForm;
            }

            LoadSettingToForms(_setting);
        }

        private void LoadSettingToForms(Settings setting)
        {
            foreach (SettingPanel p in panels)
                p.LoadSettings(setting);
        }

        private void SaveSettingFromForms(Settings setting)
        {
            foreach (SettingPanel p in panels)
                p.SaveSettings(setting);
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            int index = panelButtons.IndexOf((Button)sender);
            foreach (Button b in panelButtons)
                b.BackColor = SystemColors.Control;
            panelButtons[index].BackColor = SystemColors.ControlLight;
            foreach (SettingPanel p in panels)
                p.Hide();
            panels[index].Show();
        }
    }
}
