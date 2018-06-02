namespace MangaSplitter
{
    partial class FrmMain
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
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSourceDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.diagFolder = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnTargerDir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radBooklet = new System.Windows.Forms.RadioButton();
            this.lblPath = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSubfolders = new System.Windows.Forms.CheckBox();
            this.radRTL = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.grpRTL = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbJS = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpRTL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Start splitting manga!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(184, 138);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Single page max width:";
            // 
            // btnSourceDir
            // 
            this.btnSourceDir.Location = new System.Drawing.Point(439, 35);
            this.btnSourceDir.Name = "btnSourceDir";
            this.btnSourceDir.Size = new System.Drawing.Size(107, 33);
            this.btnSourceDir.TabIndex = 7;
            this.btnSourceDir.Text = "Choose...";
            this.btnSourceDir.UseVisualStyleBackColor = true;
            this.btnSourceDir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Source Directory:";
            // 
            // diagFolder
            // 
            this.diagFolder.FileName = "Choose Directory";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btnTargerDir
            // 
            this.btnTargerDir.Location = new System.Drawing.Point(439, 92);
            this.btnTargerDir.Name = "btnTargerDir";
            this.btnTargerDir.Size = new System.Drawing.Size(107, 33);
            this.btnTargerDir.TabIndex = 13;
            this.btnTargerDir.Text = "Choose...";
            this.btnTargerDir.UseVisualStyleBackColor = true;
            this.btnTargerDir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose Target Directory (not insdie source):";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(318, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 24);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Duplex";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radBooklet
            // 
            this.radBooklet.AutoSize = true;
            this.radBooklet.Location = new System.Drawing.Point(53, 27);
            this.radBooklet.Name = "radBooklet";
            this.radBooklet.Size = new System.Drawing.Size(85, 24);
            this.radBooklet.TabIndex = 19;
            this.radBooklet.Text = "Booklet ";
            this.radBooklet.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(6, 38);
            this.lblPath.Name = "lblPath";
            this.lblPath.ReadOnly = true;
            this.lblPath.Size = new System.Drawing.Size(427, 26);
            this.lblPath.TabIndex = 20;
            // 
            // lblTarget
            // 
            this.lblTarget.Location = new System.Drawing.Point(6, 95);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.ReadOnly = true;
            this.lblTarget.Size = new System.Drawing.Size(427, 26);
            this.lblTarget.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "(px) ";
            // 
            // cbSubfolders
            // 
            this.cbSubfolders.AutoSize = true;
            this.cbSubfolders.Checked = true;
            this.cbSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSubfolders.Location = new System.Drawing.Point(236, 8);
            this.cbSubfolders.Name = "cbSubfolders";
            this.cbSubfolders.Size = new System.Drawing.Size(109, 24);
            this.cbSubfolders.TabIndex = 23;
            this.cbSubfolders.Text = "Subfolders ";
            this.cbSubfolders.UseVisualStyleBackColor = true;
            // 
            // radRTL
            // 
            this.radRTL.AutoSize = true;
            this.radRTL.Checked = true;
            this.radRTL.Location = new System.Drawing.Point(288, 29);
            this.radRTL.Name = "radRTL";
            this.radRTL.Size = new System.Drawing.Size(61, 24);
            this.radRTL.TabIndex = 27;
            this.radRTL.TabStop = true;
            this.radRTL.Text = "RTL ";
            this.radRTL.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(355, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 24);
            this.radioButton4.TabIndex = 28;
            this.radioButton4.Text = "LTR";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(8, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Javascript code helper:";
            // 
            // grpRTL
            // 
            this.grpRTL.Controls.Add(this.radRTL);
            this.grpRTL.Controls.Add(this.radioButton4);
            this.grpRTL.Location = new System.Drawing.Point(18, 15);
            this.grpRTL.Name = "grpRTL";
            this.grpRTL.Size = new System.Drawing.Size(527, 65);
            this.grpRTL.TabIndex = 32;
            this.grpRTL.TabStop = false;
            this.grpRTL.Text = "(R)ight-(T)o-(L)eft Binding?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radBooklet);
            this.groupBox1.Location = new System.Drawing.Point(18, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 65);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printing type?";
            // 
            // rtbJS
            // 
            this.rtbJS.Location = new System.Drawing.Point(11, 223);
            this.rtbJS.Name = "rtbJS";
            this.rtbJS.Size = new System.Drawing.Size(535, 446);
            this.rtbJS.TabIndex = 34;
            this.rtbJS.Text = "function getChapterNum(dirname, filename) {\n    // Manga chap 1\\ ===> 1\n    vals " +
    "= dirname.split(\' \')\n    return vals[vals.length-1];\n}";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 726);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rtbJS);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.btnSourceDir);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnTargerDir);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblPath);
            this.tabPage1.Controls.Add(this.lblTarget);
            this.tabPage1.Controls.Add(this.cbSubfolders);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 693);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1) Folders\\Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpRTL);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 693);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2) Print style";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(554, 693);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3) Start!";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::MangaSplitter.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(18, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Made by yonixw, Version 1, Url of source:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(140, 267);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(288, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/yonixw/MangaSplitter";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 726);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangaSplitter GUI";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpRTL.ResumeLayout(false);
            this.grpRTL.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSourceDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog diagFolder;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnTargerDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radBooklet;
        private System.Windows.Forms.TextBox lblPath;
        private System.Windows.Forms.TextBox lblTarget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSubfolders;
        private System.Windows.Forms.RadioButton radRTL;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpRTL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbJS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}