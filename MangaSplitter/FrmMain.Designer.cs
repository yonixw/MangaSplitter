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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSubfolders = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radRTL = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.grpRTL = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbJS = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpRTL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(852, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "3) Cut manga!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(708, 8);
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
            this.label2.Location = new System.Drawing.Point(531, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Single page max width:";
            // 
            // btnSourceDir
            // 
            this.btnSourceDir.Location = new System.Drawing.Point(398, 35);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Source Directory: [-s]";
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
            this.btnTargerDir.Location = new System.Drawing.Point(397, 91);
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
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose Target Directory: [-t]";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(227, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 24);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Duplex [-d]";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radBooklet
            // 
            this.radBooklet.AutoSize = true;
            this.radBooklet.Location = new System.Drawing.Point(112, 25);
            this.radBooklet.Name = "radBooklet";
            this.radBooklet.Size = new System.Drawing.Size(107, 24);
            this.radBooklet.TabIndex = 19;
            this.radBooklet.Text = "Booklet [-b]";
            this.radBooklet.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(12, 38);
            this.lblPath.Name = "lblPath";
            this.lblPath.ReadOnly = true;
            this.lblPath.Size = new System.Drawing.Size(380, 26);
            this.lblPath.TabIndex = 20;
            // 
            // lblTarget
            // 
            this.lblTarget.Location = new System.Drawing.Point(12, 95);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.ReadOnly = true;
            this.lblTarget.Size = new System.Drawing.Size(380, 26);
            this.lblTarget.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "(px) [-p]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::MangaSplitter.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(50, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cbSubfolders
            // 
            this.cbSubfolders.AutoSize = true;
            this.cbSubfolders.Location = new System.Drawing.Point(242, 8);
            this.cbSubfolders.Name = "cbSubfolders";
            this.cbSubfolders.Size = new System.Drawing.Size(134, 24);
            this.cbSubfolders.TabIndex = 23;
            this.cbSubfolders.Text = "Subfolders [-R]";
            this.cbSubfolders.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(531, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 80);
            this.label6.TabIndex = 24;
            this.label6.Text = "Printing settings examples:\r\n- Fit to page.\r\n- Printer options only\r\nTODO Both rt" +
    "l and edge direction";
            // 
            // radRTL
            // 
            this.radRTL.AutoSize = true;
            this.radRTL.Checked = true;
            this.radRTL.Location = new System.Drawing.Point(117, 29);
            this.radRTL.Name = "radRTL";
            this.radRTL.Size = new System.Drawing.Size(87, 24);
            this.radRTL.TabIndex = 27;
            this.radRTL.TabStop = true;
            this.radRTL.Text = "RTL [-rtl]";
            this.radRTL.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(261, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(87, 24);
            this.radioButton4.TabIndex = 28;
            this.radioButton4.Text = "LTR [-ltr]";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(13, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Choose JS helper file: [-js]";
            // 
            // grpRTL
            // 
            this.grpRTL.Controls.Add(this.radRTL);
            this.grpRTL.Controls.Add(this.radioButton4);
            this.grpRTL.Location = new System.Drawing.Point(535, 56);
            this.grpRTL.Name = "grpRTL";
            this.grpRTL.Size = new System.Drawing.Size(401, 65);
            this.grpRTL.TabIndex = 32;
            this.grpRTL.TabStop = false;
            this.grpRTL.Text = "(R)ight-(T)o-(L)eft Binding?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radBooklet);
            this.groupBox1.Location = new System.Drawing.Point(535, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 65);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printing type?";
            // 
            // rtbJS
            // 
            this.rtbJS.Location = new System.Drawing.Point(16, 173);
            this.rtbJS.Name = "rtbJS";
            this.rtbJS.Size = new System.Drawing.Size(489, 122);
            this.rtbJS.TabIndex = 34;
            this.rtbJS.Text = resources.GetString("rtbJS.Text");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 730);
            this.Controls.Add(this.rtbJS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRTL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSubfolders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTargerDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSourceDir);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangaSplitter GUI";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpRTL.ResumeLayout(false);
            this.grpRTL.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radRTL;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpRTL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbJS;
    }
}