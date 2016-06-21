namespace CaptIt.SettingPanels
{
    partial class GeneralSetting
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
            this.cbStartUp = new System.Windows.Forms.CheckBox();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.cbCheckUpdate = new System.Windows.Forms.CheckBox();
            this.gbProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStartUp
            // 
            this.cbStartUp.AutoSize = true;
            this.cbStartUp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbStartUp.Location = new System.Drawing.Point(61, 24);
            this.cbStartUp.Name = "cbStartUp";
            this.cbStartUp.Size = new System.Drawing.Size(186, 19);
            this.cbStartUp.TabIndex = 0;
            this.cbStartUp.Text = "컴퓨터 시작 시 자동으로 실행";
            this.cbStartUp.UseVisualStyleBackColor = true;
            // 
            // gbProgram
            // 
            this.gbProgram.Controls.Add(this.cbCheckUpdate);
            this.gbProgram.Controls.Add(this.cbStartUp);
            this.gbProgram.Location = new System.Drawing.Point(3, 3);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(637, 164);
            this.gbProgram.TabIndex = 1;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "프로그램";
            // 
            // cbCheckUpdate
            // 
            this.cbCheckUpdate.AutoSize = true;
            this.cbCheckUpdate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCheckUpdate.Location = new System.Drawing.Point(117, 49);
            this.cbCheckUpdate.Name = "cbCheckUpdate";
            this.cbCheckUpdate.Size = new System.Drawing.Size(130, 19);
            this.cbCheckUpdate.TabIndex = 1;
            this.cbCheckUpdate.Text = "업데이트 자동 확인";
            this.cbCheckUpdate.UseVisualStyleBackColor = true;
            // 
            // GeneralSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.gbProgram);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeneralSetting";
            this.Size = new System.Drawing.Size(640, 500);
            this.gbProgram.ResumeLayout(false);
            this.gbProgram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbStartUp;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.CheckBox cbCheckUpdate;
    }
}
