namespace SandelioSistema
{
    partial class Sandelys
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sandelys));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValueMax = new System.Windows.Forms.TextBox();
            this.txtValueMin = new System.Windows.Forms.TextBox();
            this.dropParameter = new System.Windows.Forms.ComboBox();
            this.gridStorage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStorageParameter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStorageParameter = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(4, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pasirinkite kaina (nuo ; iki)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(4, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pasirinkite tipa";
            // 
            // txtValueMax
            // 
            this.txtValueMax.Location = new System.Drawing.Point(142, 176);
            this.txtValueMax.Name = "txtValueMax";
            this.txtValueMax.Size = new System.Drawing.Size(90, 20);
            this.txtValueMax.TabIndex = 6;
            // 
            // txtValueMin
            // 
            this.txtValueMin.Location = new System.Drawing.Point(7, 176);
            this.txtValueMin.Name = "txtValueMin";
            this.txtValueMin.Size = new System.Drawing.Size(90, 20);
            this.txtValueMin.TabIndex = 5;
            // 
            // dropParameter
            // 
            this.dropParameter.FormattingEnabled = true;
            this.dropParameter.Location = new System.Drawing.Point(7, 123);
            this.dropParameter.Name = "dropParameter";
            this.dropParameter.Size = new System.Drawing.Size(225, 21);
            this.dropParameter.TabIndex = 3;
            // 
            // gridStorage
            // 
            this.gridStorage.AllowDrop = true;
            this.gridStorage.AllowUserToAddRows = false;
            this.gridStorage.AllowUserToDeleteRows = false;
            this.gridStorage.AllowUserToResizeColumns = false;
            this.gridStorage.AllowUserToResizeRows = false;
            this.gridStorage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridStorage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStorage.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridStorage.GridColor = System.Drawing.SystemColors.Control;
            this.gridStorage.Location = new System.Drawing.Point(238, -2);
            this.gridStorage.Name = "gridStorage";
            this.gridStorage.ReadOnly = true;
            this.gridStorage.RowHeadersVisible = false;
            this.gridStorage.RowTemplate.Height = 25;
            this.gridStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStorage.Size = new System.Drawing.Size(650, 382);
            this.gridStorage.TabIndex = 0;
            this.gridStorage.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Prekės Pavadinimas";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 290;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kaina";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kiekis";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 125F;
            this.Column5.HeaderText = "Tipas";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // btnStorageParameter
            // 
            this.btnStorageParameter.Location = new System.Drawing.Point(7, 57);
            this.btnStorageParameter.Name = "btnStorageParameter";
            this.btnStorageParameter.Size = new System.Drawing.Size(75, 23);
            this.btnStorageParameter.TabIndex = 2;
            this.btnStorageParameter.Text = "Paieška";
            this.btnStorageParameter.UseVisualStyleBackColor = true;
            this.btnStorageParameter.Click += new System.EventHandler(this.StorageParameter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Iveskite pavadinima";
            // 
            // txtStorageParameter
            // 
            this.txtStorageParameter.Location = new System.Drawing.Point(7, 31);
            this.txtStorageParameter.Name = "txtStorageParameter";
            this.txtStorageParameter.Size = new System.Drawing.Size(225, 20);
            this.txtStorageParameter.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(7, 222);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 23;
            this.Search.Text = "Paieška";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Grižti į meniu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::SandelioSistema.Properties.Resources.help;
            this.button2.Location = new System.Drawing.Point(12, 322);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sandelys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(889, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValueMax);
            this.Controls.Add(this.txtValueMin);
            this.Controls.Add(this.dropParameter);
            this.Controls.Add(this.gridStorage);
            this.Controls.Add(this.btnStorageParameter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStorageParameter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sandelys";
            this.Text = "Sandelio likuciai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStorage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValueMax;
        private System.Windows.Forms.TextBox txtValueMin;
        private System.Windows.Forms.ComboBox dropParameter;
        private System.Windows.Forms.Button btnStorageParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStorageParameter;
        private System.Windows.Forms.DataGridView gridStorage;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
    }
}