namespace CaptIt.SettingPanels
{
    partial class CaptureSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbClipboard = new System.Windows.Forms.ComboBox();
            this.cbClip = new System.Windows.Forms.CheckBox();
            this.cbSound = new System.Windows.Forms.ComboBox();
            this.cbSoundEffect = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbOpacity = new System.Windows.Forms.TrackBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.lbOpacity = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbClipboard);
            this.groupBox1.Controls.Add(this.cbClip);
            this.groupBox1.Controls.Add(this.cbSound);
            this.groupBox1.Controls.Add(this.cbSoundEffect);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캡쳐 일반";
            // 
            // cbClipboard
            // 
            this.cbClipboard.FormattingEnabled = true;
            this.cbClipboard.Items.AddRange(new object[] {
            "이미지 복사",
            "이미지 경로 복사"});
            this.cbClipboard.Location = new System.Drawing.Point(253, 51);
            this.cbClipboard.Name = "cbClipboard";
            this.cbClipboard.Size = new System.Drawing.Size(210, 23);
            this.cbClipboard.TabIndex = 3;
            // 
            // cbClip
            // 
            this.cbClip.AutoSize = true;
            this.cbClip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbClip.Location = new System.Drawing.Point(89, 53);
            this.cbClip.Name = "cbClip";
            this.cbClip.Size = new System.Drawing.Size(158, 19);
            this.cbClip.TabIndex = 2;
            this.cbClip.Text = "캡처 후 클립보드로 복사";
            this.cbClip.UseVisualStyleBackColor = true;
            // 
            // cbSound
            // 
            this.cbSound.FormattingEnabled = true;
            this.cbSound.Items.AddRange(new object[] {
            "카메라 셔터 소리1"});
            this.cbSound.Location = new System.Drawing.Point(253, 22);
            this.cbSound.Name = "cbSound";
            this.cbSound.Size = new System.Drawing.Size(210, 23);
            this.cbSound.TabIndex = 1;
            // 
            // cbSoundEffect
            // 
            this.cbSoundEffect.AutoSize = true;
            this.cbSoundEffect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSoundEffect.Location = new System.Drawing.Point(101, 24);
            this.cbSoundEffect.Name = "cbSoundEffect";
            this.cbSoundEffect.Size = new System.Drawing.Size(146, 19);
            this.cbSoundEffect.TabIndex = 0;
            this.cbSoundEffect.Text = "캡쳐할 때 효과음 실행";
            this.cbSoundEffect.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOpacity);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.lbOpacity);
            this.groupBox2.Controls.Add(this.lbColor);
            this.groupBox2.Location = new System.Drawing.Point(3, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "영역 지정 캡쳐";
            // 
            // tbOpacity
            // 
            this.tbOpacity.LargeChange = 10;
            this.tbOpacity.Location = new System.Drawing.Point(253, 50);
            this.tbOpacity.Maximum = 100;
            this.tbOpacity.Minimum = 1;
            this.tbOpacity.Name = "tbOpacity";
            this.tbOpacity.Size = new System.Drawing.Size(210, 45);
            this.tbOpacity.TabIndex = 5;
            this.tbOpacity.TickFrequency = 10;
            this.tbOpacity.Value = 1;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(253, 21);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(210, 23);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "색상 선택";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // lbOpacity
            // 
            this.lbOpacity.AutoSize = true;
            this.lbOpacity.Location = new System.Drawing.Point(165, 54);
            this.lbOpacity.Name = "lbOpacity";
            this.lbOpacity.Size = new System.Drawing.Size(82, 15);
            this.lbOpacity.TabIndex = 5;
            this.lbOpacity.Text = "배경 투명도 : ";
            this.lbOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(177, 25);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(70, 15);
            this.lbColor.TabIndex = 4;
            this.lbColor.Text = "배경 색상 : ";
            this.lbColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaptureSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Name = "CaptureSetting";
            this.Size = new System.Drawing.Size(640, 474);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSoundEffect;
        private System.Windows.Forms.ComboBox cbSound;
        private System.Windows.Forms.ComboBox cbClipboard;
        private System.Windows.Forms.CheckBox cbClip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbOpacity;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lbOpacity;
        private System.Windows.Forms.Label lbColor;
    }
}
