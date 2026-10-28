namespace StudentSystemMangec
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labTimer = new System.Windows.Forms.Label();
            this.labHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(104, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(302, 34);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labTimer
            // 
            this.labTimer.AutoSize = true;
            this.labTimer.BackColor = System.Drawing.Color.Transparent;
            this.labTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labTimer.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimer.ForeColor = System.Drawing.Color.Transparent;
            this.labTimer.Location = new System.Drawing.Point(213, 138);
            this.labTimer.Name = "labTimer";
            this.labTimer.Size = new System.Drawing.Size(0, 19);
            this.labTimer.TabIndex = 1;
            this.labTimer.Click += new System.EventHandler(this.labTimer_Click);
            // 
            // labHeader
            // 
            this.labHeader.AutoSize = true;
            this.labHeader.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labHeader.Location = new System.Drawing.Point(145, 33);
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(308, 25);
            this.labHeader.TabIndex = 2;
            this.labHeader.Text = "Student Management System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::StudentSystemMangec.Properties.Resources.university_graduate_education_grad_academy_graduation_icon_2303831;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-10, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 75);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(475, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labHeader);
            this.Controls.Add(this.labTimer);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labTimer;
        private System.Windows.Forms.Label labHeader;
        private System.Windows.Forms.Button button1;
    }
}