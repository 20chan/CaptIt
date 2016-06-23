using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptIt.SettingPanels.CustomControl
{
    public partial class KeyControl : UserControl
    {
        private Keys key;
        public Keys Key
        {
            get { return key; }
            set
            {
                this.tbKey.Text = value.ToString();
                key = value;
            }
        }

        public KeyControl()
        {
            InitializeComponent();
        }

        public KeyControl(Keys _key) : this()
        {
            Key = _key;
        }

        private void tbKey_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = false;
            Keys k = e.KeyCode;
            if ((Control.ModifierKeys & Keys.Shift) != 0) k |= Keys.Shift;
            if ((Control.ModifierKeys & Keys.Alt) != 0) k |= Keys.Alt;
            if ((Control.ModifierKeys & Keys.Control) != 0) k |= Keys.Control;

            this.Key = k;
        }
    }
}
