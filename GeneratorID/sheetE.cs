using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace GeneratorID
{
    internal class sheetE
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;


        public sheetE(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = (Worksheet)wb.Worksheets[Sheet];

        }
        public string[,] ReadCells(int starti, int starty, int endi, int endy, bool manualcount = false, int manualrowpoz = 5)
        {
            if (manualcount == false)
            {
                int rowCount = ws.UsedRange.Rows.Count;
                endi = rowCount - manualrowpoz;
            }
            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];

            object[,] holder = range.Value2;
            string[,] returnstring = new string[endi - starti + 1, endy - starty + 1];
            for (int p = 1; p <= endi - starti + 1; p++)
            {
                for (int q = 1; q <= endy - starty + 1; q++)
                {
                    if (holder[p, q] != null)
                    {
                        returnstring[p - 1, q - 1] = holder[p, q].ToString(); ;
                    }
                    else
                    {
                        returnstring[p - 1, q - 1] = "BRAK";
                    }
                }
            }

            return returnstring;


        }
    }
}
