using MangaSplitter.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace MangaSplitter
{
    class MainAlgo
    {
        Config conf = null;
        DirectoryInfo diSourceFolder,diTargetFolder;
        Tools.ParsedScript helpScript;

        public MainAlgo(Config algoConfig)
        {
            conf = algoConfig;
            diSourceFolder = new DirectoryInfo(conf.sourchDirPath);
            diTargetFolder = new DirectoryInfo(conf.targetDirPath);

            using (ScriptEngine engine = new ScriptEngine(ScriptEngine.JavaScriptLanguage))
            {
                helpScript =
                    engine.Parse(conf.jsCodeHelper);
            }
        }

        // ----------------------------------
        //          Help Functions
        // -----------------------------------


        string standardName(string chapter, string page)
        {
            // <c>,<p> ===> c<c>_p<p>.jpg
            return "c" + chapter + "_p" + page + ".jpg";
        }

        string getPageFileStandardName(string filename, string chapter)
        {
            //<chapter>,<preparePageName()> ===> c<c>_p<p>.jpg
            return "c" + chapter + "_" + filename;
        }

        string strZeros(string numText, int zeroCount)
        {
            string result = "";
            for (int i = zeroCount; i > 0; i--)
            {
                result += "0";
            }
            return
                string.Format("{0:" + result + "}", (int)(float.Parse(numText) * 100/* ex: 81.5 */));
        }

        // ----------------------------------
        //          JS HELP Functions
        // -----------------------------------

        string getRawChapterName(string dirname, string filename)
        {
            //<filename>,<dirname> ??? ==> "75"
            return helpScript.CallMethod("getChapterNum",dirname, filename).ToString();
        }

        // ----------------------------------
        //          Image HELP Functions
        // -----------------------------------

        //This function checks the room size and your text and appropriate font for your text to fit in room
        //PreferedFont is the Font that you wish to apply
        //Room is your space in which your text should be in.
        //LongString is the string which it's bounds is more than room bounds.
        private Font FindFontSizeByContent(System.Drawing.Graphics g, string longString, Size Room, Font PreferedFont)
        {
            //you should perform some scale functions!!!
            SizeF RealSize = g.MeasureString(longString, PreferedFont);
            float HeightScaleRatio = Room.Height / RealSize.Height;
            float WidthScaleRatio = Room.Width / RealSize.Width;
            float ScaleRatio = (HeightScaleRatio < WidthScaleRatio) ? ScaleRatio = HeightScaleRatio : ScaleRatio = WidthScaleRatio;
            float ScaleFontSize = PreferedFont.Size * ScaleRatio;
            return new Font(PreferedFont.FontFamily, ScaleFontSize);
        }

        void createPage(string name, int height = 943, int width = 728, string drawText = "Chapter XXX")
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(b);
            g.DrawRectangle(Pens.White, new Rectangle(0, 0, width, height));

            Font textFont = FindFontSizeByContent(g, drawText, b.Size, new Font(new FontFamily("Arial"), 5));
            g.DrawString(drawText, textFont, Brushes.Black, 0, height / 2);

            //   File.WriteAllText(Path.Combine(ditarget.FullName , name), "TEST");
            b.Save(Path.Combine(diTargetFolder.FullName, name));
        }


        // ----------------------------------
        //          Algo Functions
        // -----------------------------------

        
        void PrepareFolder(DirectoryInfo di)
        {
            // Change names and add inbetween to make sure doubles are in their places
            int cutoff = conf.doublePageMinWidthPx;

            // Chane name for numerical order (no more 20 befor 3 because 2 before 3)
            // We do it by adding correct numbers of zeros

            Console.WriteLine("Adding zeros to files in folder:" + di.Name);
            int pageCounter = 1;
            foreach (FileInfo fi in di.GetFiles("*.jpg"))
            {
                string newFile = Path.Combine(fi.Directory.FullName,
                    "p" + strZeros(pageCounter.ToString(),6) + ".jpg");
                if (newFile != fi.FullName)
                    fi.MoveTo(newFile);

                pageCounter++;
            }

            // Validate even pages between double pages
            int counterFromLastDouble = 1; // We count the opening page
            FileInfo[] allFiles = di.GetFiles("*.jpg"); // Get files again after moving.


            if (allFiles.Length > 0)
            {
                FileInfo lastfile = allFiles[0];

                foreach (FileInfo fi in di.GetFiles())
                {
                    using (Bitmap bmp = (Bitmap)Bitmap.FromFile(fi.FullName))
                    {
                        if (bmp.Width > cutoff)
                        {
                            if (counterFromLastDouble % 2 == 1)
                            {
                                Console.WriteLine("Fixing problem: found " + counterFromLastDouble + " pages from last double (odd) until " + fi.FullName);

                                // Fix it by adding new page:
                                createPage(lastfile.FullName.Replace(".jpg", "_0.beforeDouble.jpg"), drawText: "BEFORE\nDOUBLE PAGE");

                                counterFromLastDouble = 0;
                            }
                        }
                        else
                        {
                            counterFromLastDouble++;
                        }
                    }
                    lastfile = fi;
                }
            }

            // Child Folders
            if (conf.sourceSubdirsInclude)
            {
                foreach (DirectoryInfo subdi in di.GetDirectories())
                {
                    PrepareFolder(subdi);
                } 
            }
        }

        public void CopyFolder(DirectoryInfo di)
        {
            int cutoff = conf.doublePageMinWidthPx;
            Console.WriteLine("Directory: " + di.FullName);

            int pageCounter = 1; // Start from one. after intro page
            bool firstDouble = true; // First double page in chapter
            bool addBefore = false; // Add blank page before chapter intro page
            bool addAfter = false; // Add blank pae after chapter
            bool foundJPG = false; // Did we find anything?

            string currentChapter = "";

            foreach (FileInfo sourceFi in di.GetFiles("*.jpg"))
            {
                foundJPG = true;
                pageCounter++;

                Console.Write("\t (" + pageCounter + ") File: " + sourceFi.Name + "...");

                // Set chapter:
                if (currentChapter == "")
                {
                    currentChapter = strZeros(getRawChapterName(sourceFi.Directory.Name, sourceFi.Name), 6);
                    // <prefix>c001_p001.png

                }

                string newFullName = Path.Combine(
                    sourceFi.Directory.FullName,
                    getPageFileStandardName(sourceFi.Name, currentChapter)
                );

                string newSavePath = newFullName.Replace(di.FullName, diTargetFolder.FullName);

                // Move to dest
                FileInfo targetFi = sourceFi.CopyTo(newSavePath);

                // From now on  fi.fullname is the new short name in target folder

                try
                {
                    using (Bitmap bmp = (Bitmap)Bitmap.FromFile(targetFi.FullName))
                    {
                        if (bmp.Width > cutoff)
                        {
                            if (firstDouble)
                            {
                                firstDouble = false;

                                if (pageCounter % 2 == 0)
                                {
                                    addBefore = true;
                                }
                            }

                            Console.WriteLine("Split!");

                            string leftPrefix =  (conf.rtl) ? "_2Left"  : "_1Left";
                            string rightPrefix = (conf.rtl) ? "_1Right" : "_2Right";

                            // Left Side:
                            Console.Write("Left Side...");
                            using (Bitmap left = new Bitmap(bmp.Width / 2, bmp.Height))
                            {
                                using (Graphics gLeft = Graphics.FromImage(left))
                                {
                                    Rectangle leftSize = new Rectangle(0, 0, left.Width, left.Height);
                                    // Where left is in the original pictue:
                                    Rectangle leftPosition = new Rectangle(0, 0, left.Width, left.Height);
                                    gLeft.DrawImage(bmp, leftSize, leftPosition, GraphicsUnit.Pixel);
                                    left.Save(targetFi.FullName.Replace(".jpg", leftPrefix + ".jpg"), ImageFormat.Jpeg);
                                }
                            }

                            pageCounter++;

                            //Right Side:
                            Console.Write("Right Side...");
                            using (Bitmap right = new Bitmap(bmp.Width / 2, bmp.Height))
                            {
                                using (Graphics gRight = Graphics.FromImage(right))
                                {
                                    Rectangle rightSize = new Rectangle(0, 0, right.Width, right.Height);
                                    // Where left is in the original pictue:
                                    Rectangle rightPosition = new Rectangle(bmp.Width - right.Width, 0, right.Width, right.Height);
                                    gRight.DrawImage(bmp, rightSize, rightPosition, GraphicsUnit.Pixel);
                                    right.Save(targetFi.FullName.Replace(".jpg", rightPrefix + ".jpg"), ImageFormat.Jpeg);
                                }
                            }

                            Console.WriteLine("Delete double original...");
                            targetFi.Delete(); 
                        }
                        else
                        {
                            Console.WriteLine("Normal!");
                        }
                    }

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
                createPage(standardName(currentChapter, strZeros("0",6)), drawText: "Chapter: " + currentChapter);

                if (pageCounter % 2 == 1)
                {
                    addAfter = true;
                }

                string spage = pageCounter.ToString();
                if (addBefore)
                {
                    Console.WriteLine("Adding blank before!");
                    createPage(standardName(currentChapter, strZeros(spage, 6) + ".before"), drawText: "Blank before: " + currentChapter);
                }
                if (addAfter)
                {
                    Console.WriteLine("Adding blank after!");
                    createPage(standardName(currentChapter, strZeros(spage, 6) + ".after"), drawText: "Blank After: " + currentChapter);
                }
            }

            // Child Folders
            if (conf.sourceSubdirsInclude)
            {
                foreach (DirectoryInfo subdi in di.GetDirectories())
                {
                    CopyFolder(subdi);
                }
            }

        }


        public void StartSplitting()
        {
            Console.WriteLine("Target Directory: " + diTargetFolder.FullName);
            Console.WriteLine("Cutoff width: " + conf.doublePageMinWidthPx);

            PrepareFolder(diSourceFolder);
            CopyFolder(diSourceFolder);

            if (conf.Booklet)
            {
                Console.WriteLine("Creating booklet open\\close pages...");
            }
            else
            {
                Console.WriteLine("Creating duplex open\\close pages...");
                createPage(standardName(strZeros("0", 6), strZeros("1", 6)), drawText: "BLANK\nFOR\nDUPLEX\nDATE:" + DateTime.Now.ToLongDateString());
            }

            createPage(standardName(strZeros("0",6), strZeros("0", 6)), 
                drawText: 
                    "START OF MANGA\n" +
                    "DATE: " + DateTime.Now.ToLongDateString() + "\n" +
                    "Binding: " + ((conf.Booklet) ? "Booklet" : "Duplex") + "\n" +
                    "Direction: " + ((conf.rtl) ? "Right to left" : "Left to right") + "\n"
                );
            createPage(standardName("ZZZZZZ", "ZZZZZZ"), drawText: "END OF MANGA\nDATE:" + DateTime.Now.ToLongDateString());
        }
    }
}
