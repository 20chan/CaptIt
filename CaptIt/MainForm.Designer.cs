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
            this.설정SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pFront = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnHouse = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cmsCapture.SuspendLayout();
            this.pFront.SuspendLayout();
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
            this.캡쳐CToolStripMenuItem,
            this.설정SToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.cmsCapture.Name = "contextMenuStrip1";
            this.cmsCapture.Size = new System.Drawing.Size(115, 70);
            // 
            // 캡쳐CToolStripMenuItem
            // 
            this.캡쳐CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전체화면FToolStripMenuItem,
            this.드래그영역DToolStripMenuItem,
            this.윈도우WToolStripMenuItem});
            this.캡쳐CToolStripMenuItem.Name = "캡쳐CToolStripMenuItem";
            this.캡쳐CToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            // 설정SToolStripMenuItem
            // 
            this.설정SToolStripMenuItem.Name = "설정SToolStripMenuItem";
            this.설정SToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.설정SToolStripMenuItem.Text = "설정(&S)";
            this.설정SToolStripMenuItem.Click += new System.EventHandler(this.설정SToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.종료ToolStripMenuItem.Text = "종료(&X)";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // pFront
            // 
            this.pFront.BackColor = System.Drawing.Color.White;
            this.pFront.Controls.Add(this.btnHelp);
            this.pFront.Controls.Add(this.btnSetting);
            this.pFront.Controls.Add(this.lbName);
            this.pFront.Controls.Add(this.btnMinimize);
            this.pFront.Controls.Add(this.btnClose);
            this.pFront.Controls.Add(this.btnCamera);
            this.pFront.Location = new System.Drawing.Point(1, 1);
            this.pFront.Margin = new System.Windows.Forms.Padding(0);
            this.pFront.Name = "pFront";
            this.pFront.Size = new System.Drawing.Size(298, 159);
            this.pFront.TabIndex = 2;
            this.pFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.btnSetting.Location = new System.Drawing.Point(197, 1);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(25, 25);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TabStop = false;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            this.btnSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSetting_Paint);
            // 
            // lbName
            // 
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.lbName.Location = new System.Drawing.Point(3, 6);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 25);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "CaptIt";
            this.lbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.lbName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnMinimize.Location = new System.Drawing.Point(247, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(272, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.Color.White;
            this.btnCamera.FlatAppearance.BorderSize = 0;
            this.btnCamera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamera.Image = ((System.Drawing.Image)(resources.GetObject("btnCamera.Image")));
            this.btnCamera.Location = new System.Drawing.Point(100, 40);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(100, 100);
            this.btnCamera.TabIndex = 1;
            this.btnCamera.TabStop = false;
            this.btnCamera.UseVisualStyleBackColor = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            this.btnCamera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCamera_MouseDown);
            this.btnCamera.MouseEnter += new System.EventHandler(this.btnCamera_MouseEnter);
            this.btnCamera.MouseLeave += new System.EventHandler(this.btnCamera_MouseLeave);
            this.btnCamera.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCamera_MouseUp);
            // 
            // btnHouse
            // 
            this.btnHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHouse.FlatAppearance.BorderSize = 0;
            this.btnHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouse.Location = new System.Drawing.Point(278, 160);
            this.btnHouse.Margin = new System.Windows.Forms.Padding(0);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(20, 20);
            this.btnHouse.TabIndex = 4;
            this.btnHouse.TabStop = false;
            this.btnHouse.UseVisualStyleBackColor = false;
            this.btnHouse.Click += new System.EventHandler(this.btnHouse_Click);
            this.btnHouse.Paint += new System.Windows.Forms.PaintEventHandler(this.btnHouse_Paint);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnHelp.Location = new System.Drawing.Point(222, 1);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.ControlBox = false;
            this.Controls.Add(this.btnHouse);
            this.Controls.Add(this.pFront);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "CaptIt";
            this.cmsCapture.ResumeLayout(false);
            this.pFront.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niTrayIcon;
        private System.Windows.Forms.ContextMenuStrip cmsCapture;
        private System.Windows.Forms.ToolStripMenuItem 캡쳐CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체화면FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 드래그영역DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윈도우WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정SToolStripMenuItem;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Panel pFront;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHouse;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHelp;
    }
}

