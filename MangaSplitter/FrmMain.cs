using System;

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;

using MangaAlgoV1;
using MangaAlgoV1.Tools;

namespace MangaSplitter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        // Todo:
        
        // Run pdf making in this folder. //  "magick *.jpg c0<chapteR>.pdf"
        // Check before for inehrit problems and abort
        //      --> If odd numbers between double, fix it somehow

        // Add modes: One booklet from all chapters, little booklet per chapter

        private void button1_Click(object sender, EventArgs e)
        {
            if (diagFolder.ShowDialog() == DialogResult.OK) {
                lblPath.Text = (new FileInfo(diagFolder.FileName)).DirectoryName;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (diagFolder.ShowDialog() == DialogResult.OK)
            {
                lblTarget.Text = (new FileInfo(diagFolder.FileName)).DirectoryName;
            }
        }


       
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("[Background Thread] START");
            try
            {
                MainAlgo algo = new MainAlgo(e.Argument as MainAlgoConfig);
                algo.StartSplitting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            }
        }
        
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("[Background Thread] All done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync(new MainAlgoConfig()
            {
                Booklet = radBooklet.Checked,
                rtl = radRTL.Checked,
                doublePageMinWidthPx = (int)numericUpDown1.Value,
                sourchDirPath = lblPath.Text,
                targetDirPath = lblTarget.Text,
                sourceSubdirsInclude = cbSubfolders.Checked,
                jsCodeHelper = rtbJS.Text
            });
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //using (ScriptEngine engine = new ScriptEngine(Tools.ScriptEngine.JavaScriptLanguage))
            //{
            //    ParsedScript parsed = engine.Parse("function MyFunc(x){return 1+2+x}");
            //    MessageBox.Show(parsed.CallMethod("MyFunc", 3).ToString());
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }


        // Covert to PDF: "C:\Program Files\ImageMagick-7.0.2-Q16\magick.exe" *.jpg 1.pdf



    }
}
