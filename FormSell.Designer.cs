namespace SandelioSistema
{
    partial class FormSell
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dropTipas = new System.Windows.Forms.ComboBox();
            this.txtKiekis = new System.Windows.Forms.TextBox();
            this.txtKaina = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.pav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kaina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kiekis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Suskaiciuoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Pasirinkite tipa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kiekis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kaina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pasirinkite Preke";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // dropTipas
            // 
            this.dropTipas.FormattingEnabled = true;
            this.dropTipas.Location = new System.Drawing.Point(12, 36);
            this.dropTipas.Name = "dropTipas";
            this.dropTipas.Size = new System.Drawing.Size(198, 21);
            this.dropTipas.TabIndex = 19;
            this.dropTipas.SelectedIndexChanged += new System.EventHandler(this.DropTipas_SelectedIndexChanged);
            // 
            // txtKiekis
            // 
            this.txtKiekis.Location = new System.Drawing.Point(12, 116);
            this.txtKiekis.Name = "txtKiekis";
            this.txtKiekis.Size = new System.Drawing.Size(102, 20);
            this.txtKiekis.TabIndex = 21;
            // 
            // txtKaina
            // 
            this.txtKaina.Location = new System.Drawing.Point(12, 159);
            this.txtKaina.Name = "txtKaina";
            this.txtKaina.Size = new System.Drawing.Size(102, 20);
            this.txtKaina.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Uzsakyti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Atgal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Return_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.Control;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pav,
            this.kaina,
            this.kiekis,
            this.Suma});
            this.listView.Location = new System.Drawing.Point(359, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(323, 221);
            this.listView.TabIndex = 30;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // pav
            // 
            this.pav.Text = "Pavadinimas";
            this.pav.Width = 122;
            // 
            // kaina
            // 
            this.kaina.Text = "Kaina";
            // 
            // kiekis
            // 
            this.kiekis.Text = "Kiekis";
            this.kiekis.Width = 67;
            // 
            // Suma
            // 
            this.Suma.Text = "Suma";
            this.Suma.Width = 73;
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(581, 239);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(89, 23);
            this.clearList.TabIndex = 31;
            this.clearList.Text = "Isvalyti krepseli";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.Click_clearList);
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 295);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dropTipas);
            this.Controls.Add(this.txtKiekis);
            this.Controls.Add(this.txtKaina);
            this.Name = "FormSell";
            this.Text = "FormSell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSell_FormClosing);
            this.Load += new System.EventHandler(this.DropTipas_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox dropTipas;
        private System.Windows.Forms.TextBox txtKiekis;
        private System.Windows.Forms.TextBox txtKaina;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader pav;
        private System.Windows.Forms.ColumnHeader kaina;
        private System.Windows.Forms.ColumnHeader kiekis;
        private System.Windows.Forms.ColumnHeader Suma;
        private System.Windows.Forms.Button clearList;
    }
}