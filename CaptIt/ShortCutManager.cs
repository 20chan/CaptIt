using System;
using System.Windows.Forms;
using Hook;
namespace CaptIt
{
    public class ShortCutManager
    {
        private KeyboardHook _hook;
        public event Action<Keys> KeyDowned;
        public ShortCutManager()
        {
            _hook = new KeyboardHook();
            _hook.KeyDown += _hook_KeyDown;
            _hook.KeyUp += _hook_KeyUp;

            _hook.HookStart();
        }

        ~ShortCutManager()
        {
            _hook.HookEnd();
        }

        private bool _hook_KeyDown(Keys arg)
        {
            KeyDowned?.Invoke(arg);
            if (MainForm.Main.IsSetting) return true;
            //TODO: 이거 테이블? 같은 걸로 개선이 가능할 것 같음. 개선이 필요!!
            Keys key = arg;
            if ((Control.ModifierKeys & Keys.Shift) != 0) key |= Keys.Shift;
            if ((Control.ModifierKeys & Keys.Control) != 0) key |= Keys.Control;
            if ((Control.ModifierKeys & Keys.Alt) != 0) key |= Keys.Alt;

            if (MainForm.Main.Settings.FullScreenShotKey == key)
                MainForm.Main.CaptureFullScreenShot();
            if (MainForm.Main.Settings.DragScreenShotKey == key)
                MainForm.Main.CaptureDragScreenShot();
            if (MainForm.Main.Settings.WindowScreenShotKey == key)
                MainForm.Main.CaptureWindowScreenShot();

            return true;
        }

        private bool _hook_KeyUp(Keys arg)
        {
            Keys key = arg;
            if ((Control.ModifierKeys & Keys.Shift) != 0) key |= Keys.Shift;
            if ((Control.ModifierKeys & Keys.Control) != 0) key |= Keys.Control;
            if ((Control.ModifierKeys & Keys.Alt) != 0) key |= Keys.Alt;

            return true;
        }
    }
}