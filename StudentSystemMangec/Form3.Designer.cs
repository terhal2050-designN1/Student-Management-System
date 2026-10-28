namespace StudentSystemMangec
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.butmessag = new System.Windows.Forms.Button();
            this.butcoler = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.radBtnmul = new System.Windows.Forms.RadioButton();
            this.radBtnsub = new System.Windows.Forms.RadioButton();
            this.radBtnadd = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelresult = new System.Windows.Forms.Label();
            this.buttclear = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.recet = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textcomp = new System.Windows.Forms.TextBox();
            this.labelcombox = new System.Windows.Forms.Label();
            this.buttcombx = new System.Windows.Forms.Button();
            this.buttshow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttDelet = new System.Windows.Forms.Button();
            this.textBxcity = new System.Windows.Forms.TextBox();
            this.textBxage = new System.Windows.Forms.TextBox();
            this.textBxname = new System.Windows.Forms.TextBox();
            this.textBxEmial = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.butsav = new System.Windows.Forms.Button();
            this.buttload = new System.Windows.Forms.Button();
            this.textBxFile = new System.Windows.Forms.TextBox();
            this.buttopen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butmessag
            // 
            this.butmessag.Location = new System.Drawing.Point(616, 606);
            this.butmessag.Name = "butmessag";
            this.butmessag.Size = new System.Drawing.Size(75, 23);
            this.butmessag.TabIndex = 0;
            this.butmessag.Text = "butmessag";
            this.butmessag.UseVisualStyleBackColor = true;
            this.butmessag.Click += new System.EventHandler(this.butmessag_Click);
            // 
            // butcoler
            // 
            this.butcoler.Location = new System.Drawing.Point(697, 606);
            this.butcoler.Name = "butcoler";
            this.butcoler.Size = new System.Drawing.Size(75, 23);
            this.butcoler.TabIndex = 1;
            this.butcoler.Text = "butcoler";
            this.butcoler.UseVisualStyleBackColor = true;
            this.butcoler.Click += new System.EventHandler(this.butcoler_Click);
            // 
            // butexit
            // 
            this.butexit.Location = new System.Drawing.Point(535, 606);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(75, 23);
            this.butexit.TabIndex = 2;
            this.butexit.Text = "butexit";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // radBtnmul
            // 
            this.radBtnmul.AutoSize = true;
            this.radBtnmul.Checked = true;
            this.radBtnmul.Location = new System.Drawing.Point(535, 373);
            this.radBtnmul.Name = "radBtnmul";
            this.radBtnmul.Size = new System.Drawing.Size(31, 17);
            this.radBtnmul.TabIndex = 3;
            this.radBtnmul.TabStop = true;
            this.radBtnmul.Text = "*";
            this.radBtnmul.UseVisualStyleBackColor = true;
            this.radBtnmul.CheckedChanged += new System.EventHandler(this.radBtnmul_CheckedChanged);
            // 
            // radBtnsub
            // 
            this.radBtnsub.AutoSize = true;
            this.radBtnsub.Location = new System.Drawing.Point(616, 373);
            this.radBtnsub.Name = "radBtnsub";
            this.radBtnsub.Size = new System.Drawing.Size(29, 17);
            this.radBtnsub.TabIndex = 4;
            this.radBtnsub.Text = "-";
            this.radBtnsub.UseVisualStyleBackColor = true;
            this.radBtnsub.CheckedChanged += new System.EventHandler(this.radBtnsub_CheckedChanged);
            // 
            // radBtnadd
            // 
            this.radBtnadd.AutoSize = true;
            this.radBtnadd.Location = new System.Drawing.Point(710, 373);
            this.radBtnadd.Name = "radBtnadd";
            this.radBtnadd.Size = new System.Drawing.Size(43, 17);
            this.radBtnadd.TabIndex = 5;
            this.radBtnadd.Text = "add";
            this.radBtnadd.UseVisualStyleBackColor = true;
            this.radBtnadd.CheckedChanged += new System.EventHandler(this.radBtnadd_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(697, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Location = new System.Drawing.Point(597, 436);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(34, 13);
            this.labelresult.TabIndex = 8;
            this.labelresult.Text = "result";
            this.labelresult.Click += new System.EventHandler(this.labelresult_Click);
            // 
            // buttclear
            // 
            this.buttclear.Location = new System.Drawing.Point(657, 426);
            this.buttclear.Name = "buttclear";
            this.buttclear.Size = new System.Drawing.Size(75, 23);
            this.buttclear.TabIndex = 9;
            this.buttclear.Text = "clear";
            this.buttclear.UseVisualStyleBackColor = true;
            this.buttclear.Click += new System.EventHandler(this.buttclear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 479);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // recet
            // 
            this.recet.Location = new System.Drawing.Point(297, 582);
            this.recet.Name = "recet";
            this.recet.Size = new System.Drawing.Size(75, 23);
            this.recet.TabIndex = 12;
            this.recet.Text = "recet";
            this.recet.UseVisualStyleBackColor = true;
            this.recet.Click += new System.EventHandler(this.recet_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(80, 582);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 13;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(184, 582);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 14;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textcomp
            // 
            this.textcomp.Location = new System.Drawing.Point(27, 146);
            this.textcomp.Name = "textcomp";
            this.textcomp.Size = new System.Drawing.Size(100, 20);
            this.textcomp.TabIndex = 16;
            this.textcomp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelcombox
            // 
            this.labelcombox.AutoSize = true;
            this.labelcombox.Location = new System.Drawing.Point(118, 222);
            this.labelcombox.Name = "labelcombox";
            this.labelcombox.Size = new System.Drawing.Size(66, 13);
            this.labelcombox.TabIndex = 17;
            this.labelcombox.Text = "labelcombox";
            this.labelcombox.Click += new System.EventHandler(this.labelcombox_Click);
            // 
            // buttcombx
            // 
            this.buttcombx.Location = new System.Drawing.Point(264, 211);
            this.buttcombx.Name = "buttcombx";
            this.buttcombx.Size = new System.Drawing.Size(75, 23);
            this.buttcombx.TabIndex = 18;
            this.buttcombx.Text = "add";
            this.buttcombx.UseVisualStyleBackColor = true;
            this.buttcombx.Click += new System.EventHandler(this.buttcombx_Click);
            // 
            // buttshow
            // 
            this.buttshow.Location = new System.Drawing.Point(158, 211);
            this.buttshow.Name = "buttshow";
            this.buttshow.Size = new System.Drawing.Size(75, 23);
            this.buttshow.TabIndex = 19;
            this.buttshow.Text = "show";
            this.buttshow.UseVisualStyleBackColor = true;
            this.buttshow.Click += new System.EventHandler(this.buttshow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttDelet);
            this.groupBox1.Controls.Add(this.textBxcity);
            this.groupBox1.Controls.Add(this.buttshow);
            this.groupBox1.Controls.Add(this.textBxage);
            this.groupBox1.Controls.Add(this.textBxname);
            this.groupBox1.Controls.Add(this.textBxEmial);
            this.groupBox1.Controls.Add(this.buttcombx);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 240);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttDelet
            // 
            this.buttDelet.Location = new System.Drawing.Point(48, 211);
            this.buttDelet.Name = "buttDelet";
            this.buttDelet.Size = new System.Drawing.Size(75, 23);
            this.buttDelet.TabIndex = 21;
            this.buttDelet.Text = "delete";
            this.buttDelet.UseVisualStyleBackColor = true;
            this.buttDelet.Click += new System.EventHandler(this.buttDelet_Click);
            // 
            // textBxcity
            // 
            this.textBxcity.Location = new System.Drawing.Point(255, 134);
            this.textBxcity.Name = "textBxcity";
            this.textBxcity.Size = new System.Drawing.Size(100, 20);
            this.textBxcity.TabIndex = 24;
            this.textBxcity.Text = "c";
            this.textBxcity.TextChanged += new System.EventHandler(this.textBxcity_TextChanged);
            // 
            // textBxage
            // 
            this.textBxage.Location = new System.Drawing.Point(255, 85);
            this.textBxage.Name = "textBxage";
            this.textBxage.Size = new System.Drawing.Size(100, 20);
            this.textBxage.TabIndex = 23;
            this.textBxage.Text = "ag";
            this.textBxage.TextChanged += new System.EventHandler(this.textBxage_TextChanged);
            // 
            // textBxname
            // 
            this.textBxname.Location = new System.Drawing.Point(255, 32);
            this.textBxname.Name = "textBxname";
            this.textBxname.Size = new System.Drawing.Size(100, 20);
            this.textBxname.TabIndex = 22;
            this.textBxname.Text = "n";
            this.textBxname.TextChanged += new System.EventHandler(this.textBxname_TextChanged);
            // 
            // textBxEmial
            // 
            this.textBxEmial.Location = new System.Drawing.Point(255, 184);
            this.textBxEmial.Name = "textBxEmial";
            this.textBxEmial.Size = new System.Drawing.Size(100, 20);
            this.textBxEmial.TabIndex = 21;
            this.textBxEmial.Text = "em";
            this.textBxEmial.TextChanged += new System.EventHandler(this.textBxEmial_TextChanged);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(206, 163);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // butsav
            // 
            this.butsav.Location = new System.Drawing.Point(589, 170);
            this.butsav.Name = "butsav";
            this.butsav.Size = new System.Drawing.Size(75, 23);
            this.butsav.TabIndex = 23;
            this.butsav.Text = "save";
            this.butsav.UseVisualStyleBackColor = true;
            this.butsav.Click += new System.EventHandler(this.butsav_Click);
            // 
            // buttload
            // 
            this.buttload.Location = new System.Drawing.Point(482, 170);
            this.buttload.Name = "buttload";
            this.buttload.Size = new System.Drawing.Size(75, 23);
            this.buttload.TabIndex = 24;
            this.buttload.Text = "load";
            this.buttload.UseVisualStyleBackColor = true;
            this.buttload.Click += new System.EventHandler(this.buttload_Click);
            // 
            // textBxFile
            // 
            this.textBxFile.Location = new System.Drawing.Point(500, 116);
            this.textBxFile.Name = "textBxFile";
            this.textBxFile.Size = new System.Drawing.Size(100, 20);
            this.textBxFile.TabIndex = 25;
            this.textBxFile.TextChanged += new System.EventHandler(this.textBxFile_TextChanged);
            // 
            // buttopen
            // 
            this.buttopen.Location = new System.Drawing.Point(389, 170);
            this.buttopen.Name = "buttopen";
            this.buttopen.Size = new System.Drawing.Size(75, 23);
            this.buttopen.TabIndex = 26;
            this.buttopen.Text = "open";
            this.buttopen.UseVisualStyleBackColor = true;
            this.buttopen.Click += new System.EventHandler(this.buttopen_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 641);
            this.Controls.Add(this.buttopen);
            this.Controls.Add(this.textBxFile);
            this.Controls.Add(this.buttload);
            this.Controls.Add(this.butsav);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelcombox);
            this.Controls.Add(this.textcomp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.recet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttclear);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radBtnadd);
            this.Controls.Add(this.radBtnsub);
            this.Controls.Add(this.radBtnmul);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butcoler);
            this.Controls.Add(this.butmessag);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butmessag;
        private System.Windows.Forms.Button butcoler;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.RadioButton radBtnmul;
        private System.Windows.Forms.RadioButton radBtnsub;
        private System.Windows.Forms.RadioButton radBtnadd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Button buttclear;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recet;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textcomp;
        private System.Windows.Forms.Label labelcombox;
        private System.Windows.Forms.Button buttcombx;
        private System.Windows.Forms.Button buttshow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBxcity;
        private System.Windows.Forms.TextBox textBxage;
        private System.Windows.Forms.TextBox textBxname;
        private System.Windows.Forms.TextBox textBxEmial;
        private System.Windows.Forms.Button buttDelet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button butsav;
        private System.Windows.Forms.Button buttload;
        private System.Windows.Forms.TextBox textBxFile;
        private System.Windows.Forms.Button buttopen;
    }
}