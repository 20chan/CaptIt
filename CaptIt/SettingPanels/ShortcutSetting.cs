namespace CaptIt.SettingPanels
{
    public partial class ShortcutSetting : SettingPanel
    {
        public ShortcutSetting()
        {
            InitializeComponent();
        }

        public override void LoadSettings(Settings setting)
        {
            this.kcFullScreen.Key = setting.FullScreenShotKey;
            this.kcDrag.Key = setting.DragScreenShotKey;
            this.kcWindow.Key = setting.WindowScreenShotKey;
            base.LoadSettings(setting);
        }

        public override void SaveSettings(Settings setting)
        {
            setting.FullScreenShotKey = this.kcFullScreen.Key;
            setting.DragScreenShotKey = this.kcDrag.Key;
            setting.WindowScreenShotKey = this.kcWindow.Key;
            base.SaveSettings(setting);
        }
    }
}
