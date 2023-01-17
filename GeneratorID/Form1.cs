using System.Runtime.InteropServices;

namespace GeneratorID
{
    public partial class Form1 : Form
    {
        //coding 
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        TechnicalThings tt = new TechnicalThings();


        //end of coding
        int kolumnaI = 10;
        int kolumnaN = 8;
        int kolumnaG = 22;
        int pierwszyRekord = 2;
        int rekordscout = 1000;

        #region Things
        // Database of Things
        void AddAllControlsToLists()
        {
            ListofmanualAdd();
            ListofmanualExcelAdd();
            listofDEVAdd();
        }
        void ChangeStateOfConteols(List<Control> lisst)
        {
            foreach (object o in lisst)
            {
                if ((o as Control).Visible == true)
                    (o as Control).Visible = false;
                else
                    (o as Control).Visible = true;
            }
            
        }

        List<Control> listofmanual = new List<Control>();
        private void ListofmanualAdd()
        {
            listofmanual.Add(label1);
            listofmanual.Add(label3);
            listofmanual.Add(label4);
            listofmanual.Add(bAddMember);
            //listofmanual.Add(bDelMember);
            listofmanual.Add(listBDaneManual);
            listofmanual.Add(tbName);
            listofmanual.Add(tbSCN);
            listofmanual.Add(tbGR);
        }
        List<Control> listofmanualExcel = new List<Control>();
        private void ListofmanualExcelAdd()
        {

            listofmanualExcel.Add(labelColumnChangeName);
            listofmanualExcel.Add(labelColumnChangeSName);
            listofmanualExcel.Add(labelColumnChangeGr);
            listofmanualExcel.Add(labelRowChangeAll);
            listofmanualExcel.Add(labelRowChangeLast);
            listofmanualExcel.Add(cbNameColumn);
            listofmanualExcel.Add(cbSNameColumn);
            listofmanualExcel.Add(cbGrColumn);
            listofmanualExcel.Add(tbFirstRecord);
            listofmanualExcel.Add(tbLastRecord);
           

        }
        List<Control> listofDEV = new List<Control>();
        private void listofDEVAdd()
        {
            listofDEV.Add(DEVl1);
            listofDEV.Add(DEVl2);
            listofDEV.Add(DEVl3);
            listofDEV.Add(DEVl4);
            listofDEV.Add(DEVl5);
            listofDEV.Add(DEVtbIDH);
            listofDEV.Add(DEVtbIDn);
            listofDEV.Add(DEVtbwsH);
            listofDEV.Add(DEVtbwsW);
            listofDEV.Add(DEVtbwidth);
            listofDEV.Add(DEVbtAC);
            listofDEV.Add(DEVl6);
        }
        #endregion



        List<string[,]> dane = new List<string[,]>();
        List<string[,]> daneManual = new List<string[,]>();

        string pathImage, pathFile;
        int radialButtonNr = 1;

        //Image 
        int imageTextMoveValue = 5;

        ImageE imgE = new ImageE();

