namespace CaptIt
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.pForm = new System.Windows.Forms.Panel();
            this.btnAutosave = new System.Windows.Forms.Button();
            this.btnShortcut = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.White;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGeneral.Location = new System.Drawing.Point(1, 26);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(160, 50);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "일반";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnPanel_Click);
            this.btnGeneral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeneral_MouseDown);
            this.btnGeneral.MouseEnter += new System.EventHandler(this.btnGeneral_MouseEnter);
            this.btnGeneral.MouseLeave += new System.EventHandler(this.btnGeneral_MouseLeave);
            this.btnGeneral.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeneral_MouseUp);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.White;
            this.btnCapture.FlatAppearance.BorderSize = 0;
            this.btnCapture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnCapture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnCapture.Location = new System.Drawing.Point(1, 76);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(160, 50);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "캡쳐";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnPanel_Click);
            this.btnCapture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeneral_MouseDown);
            this.btnCapture.MouseEnter += new System.EventHandler(this.btnGeneral_MouseEnter);
            this.btnCapture.MouseLeave += new System.EventHandler(this.btnGeneral_MouseLeave);
            this.btnCapture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeneral_MouseUp);
            // 
            // pForm
            // 
            this.pForm.BackColor = System.Drawing.Color.White;
            this.pForm.Location = new System.Drawing.Point(161, 26);
            this.pForm.Margin = new System.Windows.Forms.Padding(0);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(638, 474);
            this.pForm.TabIndex = 2;
            // 
            // btnAutosave
            // 
            this.btnAutosave.BackColor = System.Drawing.Color.White;
            this.btnAutosave.FlatAppearance.BorderSize = 0;
            this.btnAutosave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnAutosave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnAutosave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutosave.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnAutosave.Location = new System.Drawing.Point(1, 126);
            this.btnAutosave.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutosave.Name = "btnAutosave";
            this.btnAutosave.Size = new System.Drawing.Size(160, 50);
            this.btnAutosave.TabIndex = 3;
            this.btnAutosave.Text = "자동 저장";
            this.btnAutosave.UseVisualStyleBackColor = false;
            this.btnAutosave.Click += new System.EventHandler(this.btnPanel_Click);
            this.btnAutosave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeneral_MouseDown);
            this.btnAutosave.MouseEnter += new System.EventHandler(this.btnGeneral_MouseEnter);
            this.btnAutosave.MouseLeave += new System.EventHandler(this.btnGeneral_MouseLeave);
            this.btnAutosave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeneral_MouseUp);
            // 
            // btnShortcut
            // 
            this.btnShortcut.BackColor = System.Drawing.Color.White;
            this.btnShortcut.FlatAppearance.BorderSize = 0;
            this.btnShortcut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortcut.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnShortcut.Location = new System.Drawing.Point(1, 176);
            this.btnShortcut.Margin = new System.Windows.Forms.Padding(0);
            this.btnShortcut.Name = "btnShortcut";
            this.btnShortcut.Size = new System.Drawing.Size(160, 50);
            this.btnShortcut.TabIndex = 4;
            this.btnShortcut.Text = "단축키";
            this.btnShortcut.UseVisualStyleBackColor = false;
            this.btnShortcut.Click += new System.EventHandler(this.btnPanel_Click);
            this.btnShortcut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeneral_MouseDown);
            this.btnShortcut.MouseEnter += new System.EventHandler(this.btnGeneral_MouseEnter);
            this.btnShortcut.MouseLeave += new System.EventHandler(this.btnGeneral_MouseLeave);
            this.btnShortcut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeneral_MouseUp);
            // 
            // lbName
            // 
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.lbName.Location = new System.Drawing.Point(3, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 25);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "CaptIt";
            this.lbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.lbName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnMinimize.Location = new System.Drawing.Point(750, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 6;
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
            this.btnClose.Location = new System.Drawing.Point(775, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGeneral);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnCapture);
            this.panel1.Controls.Add(this.pForm);
            this.panel1.Controls.Add(this.btnAutosave);
            this.panel1.Controls.Add(this.btnShortcut);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(802, 521);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "설정";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Button btnAutosave;
        private System.Windows.Forms.Button btnShortcut;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}