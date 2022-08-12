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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.bDragPointL.Location = new System.Drawing.Point(436, 131);
            this.bDragPointL.Name = "bDragPointL";
            this.bDragPointL.Size = new System.Drawing.Size(27, 23);
            this.bDragPointL.TabIndex = 4;
            this.bDragPointL.Text = "→";
            this.bDragPointL.UseVisualStyleBackColor = true;
            this.bDragPointL.Click += new System.EventHandler(this.bArrowClck);
            // 
            // bDragPointR
            // 
            this.bDragPointR.Location = new System.Drawing.Point(403, 131);
            this.bDragPointR.Name = "bDragPointR";
            this.bDragPointR.Size = new System.Drawing.Size(27, 23);
            this.bDragPointR.TabIndex = 5;
            this.bDragPointR.Text = "←";
            this.bDragPointR.UseVisualStyleBackColor = true;
            this.bDragPointR.Click += new System.EventHandler(this.bArrowClck);
            // 
            // bDragPointU
            // 
            this.bDragPointU.Location = new System.Drawing.Point(436, 102);
            this.bDragPointU.Name = "bDragPointU";
            this.bDragPointU.Size = new System.Drawing.Size(27, 23);
            this.bDragPointU.TabIndex = 6;
            this.bDragPointU.Text = "↑";
            this.bDragPointU.UseVisualStyleBackColor = true;
            this.bDragPointU.Click += new System.EventHandler(this.bArrowClck);
            // 
            // bDragPointD
            // 
            this.bDragPointD.Location = new System.Drawing.Point(403, 102);
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
            this.rBsdnane.Location = new System.Drawing.Point(403, 37);
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
            this.rBclass.Location = new System.Drawing.Point(403, 62);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private FontDialog fontDialog1;
    }
}