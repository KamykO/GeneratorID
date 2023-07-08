namespace GeneratorID
{
    partial class InfoScr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 30);
            label1.TabIndex = 0;
            label1.Text = "!!UWAGA!!";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(497, 49);
            label2.TabIndex = 1;
            label2.Text = "Ta wersja programu wymaga do działania zainstalowanego pakietu programu Microsoft Excel";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(216, 15);
            label3.TabIndex = 3;
            label3.Text = "Sprawdź czy pojawiła się nowsza wersja:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 170);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.mojajeszczenieistniejącastrona.pl";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 170);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 5;
            label4.Text = "Aktualna wersja: 2.3";
            // 
            // InfoScr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(546, 190);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(562, 229);
            MinimizeBox = false;
            MinimumSize = new Size(562, 229);
            Name = "InfoScr";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}