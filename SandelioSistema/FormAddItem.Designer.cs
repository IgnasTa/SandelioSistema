namespace SandelioSistema
{
    partial class FormAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddItem));
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dropPavadinimas = new System.Windows.Forms.ComboBox();
            this.dropTipasPildymas = new System.Windows.Forms.ComboBox();
            this.txtKiekisPildymas = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPrideti = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dropTipas = new System.Windows.Forms.ComboBox();
            this.txtLikutis = new System.Windows.Forms.TextBox();
            this.txtKaina = new System.Windows.Forms.TextBox();
            this.txtPavadinimas = new System.Windows.Forms.TextBox();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Grizti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dropPavadinimas);
            this.tabPage2.Controls.Add(this.dropTipasPildymas);
            this.tabPage2.Controls.Add(this.txtKiekisPildymas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(308, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Papildyti Likuti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Papildyti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Update);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Pasirinkite tipa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Kiekis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Pasirinkite Preke";
            // 
            // dropPavadinimas
            // 
            this.dropPavadinimas.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropPavadinimas.FormattingEnabled = true;
            this.dropPavadinimas.Location = new System.Drawing.Point(9, 70);
            this.dropPavadinimas.Name = "dropPavadinimas";
            this.dropPavadinimas.Size = new System.Drawing.Size(341, 21);
            this.dropPavadinimas.TabIndex = 30;
            // 
            // dropTipasPildymas
            // 
            this.dropTipasPildymas.FormattingEnabled = true;
            this.dropTipasPildymas.Location = new System.Drawing.Point(9, 30);
            this.dropTipasPildymas.Name = "dropTipasPildymas";
            this.dropTipasPildymas.Size = new System.Drawing.Size(198, 21);
            this.dropTipasPildymas.TabIndex = 29;
            this.dropTipasPildymas.SelectedIndexChanged += new System.EventHandler(this.DropTipas_SelectedIndexChanged);
            // 
            // txtKiekisPildymas
            // 
            this.txtKiekisPildymas.Location = new System.Drawing.Point(9, 110);
            this.txtKiekisPildymas.Name = "txtKiekisPildymas";
            this.txtKiekisPildymas.Size = new System.Drawing.Size(102, 20);
            this.txtKiekisPildymas.TabIndex = 31;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 279);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPrideti);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dropTipas);
            this.tabPage1.Controls.Add(this.txtLikutis);
            this.tabPage1.Controls.Add(this.txtKaina);
            this.tabPage1.Controls.Add(this.txtPavadinimas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(308, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prideti Preke";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPrideti
            // 
            this.btnPrideti.Location = new System.Drawing.Point(6, 188);
            this.btnPrideti.Name = "btnPrideti";
            this.btnPrideti.Size = new System.Drawing.Size(75, 23);
            this.btnPrideti.TabIndex = 45;
            this.btnPrideti.Text = "Prideti";
            this.btnPrideti.UseVisualStyleBackColor = true;
            this.btnPrideti.Click += new System.EventHandler(this.btnPrideti_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Pasirinkite tipa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kiekis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Irasykite kaina (optional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Irasykite pavadinima";
            // 
            // dropTipas
            // 
            this.dropTipas.FormattingEnabled = true;
            this.dropTipas.Location = new System.Drawing.Point(6, 19);
            this.dropTipas.Name = "dropTipas";
            this.dropTipas.Size = new System.Drawing.Size(198, 21);
            this.dropTipas.TabIndex = 40;
            // 
            // txtLikutis
            // 
            this.txtLikutis.Location = new System.Drawing.Point(6, 153);
            this.txtLikutis.Name = "txtLikutis";
            this.txtLikutis.Size = new System.Drawing.Size(102, 20);
            this.txtLikutis.TabIndex = 39;
            // 
            // txtKaina
            // 
            this.txtKaina.Location = new System.Drawing.Point(6, 105);
            this.txtKaina.Name = "txtKaina";
            this.txtKaina.Size = new System.Drawing.Size(102, 20);
            this.txtKaina.TabIndex = 38;
            // 
            // txtPavadinimas
            // 
            this.txtPavadinimas.Location = new System.Drawing.Point(6, 59);
            this.txtPavadinimas.Name = "txtPavadinimas";
            this.txtPavadinimas.Size = new System.Drawing.Size(198, 20);
            this.txtPavadinimas.TabIndex = 37;
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 343);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddItem";
            this.Text = "Papildyti sandeli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddItem_FormClosing);
            this.Load += new System.EventHandler(this.FormAddItem_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPrideti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropTipas;
        private System.Windows.Forms.TextBox txtLikutis;
        private System.Windows.Forms.TextBox txtKaina;
        private System.Windows.Forms.TextBox txtPavadinimas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dropPavadinimas;
        private System.Windows.Forms.ComboBox dropTipasPildymas;
        private System.Windows.Forms.TextBox txtKiekisPildymas;
    }
}