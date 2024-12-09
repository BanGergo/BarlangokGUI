namespace BarlangokGUI
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
            btkeres = new Button();
            btmentes = new Button();
            label1 = new Label();
            lbnev = new Label();
            label3 = new Label();
            label4 = new Label();
            txazon = new TextBox();
            txhossz = new TextBox();
            txmely = new TextBox();
            SuspendLayout();
            // 
            // btkeres
            // 
            btkeres.Location = new Point(315, 30);
            btkeres.Name = "btkeres";
            btkeres.Size = new Size(108, 23);
            btkeres.TabIndex = 0;
            btkeres.Text = "Barlang keresése";
            btkeres.UseVisualStyleBackColor = true;
            btkeres.Click += btkeres_Click;
            // 
            // btmentes
            // 
            btmentes.Location = new Point(315, 176);
            btmentes.Name = "btmentes";
            btmentes.Size = new Size(108, 24);
            btmentes.TabIndex = 1;
            btmentes.Text = "Adatok mentése";
            btmentes.UseVisualStyleBackColor = true;
            btmentes.Click += btmentes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Azonosító:";
            // 
            // lbnev
            // 
            lbnev.AutoSize = true;
            lbnev.Location = new Point(12, 80);
            lbnev.Name = "lbnev";
            lbnev.Size = new Size(78, 15);
            lbnev.TabIndex = 3;
            lbnev.Text = "Barlang neve:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Hosszúság:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Mélység:";
            label4.Click += label4_Click;
            // 
            // txazon
            // 
            txazon.Location = new Point(113, 30);
            txazon.Name = "txazon";
            txazon.Size = new Size(107, 23);
            txazon.TabIndex = 6;
            // 
            // txhossz
            // 
            txhossz.Location = new Point(113, 127);
            txhossz.Name = "txhossz";
            txhossz.Size = new Size(107, 23);
            txhossz.TabIndex = 7;
            // 
            // txmely
            // 
            txmely.Location = new Point(113, 177);
            txmely.Name = "txmely";
            txmely.Size = new Size(107, 23);
            txmely.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 270);
            Controls.Add(txmely);
            Controls.Add(txhossz);
            Controls.Add(txazon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbnev);
            Controls.Add(label1);
            Controls.Add(btmentes);
            Controls.Add(btkeres);
            Name = "Form1";
            Text = "Barlangok";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btkeres;
        private Button btmentes;
        private Label label1;
        private Label lbnev;
        private Label label3;
        private Label label4;
        private TextBox txazon;
        private TextBox txhossz;
        private TextBox txmely;
    }
}
