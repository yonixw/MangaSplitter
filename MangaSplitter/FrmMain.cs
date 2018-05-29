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
using MangaSplitter.Tools;

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


        DirectoryInfo ditarget;
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ditarget = new DirectoryInfo(lblTarget.Text);
            Console.WriteLine("Target Directory: " + ditarget.FullName);
            Console.WriteLine("Cutoff width: " + numericUpDown1.Value);

            //if (Validate(new DirectoryInfo(lblPath.Text)))
            //{
            //    Folder(new DirectoryInfo(lblPath.Text));
            //}

            Prepare(new DirectoryInfo(lblPath.Text));
            Folder(new DirectoryInfo(lblPath.Text));


            Console.WriteLine("Creating booklet open\\close pages...");

            createPage(makeName("00000000000000","0"), drawText: "START OF MANGA\nDATE:" + DateTime.Now.ToLongDateString());
            createPage(makeName("ZZZZZZZZZZZZZZ","Z"), drawText: "END OF MANGA\nDATE:" + DateTime.Now.ToLongDateString());

          
        }
        
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("[Background Thread] All done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //using (ScriptEngine engine = new ScriptEngine(Tools.ScriptEngine.JavaScriptLanguage))
            //{
            //    ParsedScript parsed = engine.Parse("function MyFunc(x){return 1+2+x}");
            //    MessageBox.Show(parsed.CallMethod("MyFunc", 3).ToString());
            //}
        }


        /************************
           Manga website based
        ************************/

        // Covert to PDF: "C:\Program Files\ImageMagick-7.0.2-Q16\magick.exe" *.jpg 1.pdf

        // Yo want every page to be in c<chapter>_p<page>.jpg format

        string makeName(string chapter, string page) {
            return "c" + chapter + "_p" + page + ".jpg";
        }

        string prepareName(FileInfo file)
        {
            //string[] str = file.Name.Split('_');
            //int pageNumLength = str[str.Length - 1].Length - "p.jpg".Length;
            //return file.FullName.Replace("_p", "_p" + strZeros(pageNumLength));

            return Path.Combine(file.Directory.FullName, "p" + file.Name.Substring(1)); // ?001.jpg => p001.jpg
        }

        string getChpater(FileInfo file)
        {
            //return file.Name.Replace(MangaSplitter.Properties.Settings.Default.ImagesPrefix, "").Substring(1).Split('_')[0]; 

            string[] dirParms = file.Directory.Name.Split(' ');
            return dirParms[dirParms.Length - 1];
        }

        string newPageName(FileInfo file, string chapter)
        {
            //return file.Name.Replace(MangaSplitter.Properties.Settings.Default.ImagesPrefix, "");

            return  "c" + chapter + "_" + file.Name ;
        }
        
        /************************
            MAIN    ALGORITHM
         ************************/

        string strZeros(string numText, int zeroCount)
        {
            string result = "";
            for (int i = zeroCount; i > 0; i--)
            {
                result += "0";
            }
            return 
                string.Format("{0:" + result + "}", int.Parse(numText));
        }

        //This function checks the room size and your text and appropriate font for your text to fit in room
        //PreferedFont is the Font that you wish to apply
        //Room is your space in which your text should be in.
        //LongString is the string which it's bounds is more than room bounds.
        private Font FindFont(System.Drawing.Graphics g, string longString, Size Room, Font PreferedFont)
        {
            //you should perform some scale functions!!!
            SizeF RealSize = g.MeasureString(longString, PreferedFont);
            float HeightScaleRatio = Room.Height / RealSize.Height;
            float WidthScaleRatio = Room.Width / RealSize.Width;
            float ScaleRatio = (HeightScaleRatio < WidthScaleRatio) ? ScaleRatio = HeightScaleRatio : ScaleRatio = WidthScaleRatio;
            float ScaleFontSize = PreferedFont.Size * ScaleRatio;
            return new Font(PreferedFont.FontFamily, ScaleFontSize);
        }


        void createPage(string name, int height = 943, int width = 728, string drawText = "Chapter XXX") {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(b);
            g.DrawRectangle(Pens.White, new Rectangle(0, 0, width, height));

            Font textFont = FindFont(g, drawText, b.Size, new Font(new FontFamily("Arial"), 5));
            g.DrawString(drawText, textFont, Brushes.Black,0, height / 2);

            //   File.WriteAllText(Path.Combine(ditarget.FullName , name), "TEST");
            b.Save(Path.Combine(ditarget.FullName, name));
        }


        private bool Prepare(DirectoryInfo di) 
        {
            int cutoff = (int)numericUpDown1.Value;
            bool Valid = true;


            // Chane name for numerical order (no more 20 befor 3 because 2 before 3)
            // We do it by adding correct numbers of zeros

            Console.WriteLine("Adding zeros to files in folder:" + di.Name);
            foreach (FileInfo fi in di.GetFiles()) {
                if (fi.Extension != ".jpg")
                    continue;

                fi.MoveTo(prepareName(fi));
            }

            // Validate even pages between double pages
            // If they are not in name order, somthing wen wrong!
            bool firstDouble = true;
            int counterFromLastDouble = 1; // We count the opening page
            FileInfo[] allFiles = di.GetFiles();


            if (allFiles.Length > 0)
            {
                FileInfo lastfile = allFiles[0];
 
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Extension != ".jpg")
                        continue;

                    using (Bitmap bmp = (Bitmap)Bitmap.FromFile(fi.FullName))
                    {
                        if (bmp.Width > cutoff)
                        {
                            //if (firstDouble)
                            //{
                            //    firstDouble = false; 
                            //    // NOOO: Until it we dont care 
                            //    //      --> We do, first page is chapter opening
                            //    //      What if double come right after it?
                            //}
                            //else
                            //{
                                if (counterFromLastDouble % 2 == 1)
                                {
                                    Console.WriteLine("Valid problem: found " + counterFromLastDouble + " pages from last double until " + fi.FullName);
                                    Valid = false;

                                    // Fix it by adding new page:
                                    createPage(lastfile.FullName.Replace(".jpg", "_0.jpg"), drawText: "BEFORE\nDOUBLE");

                                    counterFromLastDouble = 0;
                                }
                            //}
                        }
                        else
                        {
                            //if (!firstDouble) counterFromLastDouble++;
                            counterFromLastDouble++;
                        }
                    }

                    lastfile = fi;
                } 
            }

            // Child Folders
            foreach (DirectoryInfo under in di.GetDirectories())
            {
                Valid = Valid & Prepare(under);
            }

            return Valid;
        }

        private void Folder(DirectoryInfo di)
        {
            int cutoff = (int)numericUpDown1.Value;
            Console.WriteLine("Directory: " + di.FullName);

            bool flagDouble = false;
            int pageCounter = 1; // Start from one. after intro page
            bool firstDouble = true; // First double page in chapter
            bool addBefore = false; // Add blank page before chapter intro page
            bool addAfter = false; // Add blank pae after chapter
            bool foundJPG = false; // Did we find anything?

            string currentChapter = "";

            foreach (FileInfo fi in di.GetFiles())
            {
                if (fi.Extension != ".jpg")
                    continue;

                foundJPG = true;
                pageCounter++;
                
                Console.Write("\t ("+ pageCounter +") File: " + fi.Name + "...");

                // Set chapter:
                if (currentChapter == "")
                {
                    currentChapter = strZeros(getChpater(fi),4);
                    // <prefix>c001_p001.png

                }

                string newFullName =  Path.Combine(
                    fi.Directory.FullName,
                    newPageName(fi,currentChapter)
                );

                string newSavePath = newFullName.Replace(di.FullName, ditarget.FullName);
                
                // Move to dest
                fi.MoveTo(newSavePath);

                // From now on  fi.fullname is the new short name in target folder

                try
                {
                    using (Bitmap bmp = (Bitmap)Bitmap.FromFile(fi.FullName))
                    {
                        if (bmp.Width > cutoff)
                        {
                            if (firstDouble) {
                                firstDouble = false;

                                if (pageCounter % 2 == 0)
                                {
                                    addBefore = true;
                                }
                            }

                            // Left Side:
                            Console.Write("Left...");
                            using (Bitmap left = new Bitmap(bmp.Width / 2, bmp.Height))
                            {
                                Graphics gLeft = Graphics.FromImage(left);
                                Rectangle leftSize = new Rectangle(0, 0, left.Width, left.Height);
                                // Where left is in the original pictue:
                                Rectangle leftPosition = new Rectangle(0, 0, left.Width, left.Height);
                                gLeft.DrawImage(bmp, leftSize, leftPosition, GraphicsUnit.Pixel);
                                left.Save(fi.FullName.Replace(".jpg", "_2Left.jpg"), ImageFormat.Jpeg);
                            }

                            pageCounter++;

                            //Right Side:
                            Console.Write("Right...");
                            using (Bitmap right = new Bitmap(bmp.Width / 2, bmp.Height))
                            {
                                Graphics gRight = Graphics.FromImage(right);
                                Rectangle rightSize = new Rectangle(0, 0, right.Width, right.Height);
                                // Where left is in the original pictue:
                                Rectangle rightPosition = new Rectangle(bmp.Width - right.Width, 0, right.Width, right.Height);
                                gRight.DrawImage(bmp, rightSize, rightPosition, GraphicsUnit.Pixel);
                                right.Save(fi.FullName.Replace(".jpg", "_1Right.jpg"), ImageFormat.Jpeg);
                            }

                            flagDouble = true;

                            Console.WriteLine("Split!");
                        }
                        else
                        {
                            Console.WriteLine("Normal!");
                        }
                    }
                    if (flagDouble)
                    {
                        Console.WriteLine("Delete...");
                        fi.Delete(); // Delete new file after copy?

                    }
                    flagDouble = false;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Message:\n" + ex.Message);
                    Console.WriteLine("Trace:\n" + ex.StackTrace);
                }
                
            }

            if (foundJPG)
            {
                Console.WriteLine("Adding Chapter page at start!");
                createPage(makeName(currentChapter, "0"),drawText: "Chapter: " + currentChapter);

                if (pageCounter % 2 == 1)
                {
                    addAfter = true;
                }

                string spage = pageCounter.ToString();
                if (addBefore)
                {
                    Console.WriteLine("Adding blank before!");
                    createPage(makeName(currentChapter, strZeros(spage, 3) + ".before"), drawText: "Blank before: " + currentChapter);
                }
                if (addAfter)
                {
                    Console.WriteLine("Adding blank after!");
                    createPage(makeName(currentChapter, strZeros(spage,3) + ".after"), drawText: "Blank After: " + currentChapter);
                } 
            }



            // Child Folders
            foreach (DirectoryInfo under in di.GetDirectories())
            {
                Folder(under);
            }


            

        }

    }
}
