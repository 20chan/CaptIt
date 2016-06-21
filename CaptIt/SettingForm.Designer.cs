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
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.pForm = new System.Windows.Forms.Panel();
            this.btnAutosave = new System.Windows.Forms.Button();
            this.btnShortcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(160, 50);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "일반";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.SystemColors.Control;
            this.btnCapture.FlatAppearance.BorderSize = 0;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnCapture.Location = new System.Drawing.Point(0, 50);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(160, 50);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "캡쳐";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // pForm
            // 
            this.pForm.Location = new System.Drawing.Point(160, 0);
            this.pForm.Margin = new System.Windows.Forms.Padding(0);
            this.pForm.Name = "pForm";
            this.pForm.Size = new System.Drawing.Size(640, 500);
            this.pForm.TabIndex = 2;
            // 
            // btnAutosave
            // 
            this.btnAutosave.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutosave.FlatAppearance.BorderSize = 0;
            this.btnAutosave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutosave.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnAutosave.Location = new System.Drawing.Point(0, 100);
            this.btnAutosave.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutosave.Name = "btnAutosave";
            this.btnAutosave.Size = new System.Drawing.Size(160, 50);
            this.btnAutosave.TabIndex = 3;
            this.btnAutosave.Text = "자동 저장";
            this.btnAutosave.UseVisualStyleBackColor = false;
            this.btnAutosave.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // btnShortcut
            // 
            this.btnShortcut.BackColor = System.Drawing.SystemColors.Control;
            this.btnShortcut.FlatAppearance.BorderSize = 0;
            this.btnShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortcut.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnShortcut.Location = new System.Drawing.Point(0, 150);
            this.btnShortcut.Margin = new System.Windows.Forms.Padding(0);
            this.btnShortcut.Name = "btnShortcut";
            this.btnShortcut.Size = new System.Drawing.Size(160, 50);
            this.btnShortcut.TabIndex = 4;
            this.btnShortcut.Text = "단축키";
            this.btnShortcut.UseVisualStyleBackColor = false;
            this.btnShortcut.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnShortcut);
            this.Controls.Add(this.btnAutosave);
            this.Controls.Add(this.pForm);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnGeneral);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingForm";
            this.Text = "설정";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Button btnAutosave;
        private System.Windows.Forms.Button btnShortcut;
    }
}