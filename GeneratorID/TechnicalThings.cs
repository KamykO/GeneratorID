using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeneratorID
{
    internal class TechnicalThings
    {
        // Hellooooooooooo, this is class with maaaany technical things

        public int ReportBug(Exception exception)
        {
            try
            {
                string path = @"C:\PamilProgramFiles\IDgen\Reports";
                File.WriteAllTextAsync(path, System.DateTime.Now.ToString() + ": " + exception.ToString());
                return 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd w zgłaszaniu błędów ;) Błąd wystąpiony:" + exception.ToString());
                return 0;

            }


        }

        public void ClearRam()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

    }
}
