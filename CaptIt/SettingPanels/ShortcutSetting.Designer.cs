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
            this.kcFullScreen = new CaptIt.SettingPanels.CustomControl.KeyControl();
            this.lbFullScreen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDrag = new System.Windows.Forms.Label();
            this.kcDrag = new CaptIt.SettingPanels.CustomControl.KeyControl();
            this.lbWindow = new System.Windows.Forms.Label();
            this.kcWindow = new CaptIt.SettingPanels.CustomControl.KeyControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kcFullScreen
            // 
            this.kcFullScreen.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.kcFullScreen.Key = System.Windows.Forms.Keys.None;
            this.kcFullScreen.Location = new System.Drawing.Point(253, 22);
            this.kcFullScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kcFullScreen.Name = "kcFullScreen";
            this.kcFullScreen.Size = new System.Drawing.Size(210, 23);
            this.kcFullScreen.TabIndex = 0;
            // 
            // lbFullScreen
            // 
            this.lbFullScreen.Location = new System.Drawing.Point(151, 22);
            this.lbFullScreen.Name = "lbFullScreen";
            this.lbFullScreen.Size = new System.Drawing.Size(96, 23);
            this.lbFullScreen.TabIndex = 3;
            this.lbFullScreen.Text = "전체 화면 :";
            this.lbFullScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           
            // 
            // lbDrag
            // 
            this.lbDrag.Location = new System.Drawing.Point(151, 51);
            this.lbDrag.Name = "lbDrag";
            this.lbDrag.Size = new System.Drawing.Size(96, 23);
            this.lbDrag.TabIndex = 5;
            this.lbDrag.Text = "드래그 영역 :";
            this.lbDrag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kcDrag
            // 
            this.kcDrag.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.kcDrag.Key = System.Windows.Forms.Keys.None;
            this.kcDrag.Location = new System.Drawing.Point(253, 51);
            this.kcDrag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kcDrag.Name = "kcDrag";
            this.kcDrag.Size = new System.Drawing.Size(210, 23);
            this.kcDrag.TabIndex = 4;
            // 
            // lbWindow
            // 
            this.lbWindow.Location = new System.Drawing.Point(151, 80);
            this.lbWindow.Name = "lbWindow";
            this.lbWindow.Size = new System.Drawing.Size(96, 23);
            this.lbWindow.TabIndex = 7;
            this.lbWindow.Text = "윈도우 추적 :";
            this.lbWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kcWindow
            // 
            this.kcWindow.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.kcWindow.Key = System.Windows.Forms.Keys.None;
            this.kcWindow.Location = new System.Drawing.Point(253, 80);
            this.kcWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kcWindow.Name = "kcWindow";
            this.kcWindow.Size = new System.Drawing.Size(210, 23);
            this.kcWindow.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbWindow);
            this.groupBox1.Controls.Add(this.kcWindow);
            this.groupBox1.Controls.Add(this.lbDrag);
            this.groupBox1.Controls.Add(this.kcDrag);
            this.groupBox1.Controls.Add(this.lbFullScreen);
            this.groupBox1.Controls.Add(this.kcFullScreen);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "일반 캡쳐";
            // 
            // ShortcutSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShortcutSetting";
            this.Size = new System.Drawing.Size(640, 474);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.KeyControl kcFullScreen;
        private System.Windows.Forms.Label lbFullScreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDrag;
        private CustomControl.KeyControl kcDrag;
        private System.Windows.Forms.Label lbWindow;
        private CustomControl.KeyControl kcWindow;
    }
}
