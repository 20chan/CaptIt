using System.Windows.Forms;

namespace CaptIt.SettingPanels.CustomControl
{
    public partial class KeyControl : UserControl
    {
        private Keys key = Keys.None;
        public Keys Key
        {
            get { return key; }
            set
            {
                this.tbKey.Text = KeyToString(value);
                key = value;
            }
        }

        public string KeyToString(Keys k)
        {
            string result = "";
            if ((k & Keys.Control) != 0)
                result += "Ctrl + ";
            if ((k & Keys.Shift) != 0)
                result += "Shift + ";
            if ((k & Keys.Alt) != 0)
                result += "Alt + ";

            k &= (~Keys.Control);
            k &= (~Keys.Shift);
            k &= (~Keys.Alt);

            if (k != Keys.LMenu && k != Keys.RMenu && k != Keys.LControlKey && k != Keys.RControlKey && k != Keys.LShiftKey && k != Keys.RShiftKey)
                result += k.ToString();
            else if (k == Keys.LControlKey || k == Keys.RControlKey)
                result += "Ctrl + ";
            else if (k == Keys.LShiftKey || k == Keys.RShiftKey)
                result += "Shift + ";
            else if (k == Keys.LMenu || k == Keys.RMenu)
                result += "Alt + ";

            return result;
        }

        public KeyControl()
        {
            InitializeComponent();

            //전혀 의미 없는 일이다. 하지만 이 컨트롤을 디자이너에서 생성했을 때, 생성자를 호출할 때
            //이벤트 핸들링 에러 때문에 일부러 실제 프로그램이 실행됐을 때만 실행되게끔 했다.
            //http://stackoverflow.com/questions/1567066/errors-in-visualstudio-when-opening-usercontrol-in-designer
            if (Program.Running)
                MainForm.Main.HookKeyDown += (k) => CalcKey(k);
        }
        
        private void CalcKey(Keys k)
        {
            if (!tbKey.Focused) return;
            if ((Control.ModifierKeys & Keys.Shift) != 0) k |= Keys.Shift;
            if ((Control.ModifierKeys & Keys.Alt) != 0) k |= Keys.Alt;
            if ((Control.ModifierKeys & Keys.Control) != 0) k |= Keys.Control;

            this.Key = k;
        }

        private void tbKey_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
