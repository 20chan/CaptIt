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

        int index = 0;
        private void btnPanel_Click(object sender, EventArgs e)
        {
            index = panelButtons.IndexOf((Button)sender);
            foreach (Button b in panelButtons)
                b.ForeColor = SystemColors.ControlText;
            foreach (SettingPanel p in panels)
                p.Hide();
            panels[index].Show();
        }

        private void btnGeneral_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(128, 204, 255);
        }

        private void btnGeneral_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(51, 173, 255);
        }

        private void btnGeneral_MouseLeave(object sender, EventArgs e)
        {
            if (panelButtons.IndexOf((Button)sender) == index) ((Button)sender).ForeColor = Color.FromArgb(97, 192, 255);
            else ((Button)sender).ForeColor = ((Button)sender).ForeColor = SystemColors.ControlText; 
        }

        private void btnGeneral_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(51, 173, 255);
        }

        Point old = new Point();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (old.X - e.X),
                    this.Top - (old.Y - e.Y));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = new Point(e.X, e.Y);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (SettingPanel p in panels)
            {
                p.SaveSettings(_setting);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
