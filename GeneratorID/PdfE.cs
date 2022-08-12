using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.Drawing;
//need PdfSharpCore


namespace GeneratorID
{
    internal class PdfE
    {
        public void Render(string savepath)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Id's";
            var pathes = Directory.GetFiles(@"C:\PamilProgramFiles\IDgen\Data\", "*.jpeg");
            foreach (string fileSpec in pathes)
            {
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                DrawImage(gfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);
            }
            if (document.PageCount > 0) document.Save(savepath);
            
        }
        private void DrawImage(XGraphics gfx, string fileSpec, int v1, int v2, int width, int height)
        {
            XImage img = XImage.FromFile(fileSpec);
            gfx.DrawImage(img, v1, v2, width, height);
        }

        public void ClearFiles()
        {
            try { Directory.Delete(@"C:\PamilProgramFiles\IDgen\Data\", true); } 
            catch { };
        }
    }
}