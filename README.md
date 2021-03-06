# This project is replaced with MangaPrinter here:[Link](https://github.com/yonixw/MangaPrinter)

# =============================
# =======  ARCHIVE:============
# =============================
# MangaSplitter
Reorder and split manga images to the target binding.

Please note that out method only cut printing by half because 2-side printing still cost for each side and not by papers used (in most print outlets)

## Version 1
- Changes image source files
- Split double pages --> Little space in the middle when printing (called gutter)
- Does not make pdf at the end
- Booklet does not have split option

Version 1 screenshot :

![Print screen](https://raw.githubusercontent.com/yonixw/MangaSplitter/master/printscreen.png "Print screen")

You can use the dll of the algorithm with your own program. Example:

```javascript
 MainAlgo algo = new MainAlgo(new MainAlgoConfig()
                {
                    Booklet = radBooklet.Checked,
                    rtl = radRTL.Checked,
                    doublePageMinWidthPx = (int)numericUpDown1.Value,
                    sourchDirPath = lblPath.Text,
                    targetDirPath = lblTarget.Text,
                    sourceSubdirsInclude = cbSubfolders.Checked,
                    jsCodeHelper = rtbJS.Text
                });
                algo.StartSplitting();

```

## Version 2 (In the future)
- More robust algorithm (not odd\even but some OO)
- Double pages stay together (single are joined)
- Make pdf on the go with some opensource library and don't change source files
- Let user inspect result in some form of a GUI
- Let user split booklet (meaning we calculate booklet and not printer)
- Add page numbers and border and direction arrow
	- We need to make landscape templates (single, double) and embed zoomed pages in them
- Portable software to resume printing from certain page without messing double pages