        public Form1()
        {
            InitializeComponent();
            //AllocConsole();
            Directory.CreateDirectory(@"C:\PamilProgramFiles\IDgen\Data\");
            Directory.CreateDirectory(@"C:\PamilProgramFiles\IDgen\Report\");
            AddAllControlsToLists();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InfoScr scr = new InfoScr();
            scr.Show();
            scr.TopMost = true;
        }


        private async void bGen_Click(object sender, EventArgs e)
        {
            imgE.ClearFiles();

            

            //try // <3
            //{
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != null && saveFileDialog1.FileName != "")
            {
                progressgenerationBar1.Value = 5;
                bGen.Text = "Generowanie";
                OpenFile();
                progressgenerationBar1.Value = 10;
                PdfE pdfE = new PdfE();
                foreach (var o in dane) // generowanie osobnych identyfikatorów z danymi
                {
                    imgE.LinkIDonA4(imgE.GenID(Image.FromFile(pathImage), o[0, 0].ToString(), o[0, 1].ToString(), o[0, 2].ToString()));

                }
                progressgenerationBar1.Value = 60;
                pdfE.Render(saveFileDialog1.FileName);//generowanie PDF

                tt.ClearRam();
                progressgenerationBar1.Value = 100;
                bGen.Text = "Generuj";
            }
            /* }

             catch (Exception ex)
             {
                 tt.ReportBug(ex);
             }
             */
            /*


            -Generowanie pdf z po³¹czonych ze sob¹ wygenerowanych zdjêæ
            */
        }

        private void OpenFile()
        {
            if (chBxManualAdd.Checked == false)
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
            else
            {
                foreach (string[,] n in daneManual)
                {
                    dane.Add(n);
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

            PictrueBox1Ref();
            tt.ClearRam();
        }

        private void PictrueBox1Ref()
        {
            pictureBox1.Image = imgE.GenID(Image.FromFile(pathImage));
        }

        private void bImportBase_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Database: Import Button");
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != null && openFileDialog1.FileName != "")
            {
                pathFile = openFileDialog1.FileName;

                bImportTemplate.Enabled = true;
                Console.WriteLine("Database: Impored");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialogName.Font = imgE.FontName;
            fontDialogName.ShowDialog();
            if (!fontDialogName.FontMustExist)
            {
                imgE.FontName = fontDialogName.Font;
            }
            PictrueBox1Ref();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fontDialogSCName.Font = imgE.FontSecondName;
            fontDialogSCName.ShowDialog();

            if (!fontDialogSCName.FontMustExist)
            {
                imgE.FontSecondName = fontDialogSCName.Font;
            }
            PictrueBox1Ref();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            fontDialogClass.Font = imgE.FontClas;
            fontDialogClass.ShowDialog();
            if (!fontDialogClass.FontMustExist)
            {
                imgE.FontClas = fontDialogClass.Font;
            }
            PictrueBox1Ref();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = @"Settings icon by https://icons8.com";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bAddMember_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbSCN.Text != "" && tbGR.Text != "")
            {
                var daneLoc = new string[1, 3];
                daneLoc[0, 0] = tbName.Text;
                daneLoc[0, 1] = tbSCN.Text;
                daneLoc[0, 2] = tbGR.Text;
                daneManual.Add(daneLoc);

                listBDaneManual.Items.Add((daneLoc[0, 0] + " " + daneLoc[0, 1] + " " + daneLoc[0, 2]).ToString());
                tbName.Text = "";
                tbSCN.Text = "";
                tbGR.Text = "";
            }

        }

        private void bDelMember_Click(object sender, EventArgs e)
        {
            if (listBDaneManual.SelectedItems.Count > 0) //tak
            {
                //daneManual.Remove()
                listBDaneManual.Items.Remove(listBDaneManual.SelectedIndex);
            } // TODO
        }

        private void chBxManualAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (DEVtbwsW.Visible == true)
            {
                ChangeStateOfConteols(listofDEV);
            }

            ChangeStateOfConteols(listofmanual);
            bImportBase.Enabled = !chBxManualAdd.Checked;
            if(chBxManualAdd.Checked)
                cbmanualExcel.Checked = !chBxManualAdd.Checked;
            cbmanualExcel.Enabled = !chBxManualAdd.Checked;
            bImportTemplate.Enabled = true;

        }
        private void cbCoolumnchange(object sender, EventArgs e)
        {
            try
            {
                if (sender == cbNameColumn)
                    kolumnaI = (sender as ComboBox).SelectedIndex + 1;
                else if (sender == cbSNameColumn)
                    kolumnaN = (sender as ComboBox).SelectedIndex + 1;
                else if (sender == cbGrColumn)
                    kolumnaG = (sender as ComboBox).SelectedIndex + 1;
                else if (sender == tbFirstRecord && tbFirstRecord.Text != "")
                    pierwszyRekord = int.Parse((sender as TextBox).Text);
                else if (sender == tbLastRecord && tbLastRecord.Text != "")
                    rekordscout = int.Parse((sender as TextBox).Text);
            }
            catch
            {
                MessageBox.Show("Z³y format danych");
            }
        }

        private void cbmanualExcel_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStateOfConteols(listofmanualExcel);
        }

        private void linkclick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start https://github.com/KamykO");
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("DEV MENU");
            chBxManualAdd.Checked = false;
            ChangeStateOfConteols(listofDEV);
            

            DEVtbwsW.Text = imgE.SGwhiteSpaceX.ToString(); // przerwa w poziomie
            DEVtbwsH.Text = imgE.SGwhiteSpaceY.ToString(); //przerwa w pionie
            DEVtbIDH.Text = imgE.ConvertA4pxtomm(imgE.DimS.Height).ToString(); //wysokoœæ ID
            DEVtbwidth.Text = imgE.ConvertA4pxtomm(imgE.DimS.Width).ToString(); //szerokoœæ ID
            DEVtbIDn.Text = imgE.SGmaxIdOnPage.ToString(); //ile ID

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                imgE.SGwhiteSpaceX = int.Parse(DEVtbwsW.Text); // przerwa w poziomie
                imgE.SGwhiteSpaceY = int.Parse(DEVtbwsH.Text); //przerwa w pionie
                imgE.DimS = new Size(imgE.ConvertmmToA4px(float.Parse(DEVtbwidth.Text)),imgE.ConvertmmToA4px(float.Parse(DEVtbIDH.Text)); //wysokoœæ ID
                imgE.SGmaxIdOnPage = int.Parse(DEVtbIDn.Text);//ile ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("DEV: Wprowadzono z³¹ wartoœæ");
            }
        }

        private void bImportTemplate_Click(object sender, EventArgs e) // Import Image
        {

            Console.WriteLine("Image: Import Button");
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName != null && openFileDialog2.FileName != "")
            {
                pathImage = openFileDialog2.FileName;
                bGen.Enabled = true;
                pictureBox1.Image = imgE.GenID(Image.FromFile(pathImage));
                Console.WriteLine("Image: Imported");
            }
        }
    }
}