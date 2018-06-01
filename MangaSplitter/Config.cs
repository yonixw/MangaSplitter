using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaSplitter
{
    class Config
    {
        public string sourchDirPath = "";
        public bool sourceSubdirsInclude = false;
        public string targetDirPath = "";

        public int doublePageMinWidthPx = 900;

        public bool rtl = true;
        public bool Booklet = true;

        public string jsCodeHelper = "";
    }
}
