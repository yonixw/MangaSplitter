using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MangaSplitter
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new FrmMain()); 
        }
    }
}
