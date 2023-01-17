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
            this.bImportTemplate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bGen = new System.Windows.Forms.Button();
            this.bDragPointL = new System.Windows.Forms.Button();
            this.bDragPointR = new System.Windows.Forms.Button();
            this.bDragPointU = new System.Windows.Forms.Button();
            this.bDragPointD = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rBname = new System.Windows.Forms.RadioButton();
            this.rBsdnane = new System.Windows.Forms.RadioButton();
            this.rBclass = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialogName = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fontDialogSCName = new System.Windows.Forms.FontDialog();
            this.fontDialogClass = new System.Windows.Forms.FontDialog();
            this.progressgenerationBar1 = new System.Windows.Forms.ProgressBar();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSCN = new System.Windows.Forms.TextBox();
            this.tbGR = new System.Windows.Forms.TextBox();
            this.bAddMember = new System.Windows.Forms.Button();
            this.bDelMember = new System.Windows.Forms.Button();
            this.bImportBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chBxManualAdd = new System.Windows.Forms.CheckBox();
            this.listBDaneManual = new System.Windows.Forms.ListBox();
            this.cbmanualExcel = new System.Windows.Forms.CheckBox();
            this.cbNameColumn = new System.Windows.Forms.ComboBox();
            this.cbSNameColumn = new System.Windows.Forms.ComboBox();
            this.cbGrColumn = new System.Windows.Forms.ComboBox();
            this.labelColumnChangeName = new System.Windows.Forms.Label();
            this.labelColumnChangeSName = new System.Windows.Forms.Label();
            this.labelColumnChangeGr = new System.Windows.Forms.Label();
            this.labelRowChangeAll = new System.Windows.Forms.Label();
            this.tbFirstRecord = new System.Windows.Forms.TextBox();
            this.labelRowChangeLast = new System.Windows.Forms.Label();
            this.tbLastRecord = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DEVl5 = new System.Windows.Forms.Label();
            this.DEVtbwidth = new System.Windows.Forms.TextBox();
            this.DEVl4 = new System.Windows.Forms.Label();
            this.DEVtbIDH = new System.Windows.Forms.TextBox();
            this.DEVl3 = new System.Windows.Forms.Label();
            this.DEVtbwsH = new System.Windows.Forms.TextBox();
            this.DEVl2 = new System.Windows.Forms.Label();
            this.DEVtbwsW = new System.Windows.Forms.TextBox();
            this.DEVl1 = new System.Windows.Forms.Label();
            this.DEVtbIDn = new System.Windows.Forms.TextBox();
            this.DEVbtAC = new System.Windows.Forms.Button();
            this.DEVl6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bImportTemplate
            // 
            this.bImportTemplate.Enabled = false;
            this.bImportTemplate.Location = new System.Drawing.Point(12, 62);
            this.bImportTemplate.Name = "bImportTemplate";
            this.bImportTemplate.Size = new System.Drawing.Size(98, 44);
            this.bImportTemplate.TabIndex = 1;
            this.bImportTemplate.Text = "Importuj wzór";
            this.bImportTemplate.UseVisualStyleBackColor = true;
            this.bImportTemplate.Click += new System.EventHandler(this.bImportTemplate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(116, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bGen
            // 
            this.bGen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bGen.Enabled = false;
            this.bGen.Location = new System.Drawing.Point(12, 112);
            this.bGen.Name = "bGen";
            this.bGen.Size = new System.Drawing.Size(98, 44);
            this.bGen.TabIndex = 3;
            this.bGen.Text = "Generuj";
            this.bGen.UseVisualStyleBackColor = false;
            this.bGen.Click += new System.EventHandler(this.bGen_Click);
            // 
            // bDragPointL
            // 
            this.bDragPointL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDragPointL.Location = new System.Drawing.Point(397, 146);
            this.bDragPointL.Name = "bDragPointL";
            this.bDragPointL.Size = new System.Drawing.Size(27, 23);
            this.bDragPointL.TabIndex = 4;
            this.bDragPointL.Text = "→";
            this.bDragPointL.UseVisualStyleBackColor = true;
            this.bDragPointL.Click += new System.EventHandler(this.bArrowClck);
            // 
            // bDragPointR
            // 
            this.bDragPointR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDragPointR.Location = new System.Drawing.Point(364, 146);
            this.bDragPointR.Name = "bDragPointR";
            this.bDragPointR.Size = new System.Drawing.Size(27, 23);
            this.bDragPointR.TabIndex = 5;
            this.bDragPointR.Text = "←";
            this.bDragPointR.UseVisualStyleBackColor = true;
            this.bDragPointR.Click += new System.EventHandler(this.bArrowClck);
            // 
            // bDragPointU
            // 
            this.bDragPointU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDragPointU.Location = new System.Drawing.Point(397, 117);
            this.bDragPointU.Name = "bDragPointU";
            this.bDragPointU.Size = new System.Drawing.Size(27, 23);
            this.bDragPointU.TabIndex = 6;
            this.bDragPointU.Text = "↑";
            this.bDragPointU.UseVisualStyleBackColor = true;
            this.bDragPointU.Click += new System.EventHandler(this.bArrowClck);
            // 
            // bDragPointD
            // 
            this.bDragPointD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDragPointD.Location = new System.Drawing.Point(364, 117);
            this.bDragPointD.Name = "bDragPointD";
            this.bDragPointD.Size = new System.Drawing.Size(27, 23);
            this.bDragPointD.TabIndex = 7;
            this.bDragPointD.Text = "↓";
            this.bDragPointD.UseVisualStyleBackColor = true;
            this.bDragPointD.Click += new System.EventHandler(this.bArrowClck);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.Filter = "PNG(*.png)|*.png|JPG (*.jpg)|*.jpg|Wszystkie pliki (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pliki Excel (*.xls)|*.*";
            // 
            // rBname
            // 
            this.rBname.AutoSize = true;
            this.rBname.Checked = true;
            this.rBname.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rBname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rBname.Location = new System.Drawing.Point(364, 41);
            this.rBname.Name = "rBname";
            this.rBname.Size = new System.Drawing.Size(48, 19);
            this.rBname.TabIndex = 8;
            this.rBname.TabStop = true;
            this.rBname.Text = "Imię";
            this.rBname.UseVisualStyleBackColor = true;
            this.rBname.Click += new System.EventHandler(this.rBSelect);
            // 
            // rBsdnane
            // 
            this.rBsdnane.AutoSize = true;
            this.rBsdnane.Location = new System.Drawing.Point(364, 63);
            this.rBsdnane.Name = "rBsdnane";
            this.rBsdnane.Size = new System.Drawing.Size(75, 19);
            this.rBsdnane.TabIndex = 9;
            this.rBsdnane.TabStop = true;
            this.rBsdnane.Text = "Nazwisko";
            this.rBsdnane.UseVisualStyleBackColor = true;
            this.rBsdnane.Click += new System.EventHandler(this.rBSelect);
            // 
            // rBclass
            // 
            this.rBclass.AutoSize = true;
            this.rBclass.Location = new System.Drawing.Point(364, 85);
            this.rBclass.Name = "rBclass";
            this.rBclass.Size = new System.Drawing.Size(57, 19);
            this.rBclass.TabIndex = 10;
            this.rBclass.TabStop = true;
            this.rBclass.Text = "Grupa";
            this.rBclass.UseVisualStyleBackColor = true;
            this.rBclass.Click += new System.EventHandler(this.rBSelect);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Plik PDF (*.pdf*)|*.pdf*";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(442, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 22);
            this.button1.TabIndex = 12;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(442, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 22);
            this.button2.TabIndex = 15;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(442, 85);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 22);
            this.button3.TabIndex = 16;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressgenerationBar1
            // 
            this.progressgenerationBar1.ForeColor = System.Drawing.Color.IndianRed;
            this.progressgenerationBar1.Location = new System.Drawing.Point(12, 162);
            this.progressgenerationBar1.Name = "progressgenerationBar1";
            this.progressgenerationBar1.Size = new System.Drawing.Size(98, 32);
            this.progressgenerationBar1.Step = 2;
            this.progressgenerationBar1.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(365, 209);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 18;
            this.tbName.Visible = false;
            // 
            // tbSCN
            // 
            this.tbSCN.Location = new System.Drawing.Point(365, 238);
            this.tbSCN.Name = "tbSCN";
            this.tbSCN.Size = new System.Drawing.Size(100, 23);
            this.tbSCN.TabIndex = 19;
            this.tbSCN.Visible = false;
            // 
            // tbGR
            // 
            this.tbGR.Location = new System.Drawing.Point(365, 267);
            this.tbGR.Name = "tbGR";
            this.tbGR.Size = new System.Drawing.Size(100, 23);
            this.tbGR.TabIndex = 20;
            this.tbGR.Visible = false;
            // 
            // bAddMember
            // 
            this.bAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAddMember.Location = new System.Drawing.Point(303, 296);
            this.bAddMember.Name = "bAddMember";
            this.bAddMember.Size = new System.Drawing.Size(81, 23);
            this.bAddMember.TabIndex = 21;
            this.bAddMember.Text = "Dodaj";
            this.bAddMember.UseVisualStyleBackColor = true;
            this.bAddMember.Visible = false;
            this.bAddMember.Click += new System.EventHandler(this.bAddMember_Click);
            // 
            // bDelMember
            // 
            this.bDelMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDelMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bDelMember.Location = new System.Drawing.Point(390, 296);
            this.bDelMember.Name = "bDelMember";
            this.bDelMember.Size = new System.Drawing.Size(75, 23);
            this.bDelMember.TabIndex = 22;
            this.bDelMember.Text = "Usuń";
            this.bDelMember.UseVisualStyleBackColor = true;
            this.bDelMember.Visible = false;
            this.bDelMember.Click += new System.EventHandler(this.bDelMember_Click);
            // 
            // bImportBase
            // 
            this.bImportBase.Location = new System.Drawing.Point(12, 12);
            this.bImportBase.Name = "bImportBase";
            this.bImportBase.Size = new System.Drawing.Size(98, 44);
            this.bImportBase.TabIndex = 0;
            this.bImportBase.Text = "Importuj bazę danych";
            this.bImportBase.UseVisualStyleBackColor = true;
            this.bImportBase.Click += new System.EventHandler(this.bImportBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Imię";
            this.label1.UseWaitCursor = true;
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nazwisko";
            this.label3.UseWaitCursor = true;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Grupa";
            this.label4.UseWaitCursor = true;
            this.label4.Visible = false;
            // 
            // chBxManualAdd
            // 
            this.chBxManualAdd.AutoSize = true;
            this.chBxManualAdd.Location = new System.Drawing.Point(12, 200);
            this.chBxManualAdd.Name = "chBxManualAdd";
            this.chBxManualAdd.Size = new System.Drawing.Size(134, 19);
            this.chBxManualAdd.TabIndex = 27;
            this.chBxManualAdd.Text = "Ręcznie dodaj osoby";
            this.chBxManualAdd.UseVisualStyleBackColor = true;
            this.chBxManualAdd.CheckedChanged += new System.EventHandler(this.chBxManualAdd_CheckedChanged);
            // 
            // listBDaneManual
            // 
            this.listBDaneManual.FormattingEnabled = true;
            this.listBDaneManual.ItemHeight = 15;
            this.listBDaneManual.Location = new System.Drawing.Point(303, 325);
            this.listBDaneManual.Name = "listBDaneManual";
            this.listBDaneManual.Size = new System.Drawing.Size(162, 79);
            this.listBDaneManual.TabIndex = 28;
            this.listBDaneManual.Visible = false;
            // 
            // cbmanualExcel
            // 
            this.cbmanualExcel.AutoSize = true;
            this.cbmanualExcel.Location = new System.Drawing.Point(12, 225);
            this.cbmanualExcel.Name = "cbmanualExcel";
            this.cbmanualExcel.Size = new System.Drawing.Size(181, 19);
            this.cbmanualExcel.TabIndex = 29;
            this.cbmanualExcel.Text = "Manualnie dostosuj Kolumny";
            this.cbmanualExcel.UseVisualStyleBackColor = true;
            this.cbmanualExcel.CheckedChanged += new System.EventHandler(this.cbmanualExcel_CheckedChanged);
            // 
            // cbNameColumn
            // 
            this.cbNameColumn.FormattingEnabled = true;
            this.cbNameColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbNameColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbNameColumn.Location = new System.Drawing.Point(124, 263);
            this.cbNameColumn.Name = "cbNameColumn";
            this.cbNameColumn.Size = new System.Drawing.Size(41, 23);
            this.cbNameColumn.TabIndex = 30;
            this.cbNameColumn.Text = "J";
            this.cbNameColumn.Visible = false;
            this.cbNameColumn.SelectedIndexChanged += new System.EventHandler(this.cbCoolumnchange);
            // 
            // cbSNameColumn
            // 
            this.cbSNameColumn.FormattingEnabled = true;
            this.cbSNameColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbSNameColumn.Location = new System.Drawing.Point(124, 292);
            this.cbSNameColumn.Name = "cbSNameColumn";
            this.cbSNameColumn.Size = new System.Drawing.Size(41, 23);
            this.cbSNameColumn.TabIndex = 31;
            this.cbSNameColumn.Text = "H";
            this.cbSNameColumn.Visible = false;
            this.cbSNameColumn.SelectedIndexChanged += new System.EventHandler(this.cbCoolumnchange);
            // 
            // cbGrColumn
            // 
            this.cbGrColumn.FormattingEnabled = true;
            this.cbGrColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbGrColumn.Location = new System.Drawing.Point(124, 321);
            this.cbGrColumn.Name = "cbGrColumn";
            this.cbGrColumn.Size = new System.Drawing.Size(41, 23);
            this.cbGrColumn.TabIndex = 32;
            this.cbGrColumn.Text = "V";
            this.cbGrColumn.Visible = false;
            this.cbGrColumn.SelectedIndexChanged += new System.EventHandler(this.cbCoolumnchange);
            // 
            // labelColumnChangeName
            // 
            this.labelColumnChangeName.AutoSize = true;
            this.labelColumnChangeName.Location = new System.Drawing.Point(12, 266);
            this.labelColumnChangeName.Name = "labelColumnChangeName";
            this.labelColumnChangeName.Size = new System.Drawing.Size(94, 15);
            this.labelColumnChangeName.TabIndex = 33;
            this.labelColumnChangeName.Text = "Kolumna Imiena";
            this.labelColumnChangeName.Visible = false;
            // 
            // labelColumnChangeSName
            // 
            this.labelColumnChangeSName.AutoSize = true;
            this.labelColumnChangeSName.Location = new System.Drawing.Point(12, 295);
            this.labelColumnChangeSName.Name = "labelColumnChangeSName";
            this.labelColumnChangeSName.Size = new System.Drawing.Size(107, 15);
            this.labelColumnChangeSName.TabIndex = 34;
            this.labelColumnChangeSName.Text = "Kolumna Nazwiska";
            this.labelColumnChangeSName.Visible = false;
            // 
            // labelColumnChangeGr
            // 
            this.labelColumnChangeGr.AutoSize = true;
            this.labelColumnChangeGr.Location = new System.Drawing.Point(12, 324);
            this.labelColumnChangeGr.Name = "labelColumnChangeGr";
            this.labelColumnChangeGr.Size = new System.Drawing.Size(90, 15);
            this.labelColumnChangeGr.TabIndex = 35;
            this.labelColumnChangeGr.Text = "Kolumna Grupy";
            this.labelColumnChangeGr.Visible = false;
            // 
            // labelRowChangeAll
            // 
            this.labelRowChangeAll.AutoSize = true;
            this.labelRowChangeAll.Location = new System.Drawing.Point(12, 353);
            this.labelRowChangeAll.Name = "labelRowChangeAll";
            this.labelRowChangeAll.Size = new System.Drawing.Size(89, 15);
            this.labelRowChangeAll.TabIndex = 36;
            this.labelRowChangeAll.Text = "Pierwszy rekord";
            this.labelRowChangeAll.Visible = false;
            // 
            // tbFirstRecord
            // 
            this.tbFirstRecord.Location = new System.Drawing.Point(124, 350);
            this.tbFirstRecord.Name = "tbFirstRecord";
            this.tbFirstRecord.Size = new System.Drawing.Size(41, 23);
            this.tbFirstRecord.TabIndex = 37;
            this.tbFirstRecord.Text = "2";
            this.tbFirstRecord.Visible = false;
            this.tbFirstRecord.WordWrap = false;
            this.tbFirstRecord.TextChanged += new System.EventHandler(this.cbCoolumnchange);
            // 
            // labelRowChangeLast
            // 
            this.labelRowChangeLast.AutoSize = true;
            this.labelRowChangeLast.Location = new System.Drawing.Point(12, 382);
            this.labelRowChangeLast.Name = "labelRowChangeLast";
            this.labelRowChangeLast.Size = new System.Drawing.Size(82, 15);
            this.labelRowChangeLast.TabIndex = 38;
            this.labelRowChangeLast.Text = "Ostatni rekord";
            this.labelRowChangeLast.Visible = false;
            // 
            // tbLastRecord
            // 
            this.tbLastRecord.Location = new System.Drawing.Point(124, 379);
            this.tbLastRecord.Name = "tbLastRecord";
            this.tbLastRecord.Size = new System.Drawing.Size(41, 23);
            this.tbLastRecord.TabIndex = 39;
            this.tbLastRecord.Text = "1000";
            this.tbLastRecord.Visible = false;
            this.tbLastRecord.WordWrap = false;
            this.tbLastRecord.TextChanged += new System.EventHandler(this.cbCoolumnchange);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(403, 426);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 15);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@kamykO";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkclick);
            // 
            // DEVl5
            // 
            this.DEVl5.AutoSize = true;
            this.DEVl5.Location = new System.Drawing.Point(180, 364);
            this.DEVl5.Name = "DEVl5";
            this.DEVl5.Size = new System.Drawing.Size(117, 15);
            this.DEVl5.TabIndex = 41;
            this.DEVl5.Text = "Ilość identyfikatorów";
            this.DEVl5.Visible = false;
            // 
            // DEVtbwidth
            // 
            this.DEVtbwidth.Location = new System.Drawing.Point(303, 382);
            this.DEVtbwidth.Name = "DEVtbwidth";
            this.DEVtbwidth.Size = new System.Drawing.Size(100, 23);
            this.DEVtbwidth.TabIndex = 42;
            this.DEVtbwidth.Visible = false;
            // 
            // DEVl4
            // 
            this.DEVl4.AutoSize = true;
            this.DEVl4.Location = new System.Drawing.Point(303, 364);
            this.DEVl4.Name = "DEVl4";
            this.DEVl4.Size = new System.Drawing.Size(168, 15);
            this.DEVl4.TabIndex = 43;
            this.DEVl4.Text = "Szerokość identyfikatora (mm)";
            this.DEVl4.Visible = false;
            // 
            // DEVtbIDH
            // 
            this.DEVtbIDH.Location = new System.Drawing.Point(304, 338);
            this.DEVtbIDH.Name = "DEVtbIDH";
            this.DEVtbIDH.Size = new System.Drawing.Size(100, 23);
            this.DEVtbIDH.TabIndex = 44;
            this.DEVtbIDH.Visible = false;
            // 
            // DEVl3
            // 
            this.DEVl3.AutoSize = true;
            this.DEVl3.Location = new System.Drawing.Point(303, 320);
            this.DEVl3.Name = "DEVl3";
            this.DEVl3.Size = new System.Drawing.Size(169, 15);
            this.DEVl3.TabIndex = 45;
            this.DEVl3.Text = "Wysokość identyfikatora (mm)";
            this.DEVl3.Visible = false;
            // 
            // DEVtbwsH
            // 
            this.DEVtbwsH.Location = new System.Drawing.Point(303, 297);
            this.DEVtbwsH.Name = "DEVtbwsH";
            this.DEVtbwsH.Size = new System.Drawing.Size(100, 23);
            this.DEVtbwsH.TabIndex = 46;
            this.DEVtbwsH.Visible = false;
            // 
            // DEVl2
            // 
            this.DEVl2.AutoSize = true;
            this.DEVl2.Location = new System.Drawing.Point(303, 278);
            this.DEVl2.Name = "DEVl2";
            this.DEVl2.Size = new System.Drawing.Size(161, 15);
            this.DEVl2.TabIndex = 47;
            this.DEVl2.Text = "Przerwa między w pionie (px)";
            this.DEVl2.Visible = false;
            // 
            // DEVtbwsW
            // 
            this.DEVtbwsW.Location = new System.Drawing.Point(304, 255);
            this.DEVtbwsW.Name = "DEVtbwsW";
            this.DEVtbwsW.Size = new System.Drawing.Size(100, 23);
            this.DEVtbwsW.TabIndex = 48;
            this.DEVtbwsW.Visible = false;
            // 
            // DEVl1
            // 
            this.DEVl1.AutoSize = true;
            this.DEVl1.Location = new System.Drawing.Point(304, 235);
            this.DEVl1.Name = "DEVl1";
            this.DEVl1.Size = new System.Drawing.Size(173, 15);
            this.DEVl1.TabIndex = 49;
            this.DEVl1.Text = "Przewa między w poziomie (px)";
            this.DEVl1.Visible = false;
            // 
            // DEVtbIDn
            // 
            this.DEVtbIDn.Location = new System.Drawing.Point(186, 382);
            this.DEVtbIDn.Name = "DEVtbIDn";
            this.DEVtbIDn.Size = new System.Drawing.Size(100, 23);
            this.DEVtbIDn.TabIndex = 50;
            this.DEVtbIDn.Visible = false;
            // 
            // DEVbtAC
            // 
            this.DEVbtAC.Location = new System.Drawing.Point(186, 338);
            this.DEVbtAC.Name = "DEVbtAC";
            this.DEVbtAC.Size = new System.Drawing.Size(100, 23);
            this.DEVbtAC.TabIndex = 51;
            this.DEVbtAC.Text = "Akceptuj DEV";
            this.DEVbtAC.UseVisualStyleBackColor = true;
            this.DEVbtAC.Visible = false;
            this.DEVbtAC.Click += new System.EventHandler(this.button4_Click);
            // 
            // DEVl6
            // 
            this.DEVl6.AutoSize = true;
            this.DEVl6.Location = new System.Drawing.Point(210, 408);
            this.DEVl6.Name = "DEVl6";
            this.DEVl6.Size = new System.Drawing.Size(53, 15);
            this.DEVl6.TabIndex = 52;
            this.DEVl6.Text = "(max 12)";
            this.DEVl6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.DEVl6);
            this.Controls.Add(this.DEVbtAC);
            this.Controls.Add(this.DEVtbIDn);
            this.Controls.Add(this.DEVl1);
            this.Controls.Add(this.DEVtbwsW);
            this.Controls.Add(this.DEVl2);
            this.Controls.Add(this.DEVtbwsH);
            this.Controls.Add(this.DEVl3);
            this.Controls.Add(this.DEVtbIDH);
            this.Controls.Add(this.DEVl4);
            this.Controls.Add(this.DEVtbwidth);
            this.Controls.Add(this.DEVl5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbLastRecord);
            this.Controls.Add(this.labelRowChangeLast);
            this.Controls.Add(this.tbFirstRecord);
            this.Controls.Add(this.labelRowChangeAll);
            this.Controls.Add(this.labelColumnChangeGr);
            this.Controls.Add(this.labelColumnChangeSName);
            this.Controls.Add(this.labelColumnChangeName);
            this.Controls.Add(this.cbGrColumn);
            this.Controls.Add(this.cbSNameColumn);
            this.Controls.Add(this.cbNameColumn);
            this.Controls.Add(this.cbmanualExcel);
            this.Controls.Add(this.listBDaneManual);
            this.Controls.Add(this.chBxManualAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDelMember);
            this.Controls.Add(this.bAddMember);
            this.Controls.Add(this.tbGR);
            this.Controls.Add(this.tbSCN);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.progressgenerationBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rBclass);
            this.Controls.Add(this.rBsdnane);
            this.Controls.Add(this.rBname);
            this.Controls.Add(this.bDragPointD);
            this.Controls.Add(this.bDragPointU);
            this.Controls.Add(this.bDragPointR);
            this.Controls.Add(this.bDragPointL);
            this.Controls.Add(this.bGen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bImportTemplate);
            this.Controls.Add(this.bImportBase);
            this.Location = new System.Drawing.Point(504, 489);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 489);
            this.Name = "Form1";
            this.Text = "GenID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}