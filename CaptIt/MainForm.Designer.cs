namespace CaptIt
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.niTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsCapture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.캡쳐CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체화면FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.드래그영역DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.윈도우WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // niTrayIcon
            // 
            this.niTrayIcon.ContextMenuStrip = this.cmsCapture;
            this.niTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("niTrayIcon.Icon")));
            this.niTrayIcon.Text = "캡칫";
            this.niTrayIcon.Visible = true;
            // 
            // cmsCapture
            // 
            this.cmsCapture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.캡쳐CToolStripMenuItem});
            this.cmsCapture.Name = "contextMenuStrip1";
            this.cmsCapture.Size = new System.Drawing.Size(115, 26);
            // 
            // 캡쳐CToolStripMenuItem
            // 
            this.캡쳐CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전체화면FToolStripMenuItem,
            this.드래그영역DToolStripMenuItem,
            this.윈도우WToolStripMenuItem});
            this.캡쳐CToolStripMenuItem.Name = "캡쳐CToolStripMenuItem";
            this.캡쳐CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.캡쳐CToolStripMenuItem.Text = "캡쳐(&C)";
            // 
            // 전체화면FToolStripMenuItem
            // 
            this.전체화면FToolStripMenuItem.Name = "전체화면FToolStripMenuItem";
            this.전체화면FToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.전체화면FToolStripMenuItem.Text = "전체 화면(&F)";
            this.전체화면FToolStripMenuItem.Click += new System.EventHandler(this.전체화면FToolStripMenuItem_Click);
            // 
            // 드래그영역DToolStripMenuItem
            // 
            this.드래그영역DToolStripMenuItem.Name = "드래그영역DToolStripMenuItem";
            this.드래그영역DToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.드래그영역DToolStripMenuItem.Text = "드래그 영역(&D)";
            this.드래그영역DToolStripMenuItem.Click += new System.EventHandler(this.드래그영역DToolStripMenuItem_Click);
            // 
            // 윈도우WToolStripMenuItem
            // 
            this.윈도우WToolStripMenuItem.Name = "윈도우WToolStripMenuItem";
            this.윈도우WToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.윈도우WToolStripMenuItem.Text = "윈도우(&W)";
            this.윈도우WToolStripMenuItem.Click += new System.EventHandler(this.윈도우WToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.cmsCapture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niTrayIcon;
        private System.Windows.Forms.ContextMenuStrip cmsCapture;
        private System.Windows.Forms.ToolStripMenuItem 캡쳐CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체화면FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 드래그영역DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윈도우WToolStripMenuItem;
    }
}

