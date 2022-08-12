using System.Runtime.InteropServices;

namespace GeneratorID
{
    public partial class Form1 : Form
    {
        //coding 
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();



        //end of coding
        int kolumnaI = 10;
        int kolumnaN = 8;
        int kolumnaG = 22;
        int pierwszyRekord = 2;
        int rekordscout = 1000;


        List<string[,]> dane = new List<string[,]>();

        string pathImage, pathFile;
        int radialButtonNr = 1;

        //Image 
        int imageTextMoveValue = 5;

        ImageE imgE = new ImageE();

        public Form1()
        {
            InitializeComponent();
            AllocConsole();
        }



      
        private void bGen_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != null && saveFileDialog1.FileName != "")
            {
                OpenFile();
            }
        }

        private void OpenFile()
        {
            sheetE excel = new sheetE(pathFile, 1);
            var imiona = excel.ReadCells(pierwszyRekord, kolumnaI, rekordscout, kolumnaI);//, checkBox1.Checked, int.Parse(textBox2.Text));
            var nazwiska = excel.ReadCells(pierwszyRekord, kolumnaN, rekordscout, kolumnaN);//, checkBox1.Checked, int.Parse(textBox2.Text));
            var grupa = excel.ReadCells(pierwszyRekord, kolumnaG, rekordscout, kolumnaG);// checkBox1.Checked, int.Parse(textBox2.Text));
            
            dane.Clear();
            for (int i = 0; i < grupa.Length; i++)
            {
                if (grupa[i, 0] != "BRAK")
                {
                    var daneLoc = new string[1, 3];
                    daneLoc[0, 0] = imiona[i, 0];
                    daneLoc[0, 1] = nazwiska[i, 0];
                    daneLoc[0, 2] = grupa[i, 0];
                    
                    dane.Add(daneLoc);
                }
            }
        }

        private void rBSelect(object sender, EventArgs e)
        {
            int index_local = (sender as RadioButton).TabIndex - 7;
            radialButtonNr = index_local;
        } // radial button f(), changing value

        private void bArrowClck(object sender, EventArgs e)
        {


            switch ((sender as Button).Name)
            {
                case "bDragPointU":
                    if (radialButtonNr == 1)
                        imgE.PointName = new Point(imgE.PointName.X, imgE.PointName.Y - imageTextMoveValue);
                    else if (radialButtonNr == 2)
                        imgE.PointSecondName = new Point(imgE.PointSecondName.X, imgE.PointSecondName.Y - imageTextMoveValue);
                    else if (radialButtonNr == 3)
                        imgE.PointClass = new Point(imgE.PointClass.X, imgE.PointClass.Y - imageTextMoveValue);
                    break;
                case "bDragPointD":
                    if (radialButtonNr == 1)
                        imgE.PointName = new Point(imgE.PointName.X, imgE.PointName.Y + imageTextMoveValue);
                    else if (radialButtonNr == 2)
                        imgE.PointSecondName = new Point(imgE.PointSecondName.X, imgE.PointSecondName.Y + imageTextMoveValue);
                    else if (radialButtonNr == 3)
                        imgE.PointClass = new Point(imgE.PointClass.X, imgE.PointClass.Y + imageTextMoveValue);
                    break;
                case "bDragPointL":
                    if (radialButtonNr == 1)
                        imgE.PointName = new Point(imgE.PointName.X + imageTextMoveValue, imgE.PointName.Y);
                    else if (radialButtonNr == 2)
                        imgE.PointSecondName = new Point(imgE.PointSecondName.X + imageTextMoveValue, imgE.PointSecondName.Y);
                    else if (radialButtonNr == 3)
                        imgE.PointClass = new Point(imgE.PointClass.X + imageTextMoveValue, imgE.PointClass.Y);
                    break;
                case "bDragPointR":
                    if (radialButtonNr == 1)
                        imgE.PointName = new Point(imgE.PointName.X - imageTextMoveValue, imgE.PointName.Y);
                    else if (radialButtonNr == 2)
                        imgE.PointSecondName = new Point(imgE.PointSecondName.X - imageTextMoveValue, imgE.PointSecondName.Y);
                    else if (radialButtonNr == 3)
                        imgE.PointClass = new Point(imgE.PointClass.X - imageTextMoveValue, imgE.PointClass.Y);
                    break;

            }
            
            pictureBox1.Image = imgE.GenID(Image.FromFile(pathImage));
        }

        private void bImportBase_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != null && openFileDialog1.FileName != "")
            {
                pathFile = openFileDialog1.FileName;

                bImportTemplate.Enabled = true;
            }
        }
        private void bImportTemplate_Click(object sender, EventArgs e) // Import Image
        {
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName != null && openFileDialog2.FileName != "")
            {
                pathImage = openFileDialog2.FileName;
                bGen.Enabled = true;
                pictureBox1.Image = imgE.GenID(Image.FromFile(pathImage));
            }
        }
    }
}