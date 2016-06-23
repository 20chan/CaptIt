namespace CaptIt.SettingPanels
{
    partial class ShortcutSetting
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.keyControl1 = new CaptIt.SettingPanels.CustomControl.KeyControl();
            this.keyControl2 = new CaptIt.SettingPanels.CustomControl.KeyControl();
            this.keyControl3 = new CaptIt.SettingPanels.CustomControl.KeyControl();
            this.SuspendLayout();
            // 
            // keyControl1
            // 
            this.keyControl1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.keyControl1.Key = System.Windows.Forms.Keys.None;
            this.keyControl1.Location = new System.Drawing.Point(241, 29);
            this.keyControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyControl1.Name = "keyControl1";
            this.keyControl1.Size = new System.Drawing.Size(210, 23);
            this.keyControl1.TabIndex = 0;
            // 
            // keyControl2
            // 
            this.keyControl2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.keyControl2.Key = System.Windows.Forms.Keys.None;
            this.keyControl2.Location = new System.Drawing.Point(241, 91);
            this.keyControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyControl2.Name = "keyControl2";
            this.keyControl2.Size = new System.Drawing.Size(210, 23);
            this.keyControl2.TabIndex = 1;
            // 
            // keyControl3
            // 
            this.keyControl3.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.keyControl3.Key = System.Windows.Forms.Keys.None;
            this.keyControl3.Location = new System.Drawing.Point(241, 60);
            this.keyControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyControl3.Name = "keyControl3";
            this.keyControl3.Size = new System.Drawing.Size(210, 23);
            this.keyControl3.TabIndex = 2;
            // 
            // ShortcutSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.keyControl3);
            this.Controls.Add(this.keyControl2);
            this.Controls.Add(this.keyControl1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShortcutSetting";
            this.Size = new System.Drawing.Size(640, 474);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.KeyControl keyControl1;
        private CustomControl.KeyControl keyControl2;
        private CustomControl.KeyControl keyControl3;
    }
}
