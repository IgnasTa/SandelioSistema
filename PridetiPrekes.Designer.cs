namespace SandelioSistema
{
    partial class PridetiPrekes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PridetiPrekes));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtKiekisPildymas = new System.Windows.Forms.TextBox();
            this.dropTipasPildymas = new System.Windows.Forms.ComboBox();
            this.dropPavadinimas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPavadinimas = new System.Windows.Forms.TextBox();
            this.txtKaina = new System.Windows.Forms.TextBox();
            this.txtLikutis = new System.Windows.Forms.TextBox();
            this.dropTipas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrideti = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Grįžti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::SandelioSistema.Properties.Resources.help;
            this.button3.Location = new System.Drawing.Point(3, 293);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtNewPrice);
            this.tabPage2.Controls.Add(this.txtKiekisPildymas);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dropPavadinimas);
            this.tabPage2.Controls.Add(this.dropTipasPildymas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(401, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Papildyti Likuti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtKiekisPildymas
            // 
            this.txtKiekisPildymas.Location = new System.Drawing.Point(9, 110);
            this.txtKiekisPildymas.Name = "txtKiekisPildymas";
            this.txtKiekisPildymas.Size = new System.Drawing.Size(102, 20);
            this.txtKiekisPildymas.TabIndex = 3;
            // 
            // dropTipasPildymas
            // 
            this.dropTipasPildymas.FormattingEnabled = true;
            this.dropTipasPildymas.Location = new System.Drawing.Point(9, 30);
            this.dropTipasPildymas.Name = "dropTipasPildymas";
            this.dropTipasPildymas.Size = new System.Drawing.Size(198, 21);
            this.dropTipasPildymas.TabIndex = 1;
            this.dropTipasPildymas.SelectedIndexChanged += new System.EventHandler(this.DropTipas_SelectedIndexChanged);
            // 
            // dropPavadinimas
            // 
            this.dropPavadinimas.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropPavadinimas.FormattingEnabled = true;
            this.dropPavadinimas.Location = new System.Drawing.Point(9, 70);
            this.dropPavadinimas.Name = "dropPavadinimas";
            this.dropPavadinimas.Size = new System.Drawing.Size(341, 21);
            this.dropPavadinimas.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Pasirinkite Prekę";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Pasirinkite tipą";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Papildyti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Update);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(9, 156);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(100, 20);
            this.txtNewPrice.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Atnaujinti Kainą (nebūtina)";
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
            this.tabPage1.Size = new System.Drawing.Size(401, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prideti Preke";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPavadinimas
            // 
            this.txtPavadinimas.Location = new System.Drawing.Point(6, 59);
            this.txtPavadinimas.Name = "txtPavadinimas";
            this.txtPavadinimas.Size = new System.Drawing.Size(198, 20);
            this.txtPavadinimas.TabIndex = 2;
            // 
            // txtKaina
            // 
            this.txtKaina.Location = new System.Drawing.Point(6, 105);
            this.txtKaina.Name = "txtKaina";
            this.txtKaina.Size = new System.Drawing.Size(102, 20);
            this.txtKaina.TabIndex = 3;
            // 
            // txtLikutis
            // 
            this.txtLikutis.Location = new System.Drawing.Point(6, 153);
            this.txtLikutis.Name = "txtLikutis";
            this.txtLikutis.Size = new System.Drawing.Size(102, 20);
            this.txtLikutis.TabIndex = 4;
            // 
            // dropTipas
            // 
            this.dropTipas.FormattingEnabled = true;
            this.dropTipas.Location = new System.Drawing.Point(6, 19);
            this.dropTipas.Name = "dropTipas";
            this.dropTipas.Size = new System.Drawing.Size(198, 21);
            this.dropTipas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Irašykite pavadinimą";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Kaina";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Pasirinkite tipą";
            // 
            // btnPrideti
            // 
            this.btnPrideti.Location = new System.Drawing.Point(6, 188);
            this.btnPrideti.Name = "btnPrideti";
            this.btnPrideti.Size = new System.Drawing.Size(75, 23);
            this.btnPrideti.TabIndex = 5;
            this.btnPrideti.Text = "Pridėti";
            this.btnPrideti.UseVisualStyleBackColor = true;
            this.btnPrideti.Click += new System.EventHandler(this.btnPrideti_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 289);
            this.tabControl1.TabIndex = 6;
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 343);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddItem";
            this.Text = "Papildyti sandelį";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddItem_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.TextBox txtKiekisPildymas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dropPavadinimas;
        private System.Windows.Forms.ComboBox dropTipasPildymas;
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
        private System.Windows.Forms.TabControl tabControl1;
    }
}