namespace GeneratorID
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bImportTemplate = new Button();
            pictureBox1 = new PictureBox();
            bGen = new Button();
            bDragPointL = new Button();
            bDragPointR = new Button();
            bDragPointU = new Button();
            bDragPointD = new Button();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog1 = new OpenFileDialog();
            rBname = new RadioButton();
            rBsdnane = new RadioButton();
            rBclass = new RadioButton();
            saveFileDialog1 = new SaveFileDialog();
            fontDialogName = new FontDialog();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            fontDialogSCName = new FontDialog();
            fontDialogClass = new FontDialog();
            progressgenerationBar1 = new ProgressBar();
            tbName = new TextBox();
            tbSCN = new TextBox();
            tbGR = new TextBox();
            bAddMember = new Button();
            bDelMember = new Button();
            bImportBase = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            chBxManualAdd = new CheckBox();
            listBDaneManual = new ListBox();
            cbmanualExcel = new CheckBox();
            cbNameColumn = new ComboBox();
            cbSNameColumn = new ComboBox();
            cbGrColumn = new ComboBox();
            labelColumnChangeName = new Label();
            labelColumnChangeSName = new Label();
            labelColumnChangeGr = new Label();
            labelRowChangeAll = new Label();
            tbFirstRecord = new TextBox();
            labelRowChangeLast = new Label();
            tbLastRecord = new TextBox();
            linkLabel1 = new LinkLabel();
            DEVl5 = new Label();
            DEVtbwidth = new TextBox();
            DEVl4 = new Label();
            DEVtbIDH = new TextBox();
            DEVl3 = new Label();
            DEVtbwsH = new TextBox();
            DEVl2 = new Label();
            DEVtbwsW = new TextBox();
            DEVl1 = new Label();
            DEVtbIDn = new TextBox();
            DEVbtAC = new Button();
            DEVl6 = new Label();
            colorDialog1 = new ColorDialog();
            bbrushN = new Button();
            bbrushS = new Button();
            bbrushG = new Button();
            colorDialog2 = new ColorDialog();
            colorDialog3 = new ColorDialog();
            labelinfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bImportTemplate
            // 
            bImportTemplate.Enabled = false;
            bImportTemplate.Location = new Point(12, 62);
            bImportTemplate.Name = "bImportTemplate";
            bImportTemplate.Size = new Size(98, 44);
            bImportTemplate.TabIndex = 1;
            bImportTemplate.Text = "Importuj wzór";
            bImportTemplate.UseVisualStyleBackColor = true;
            bImportTemplate.Click += bImportTemplate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(116, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // bGen
            // 
            bGen.BackColor = SystemColors.ButtonHighlight;
            bGen.BackgroundImageLayout = ImageLayout.None;
            bGen.Enabled = false;
            bGen.Location = new Point(12, 112);
            bGen.Name = "bGen";
            bGen.Size = new Size(98, 44);
            bGen.TabIndex = 3;
            bGen.Text = "Generuj";
            bGen.UseVisualStyleBackColor = false;
            bGen.Click += bGen_Click;
            // 
            // bDragPointL
            // 
            bDragPointL.Enabled = false;
            bDragPointL.FlatStyle = FlatStyle.Popup;
            bDragPointL.Location = new Point(397, 146);
            bDragPointL.Name = "bDragPointL";
            bDragPointL.Size = new Size(27, 23);
            bDragPointL.TabIndex = 4;
            bDragPointL.Text = "→";
            bDragPointL.UseVisualStyleBackColor = true;
            bDragPointL.Click += bArrowClck;
            // 
            // bDragPointR
            // 
            bDragPointR.Enabled = false;
            bDragPointR.FlatStyle = FlatStyle.Popup;
            bDragPointR.Location = new Point(364, 146);
            bDragPointR.Name = "bDragPointR";
            bDragPointR.Size = new Size(27, 23);
            bDragPointR.TabIndex = 5;
            bDragPointR.Text = "←";
            bDragPointR.UseVisualStyleBackColor = true;
            bDragPointR.Click += bArrowClck;
            // 
            // bDragPointU
            // 
            bDragPointU.Enabled = false;
            bDragPointU.FlatStyle = FlatStyle.Popup;
            bDragPointU.Location = new Point(397, 117);
            bDragPointU.Name = "bDragPointU";
            bDragPointU.Size = new Size(27, 23);
            bDragPointU.TabIndex = 6;
            bDragPointU.Text = "↑";
            bDragPointU.UseVisualStyleBackColor = true;
            bDragPointU.Click += bArrowClck;
            // 
            // bDragPointD
            // 
            bDragPointD.Enabled = false;
            bDragPointD.FlatStyle = FlatStyle.Popup;
            bDragPointD.Location = new Point(364, 117);
            bDragPointD.Name = "bDragPointD";
            bDragPointD.Size = new Size(27, 23);
            bDragPointD.TabIndex = 7;
            bDragPointD.Text = "↓";
            bDragPointD.UseVisualStyleBackColor = true;
            bDragPointD.Click += bArrowClck;
            // 
            // openFileDialog2
            // 
            openFileDialog2.Filter = "PNG(*.png)|*.png|JPG (*.jpg)|*.jpg|Wszystkie pliki (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Pliki Excel (*.xls)|*.*";
            // 
            // rBname
            // 
            rBname.AutoSize = true;
            rBname.Checked = true;
            rBname.Enabled = false;
            rBname.FlatAppearance.CheckedBackColor = Color.Transparent;
            rBname.ForeColor = SystemColors.ControlText;
            rBname.Location = new Point(364, 41);
            rBname.Name = "rBname";
            rBname.Size = new Size(48, 19);
            rBname.TabIndex = 8;
            rBname.TabStop = true;
            rBname.Text = "Imię";
            rBname.UseVisualStyleBackColor = true;
            rBname.Click += rBSelect;
            // 
            // rBsdnane
            // 
            rBsdnane.AutoSize = true;
            rBsdnane.Enabled = false;
            rBsdnane.Location = new Point(364, 63);
            rBsdnane.Name = "rBsdnane";
            rBsdnane.Size = new Size(75, 19);
            rBsdnane.TabIndex = 9;
            rBsdnane.TabStop = true;
            rBsdnane.Text = "Nazwisko";
            rBsdnane.UseVisualStyleBackColor = true;
            rBsdnane.Click += rBSelect;
            // 
            // rBclass
            // 
            rBclass.AutoSize = true;
            rBclass.Enabled = false;
            rBclass.Location = new Point(364, 85);
            rBclass.Name = "rBclass";
            rBclass.Size = new Size(57, 19);
            rBclass.TabIndex = 10;
            rBclass.TabStop = true;
            rBclass.Text = "Grupa";
            rBclass.UseVisualStyleBackColor = true;
            rBclass.Click += rBSelect;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "Identyfikatory.pdf";
            saveFileDialog1.Filter = "Plik PDF (*.pdf*)|*.pdf*";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(442, 41);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(21, 22);
            button1.TabIndex = 12;
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 426);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 14;
            label2.Text = "?";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(442, 63);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(21, 22);
            button2.TabIndex = 15;
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(442, 85);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(21, 22);
            button3.TabIndex = 16;
            button3.TextImageRelation = TextImageRelation.TextAboveImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressgenerationBar1
            // 
            progressgenerationBar1.ForeColor = Color.IndianRed;
            progressgenerationBar1.Location = new Point(12, 162);
            progressgenerationBar1.Name = "progressgenerationBar1";
            progressgenerationBar1.Size = new Size(98, 32);
            progressgenerationBar1.Step = 2;
            progressgenerationBar1.TabIndex = 17;
            // 
            // tbName
            // 
            tbName.Location = new Point(365, 209);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 18;
            tbName.Visible = false;
            // 
            // tbSCN
            // 
            tbSCN.Location = new Point(365, 238);
            tbSCN.Name = "tbSCN";
            tbSCN.Size = new Size(100, 23);
            tbSCN.TabIndex = 19;
            tbSCN.Visible = false;
            // 
            // tbGR
            // 
            tbGR.Location = new Point(365, 267);
            tbGR.Name = "tbGR";
            tbGR.Size = new Size(100, 23);
            tbGR.TabIndex = 20;
            tbGR.Visible = false;
            // 
            // bAddMember
            // 
            bAddMember.FlatStyle = FlatStyle.Popup;
            bAddMember.ForeColor = SystemColors.ControlText;
            bAddMember.Location = new Point(303, 296);
            bAddMember.Name = "bAddMember";
            bAddMember.Size = new Size(81, 23);
            bAddMember.TabIndex = 21;
            bAddMember.Text = "Dodaj";
            bAddMember.UseVisualStyleBackColor = true;
            bAddMember.Visible = false;
            bAddMember.Click += bAddMember_Click;
            // 
            // bDelMember
            // 
            bDelMember.FlatStyle = FlatStyle.Popup;
            bDelMember.ForeColor = SystemColors.ControlText;
            bDelMember.Location = new Point(390, 296);
            bDelMember.Name = "bDelMember";
            bDelMember.Size = new Size(75, 23);
            bDelMember.TabIndex = 22;
            bDelMember.Text = "Usuń";
            bDelMember.UseVisualStyleBackColor = true;
            bDelMember.Visible = false;
            bDelMember.Click += bDelMember_Click;
            // 
            // bImportBase
            // 
            bImportBase.Location = new Point(12, 12);
            bImportBase.Name = "bImportBase";
            bImportBase.Size = new Size(98, 44);
            bImportBase.TabIndex = 0;
            bImportBase.Text = "Importuj bazę danych";
            bImportBase.UseVisualStyleBackColor = true;
            bImportBase.Click += bImportBase_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 213);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 24;
            label1.Text = "Imię";
            label1.UseWaitCursor = true;
            label1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 241);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 25;
            label3.Text = "Nazwisko";
            label3.UseWaitCursor = true;
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 270);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 26;
            label4.Text = "Grupa";
            label4.UseWaitCursor = true;
            label4.Visible = false;
            // 
            // chBxManualAdd
            // 
            chBxManualAdd.AutoSize = true;
            chBxManualAdd.Location = new Point(12, 200);
            chBxManualAdd.Name = "chBxManualAdd";
            chBxManualAdd.Size = new Size(134, 19);
            chBxManualAdd.TabIndex = 27;
            chBxManualAdd.Text = "Ręcznie dodaj osoby";
            chBxManualAdd.UseVisualStyleBackColor = true;
            chBxManualAdd.CheckedChanged += chBxManualAdd_CheckedChanged;
            // 
            // listBDaneManual
            // 
            listBDaneManual.FormattingEnabled = true;
            listBDaneManual.ItemHeight = 15;
            listBDaneManual.Location = new Point(303, 325);
            listBDaneManual.Name = "listBDaneManual";
            listBDaneManual.Size = new Size(162, 79);
            listBDaneManual.TabIndex = 28;
            listBDaneManual.Visible = false;
            // 
            // cbmanualExcel
            // 
            cbmanualExcel.AutoSize = true;
            cbmanualExcel.Location = new Point(12, 225);
            cbmanualExcel.Name = "cbmanualExcel";
            cbmanualExcel.Size = new Size(181, 19);
            cbmanualExcel.TabIndex = 29;
            cbmanualExcel.Text = "Manualnie dostosuj Kolumny";
            cbmanualExcel.UseVisualStyleBackColor = true;
            cbmanualExcel.CheckedChanged += cbmanualExcel_CheckedChanged;
            // 
            // cbNameColumn
            // 
            cbNameColumn.FormattingEnabled = true;
            cbNameColumn.ImeMode = ImeMode.NoControl;
            cbNameColumn.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cbNameColumn.Location = new Point(124, 263);
            cbNameColumn.Name = "cbNameColumn";
            cbNameColumn.Size = new Size(41, 23);
            cbNameColumn.TabIndex = 30;
            cbNameColumn.Text = "J";
            cbNameColumn.Visible = false;
            cbNameColumn.SelectedIndexChanged += cbCoolumnchange;
            // 
            // cbSNameColumn
            // 
            cbSNameColumn.FormattingEnabled = true;
            cbSNameColumn.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cbSNameColumn.Location = new Point(124, 292);
            cbSNameColumn.Name = "cbSNameColumn";
            cbSNameColumn.Size = new Size(41, 23);
            cbSNameColumn.TabIndex = 31;
            cbSNameColumn.Text = "H";
            cbSNameColumn.Visible = false;
            cbSNameColumn.SelectedIndexChanged += cbCoolumnchange;
            // 
            // cbGrColumn
            // 
            cbGrColumn.FormattingEnabled = true;
            cbGrColumn.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cbGrColumn.Location = new Point(124, 321);
            cbGrColumn.Name = "cbGrColumn";
            cbGrColumn.Size = new Size(41, 23);
            cbGrColumn.TabIndex = 32;
            cbGrColumn.Text = "V";
            cbGrColumn.Visible = false;
            cbGrColumn.SelectedIndexChanged += cbCoolumnchange;
            // 
            // labelColumnChangeName
            // 
            labelColumnChangeName.AutoSize = true;
            labelColumnChangeName.Location = new Point(12, 266);
            labelColumnChangeName.Name = "labelColumnChangeName";
            labelColumnChangeName.Size = new Size(94, 15);
            labelColumnChangeName.TabIndex = 33;
            labelColumnChangeName.Text = "Kolumna Imiena";
            labelColumnChangeName.Visible = false;
            // 
            // labelColumnChangeSName
            // 
            labelColumnChangeSName.AutoSize = true;
            labelColumnChangeSName.Location = new Point(12, 295);
            labelColumnChangeSName.Name = "labelColumnChangeSName";
            labelColumnChangeSName.Size = new Size(107, 15);
            labelColumnChangeSName.TabIndex = 34;
            labelColumnChangeSName.Text = "Kolumna Nazwiska";
            labelColumnChangeSName.Visible = false;
            // 
            // labelColumnChangeGr
            // 
            labelColumnChangeGr.AutoSize = true;
            labelColumnChangeGr.Location = new Point(12, 324);
            labelColumnChangeGr.Name = "labelColumnChangeGr";
            labelColumnChangeGr.Size = new Size(90, 15);
            labelColumnChangeGr.TabIndex = 35;
            labelColumnChangeGr.Text = "Kolumna Grupy";
            labelColumnChangeGr.Visible = false;
            // 
            // labelRowChangeAll
            // 
            labelRowChangeAll.AutoSize = true;
            labelRowChangeAll.Location = new Point(12, 353);
            labelRowChangeAll.Name = "labelRowChangeAll";
            labelRowChangeAll.Size = new Size(89, 15);
            labelRowChangeAll.TabIndex = 36;
            labelRowChangeAll.Text = "Pierwszy rekord";
            labelRowChangeAll.Visible = false;
            // 
            // tbFirstRecord
            // 
            tbFirstRecord.Location = new Point(124, 350);
            tbFirstRecord.Name = "tbFirstRecord";
            tbFirstRecord.Size = new Size(41, 23);
            tbFirstRecord.TabIndex = 37;
            tbFirstRecord.Text = "2";
            tbFirstRecord.Visible = false;
            tbFirstRecord.WordWrap = false;
            tbFirstRecord.TextChanged += cbCoolumnchange;
            // 
            // labelRowChangeLast
            // 
            labelRowChangeLast.AutoSize = true;
            labelRowChangeLast.Location = new Point(12, 382);
            labelRowChangeLast.Name = "labelRowChangeLast";
            labelRowChangeLast.Size = new Size(82, 15);
            labelRowChangeLast.TabIndex = 38;
            labelRowChangeLast.Text = "Ostatni rekord";
            labelRowChangeLast.Visible = false;
            // 
            // tbLastRecord
            // 
            tbLastRecord.Location = new Point(124, 379);
            tbLastRecord.Name = "tbLastRecord";
            tbLastRecord.Size = new Size(41, 23);
            tbLastRecord.TabIndex = 39;
            tbLastRecord.Text = "1000";
            tbLastRecord.Visible = false;
            tbLastRecord.WordWrap = false;
            tbLastRecord.TextChanged += cbCoolumnchange;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(417, 426);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 15);
            linkLabel1.TabIndex = 40;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "@kamykO";
            linkLabel1.LinkClicked += linkclick;
            // 
            // DEVl5
            // 
            DEVl5.AutoSize = true;
            DEVl5.Location = new Point(180, 364);
            DEVl5.Name = "DEVl5";
            DEVl5.Size = new Size(117, 15);
            DEVl5.TabIndex = 41;
            DEVl5.Text = "Ilość identyfikatorów";
            DEVl5.Visible = false;
            // 
            // DEVtbwidth
            // 
            DEVtbwidth.Location = new Point(303, 382);
            DEVtbwidth.Name = "DEVtbwidth";
            DEVtbwidth.Size = new Size(100, 23);
            DEVtbwidth.TabIndex = 42;
            DEVtbwidth.Visible = false;
            // 
            // DEVl4
            // 
            DEVl4.AutoSize = true;
            DEVl4.Location = new Point(303, 364);
            DEVl4.Name = "DEVl4";
            DEVl4.Size = new Size(168, 15);
            DEVl4.TabIndex = 43;
            DEVl4.Text = "Szerokość identyfikatora (mm)";
            DEVl4.Visible = false;
            // 
            // DEVtbIDH
            // 
            DEVtbIDH.Location = new Point(304, 338);
            DEVtbIDH.Name = "DEVtbIDH";
            DEVtbIDH.Size = new Size(100, 23);
            DEVtbIDH.TabIndex = 44;
            DEVtbIDH.Visible = false;
            // 
            // DEVl3
            // 
            DEVl3.AutoSize = true;
            DEVl3.Location = new Point(303, 320);
            DEVl3.Name = "DEVl3";
            DEVl3.Size = new Size(169, 15);
            DEVl3.TabIndex = 45;
            DEVl3.Text = "Wysokość identyfikatora (mm)";
            DEVl3.Visible = false;
            // 
            // DEVtbwsH
            // 
            DEVtbwsH.Location = new Point(303, 297);
            DEVtbwsH.Name = "DEVtbwsH";
            DEVtbwsH.Size = new Size(100, 23);
            DEVtbwsH.TabIndex = 46;
            DEVtbwsH.Visible = false;
            // 
            // DEVl2
            // 
            DEVl2.AutoSize = true;
            DEVl2.Location = new Point(303, 278);
            DEVl2.Name = "DEVl2";
            DEVl2.Size = new Size(161, 15);
            DEVl2.TabIndex = 47;
            DEVl2.Text = "Przerwa między w pionie (px)";
            DEVl2.Visible = false;
            // 
            // DEVtbwsW
            // 
            DEVtbwsW.Location = new Point(304, 255);
            DEVtbwsW.Name = "DEVtbwsW";
            DEVtbwsW.Size = new Size(100, 23);
            DEVtbwsW.TabIndex = 48;
            DEVtbwsW.Visible = false;
            // 
            // DEVl1
            // 
            DEVl1.AutoSize = true;
            DEVl1.Location = new Point(304, 235);
            DEVl1.Name = "DEVl1";
            DEVl1.Size = new Size(173, 15);
            DEVl1.TabIndex = 49;
            DEVl1.Text = "Przewa między w poziomie (px)";
            DEVl1.Visible = false;
            // 
            // DEVtbIDn
            // 
            DEVtbIDn.Location = new Point(186, 382);
            DEVtbIDn.Name = "DEVtbIDn";
            DEVtbIDn.Size = new Size(100, 23);
            DEVtbIDn.TabIndex = 50;
            DEVtbIDn.Visible = false;
            // 
            // DEVbtAC
            // 
            DEVbtAC.Location = new Point(186, 338);
            DEVbtAC.Name = "DEVbtAC";
            DEVbtAC.Size = new Size(100, 23);
            DEVbtAC.TabIndex = 51;
            DEVbtAC.Text = "Akceptuj DEV";
            DEVbtAC.UseVisualStyleBackColor = true;
            DEVbtAC.Visible = false;
            DEVbtAC.Click += button4_Click;
            // 
            // DEVl6
            // 
            DEVl6.AutoSize = true;
            DEVl6.Location = new Point(210, 408);
            DEVl6.Name = "DEVl6";
            DEVl6.Size = new Size(53, 15);
            DEVl6.TabIndex = 52;
            DEVl6.Text = "(max 12)";
            DEVl6.Visible = false;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.FullOpen = true;
            // 
            // bbrushN
            // 
            bbrushN.Enabled = false;
            bbrushN.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            bbrushN.Image = (Image)resources.GetObject("bbrushN.Image");
            bbrushN.Location = new Point(463, 41);
            bbrushN.Margin = new Padding(0);
            bbrushN.Name = "bbrushN";
            bbrushN.Size = new Size(21, 22);
            bbrushN.TabIndex = 54;
            bbrushN.TextImageRelation = TextImageRelation.TextAboveImage;
            bbrushN.UseVisualStyleBackColor = true;
            bbrushN.Click += button5_Click;
            // 
            // bbrushS
            // 
            bbrushS.Enabled = false;
            bbrushS.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            bbrushS.Image = (Image)resources.GetObject("bbrushS.Image");
            bbrushS.Location = new Point(463, 63);
            bbrushS.Margin = new Padding(0);
            bbrushS.Name = "bbrushS";
            bbrushS.Size = new Size(21, 22);
            bbrushS.TabIndex = 55;
            bbrushS.TextImageRelation = TextImageRelation.TextAboveImage;
            bbrushS.UseVisualStyleBackColor = true;
            bbrushS.Click += bbrushS_Click;
            // 
            // bbrushG
            // 
            bbrushG.Enabled = false;
            bbrushG.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            bbrushG.Image = (Image)resources.GetObject("bbrushG.Image");
            bbrushG.Location = new Point(463, 85);
            bbrushG.Margin = new Padding(0);
            bbrushG.Name = "bbrushG";
            bbrushG.Size = new Size(21, 22);
            bbrushG.TabIndex = 56;
            bbrushG.TextImageRelation = TextImageRelation.TextAboveImage;
            bbrushG.UseVisualStyleBackColor = true;
            bbrushG.Click += bbrushG_Click;
            // 
            // colorDialog2
            // 
            colorDialog2.AnyColor = true;
            colorDialog2.FullOpen = true;
            // 
            // colorDialog3
            // 
            colorDialog3.AnyColor = true;
            colorDialog3.FullOpen = true;
            // 
            // labelinfo
            // 
            labelinfo.Location = new Point(12, 247);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(209, 63);
            labelinfo.TabIndex = 57;
            labelinfo.Text = "Program został przygotowany do obsługi formatu pliku SOSW 2022, jeśli używasz innego dostosuj kolumny";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(labelinfo);
            Controls.Add(bbrushG);
            Controls.Add(bbrushS);
            Controls.Add(bbrushN);
            Controls.Add(DEVl6);
            Controls.Add(DEVbtAC);
            Controls.Add(DEVtbIDn);
            Controls.Add(DEVl1);
            Controls.Add(DEVtbwsW);
            Controls.Add(DEVl2);
            Controls.Add(DEVtbwsH);
            Controls.Add(DEVl3);
            Controls.Add(DEVtbIDH);
            Controls.Add(DEVl4);
            Controls.Add(DEVtbwidth);
            Controls.Add(DEVl5);
            Controls.Add(linkLabel1);
            Controls.Add(tbLastRecord);
            Controls.Add(labelRowChangeLast);
            Controls.Add(tbFirstRecord);
            Controls.Add(labelRowChangeAll);
            Controls.Add(labelColumnChangeGr);
            Controls.Add(labelColumnChangeSName);
            Controls.Add(labelColumnChangeName);
            Controls.Add(cbGrColumn);
            Controls.Add(cbSNameColumn);
            Controls.Add(cbNameColumn);
            Controls.Add(cbmanualExcel);
            Controls.Add(listBDaneManual);
            Controls.Add(chBxManualAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(bDelMember);
            Controls.Add(bAddMember);
            Controls.Add(tbGR);
            Controls.Add(tbSCN);
            Controls.Add(tbName);
            Controls.Add(progressgenerationBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(rBclass);
            Controls.Add(rBsdnane);
            Controls.Add(rBname);
            Controls.Add(bDragPointD);
            Controls.Add(bDragPointU);
            Controls.Add(bDragPointR);
            Controls.Add(bDragPointL);
            Controls.Add(bGen);
            Controls.Add(pictureBox1);
            Controls.Add(bImportTemplate);
            Controls.Add(bImportBase);
            Location = new Point(504, 489);
            MaximizeBox = false;
            MaximumSize = new Size(504, 489);
            Name = "Form1";
            Text = "GenID";
            Load += Form1_Load;
            HelpRequested += Form1_HelpRequested;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bImportTemplate;
        private PictureBox pictureBox1;
        private Button bGen;
        private Button bDragPointL;
        private Button bDragPointR;
        private Button bDragPointU;
        private Button bDragPointD;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog1;
        private RadioButton rBname;
        private RadioButton rBsdnane;
        private RadioButton rBclass;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialogName;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private FontDialog fontDialogSCName;
        private FontDialog fontDialogClass;
        private ProgressBar progressgenerationBar1;
        private TextBox tbName;
        private TextBox tbSCN;
        private TextBox tbGR;
        private Button bAddMember;
        private Button bDelMember;
        private Button bImportBase;
        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox chBxManualAdd;
        private ListBox listBDaneManual;
        private CheckBox cbmanualExcel;
        private ComboBox cbNameColumn;
        private ComboBox cbSNameColumn;
        private ComboBox cbGrColumn;
        private Label labelColumnChangeName;
        private Label labelColumnChangeSName;
        private Label labelColumnChangeGr;
        private Label labelRowChangeAll;
        private TextBox tbFirstRecord;
        private Label labelRowChangeLast;
        private TextBox tbLastRecord;
        private LinkLabel linkLabel1;
        private Label DEVl5;
        private TextBox DEVtbwidth;
        private Label DEVl4;
        private TextBox DEVtbIDH;
        private Label DEVl3;
        private TextBox DEVtbwsH;
        private Label DEVl2;
        private TextBox DEVtbwsW;
        private Label DEVl1;
        private TextBox DEVtbIDn;
        private Button DEVbtAC;
        private Label DEVl6;
        private ColorDialog colorDialog1;
        private Button bbrushN;
        private Button bbrushS;
        private Button bbrushG;
        private ColorDialog colorDialog2;
        private ColorDialog colorDialog3;
        private Label labelinfo;
    }
}