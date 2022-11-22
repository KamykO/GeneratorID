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
            this.bImportBase = new System.Windows.Forms.Button();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialogName = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fontDialogSCName = new System.Windows.Forms.FontDialog();
            this.fontDialogClass = new System.Windows.Forms.FontDialog();
            this.progressgenerationBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bAddMember = new System.Windows.Forms.Button();
            this.bDelMember = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
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
            this.bDragPointL.Location = new System.Drawing.Point(436, 117);
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
            this.bDragPointR.Location = new System.Drawing.Point(403, 117);
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
            this.bDragPointU.Location = new System.Drawing.Point(436, 88);
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
            this.bDragPointD.Location = new System.Drawing.Point(403, 88);
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
            this.rBname.Location = new System.Drawing.Point(403, 12);
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
            this.rBsdnane.Location = new System.Drawing.Point(403, 34);
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
            this.rBclass.Location = new System.Drawing.Point(403, 56);
            this.rBclass.Name = "rBclass";
            this.rBclass.Size = new System.Drawing.Size(57, 19);
            this.rBclass.TabIndex = 10;
            this.rBclass.TabStop = true;
            this.rBclass.Text = "Grupa";
            this.rBclass.UseVisualStyleBackColor = true;
            this.rBclass.Click += new System.EventHandler(this.rBSelect);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(664, 419);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Ilość osób na liście";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Plik PDF (*.pdf*)|*.pdf*";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(481, 12);
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
            this.button2.Location = new System.Drawing.Point(481, 34);
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
            this.button3.Location = new System.Drawing.Point(481, 56);
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
            this.progressgenerationBar1.Size = new System.Drawing.Size(98, 23);
            this.progressgenerationBar1.Step = 2;
            this.progressgenerationBar1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(688, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(688, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 20;
            // 
            // bAddMember
            // 
            this.bAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAddMember.Location = new System.Drawing.Point(688, 95);
            this.bAddMember.Name = "bAddMember";
            this.bAddMember.Size = new System.Drawing.Size(49, 23);
            this.bAddMember.TabIndex = 21;
            this.bAddMember.Text = "Dodaj";
            this.bAddMember.UseVisualStyleBackColor = true;
            // 
            // bDelMember
            // 
            this.bDelMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDelMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bDelMember.Location = new System.Drawing.Point(739, 95);
            this.bDelMember.Name = "bDelMember";
            this.bDelMember.Size = new System.Drawing.Size(49, 23);
            this.bDelMember.TabIndex = 22;
            this.bDelMember.Text = "Usuń";
            this.bDelMember.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(562, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 107);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(562, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 236);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bDelMember);
            this.Controls.Add(this.bAddMember);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressgenerationBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bImportBase;
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
        private CheckBox checkBox1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialogName;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private FontDialog fontDialogSCName;
        private FontDialog fontDialogClass;
        private ProgressBar progressgenerationBar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button bAddMember;
        private Button bDelMember;
        private ListBox listBox1;
        private GroupBox groupBox1;
    }
}