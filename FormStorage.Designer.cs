namespace SandelioSistema
{
    partial class FormStorage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValueMax = new System.Windows.Forms.TextBox();
            this.txtValueMin = new System.Windows.Forms.TextBox();
            this.dropParameter = new System.Windows.Forms.ComboBox();
            this.gridStorage = new System.Windows.Forms.DataGridView();
            this.btnValue = new System.Windows.Forms.Button();
            this.btnDropList = new System.Windows.Forms.Button();
            this.btnStorageParameter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStorageParameter = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(4, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pasirinkite kaina (nuo ; iki)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pasirinkite tipa";
            // 
            // txtValueMax
            // 
            this.txtValueMax.Location = new System.Drawing.Point(104, 221);
            this.txtValueMax.Name = "txtValueMax";
            this.txtValueMax.Size = new System.Drawing.Size(75, 20);
            this.txtValueMax.TabIndex = 19;
            // 
            // txtValueMin
            // 
            this.txtValueMin.Location = new System.Drawing.Point(10, 221);
            this.txtValueMin.Name = "txtValueMin";
            this.txtValueMin.Size = new System.Drawing.Size(75, 20);
            this.txtValueMin.TabIndex = 20;
            // 
            // dropParameter
            // 
            this.dropParameter.FormattingEnabled = true;
            this.dropParameter.Location = new System.Drawing.Point(10, 123);
            this.dropParameter.Name = "dropParameter";
            this.dropParameter.Size = new System.Drawing.Size(225, 21);
            this.dropParameter.TabIndex = 18;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStorage.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridStorage.GridColor = System.Drawing.SystemColors.Control;
            this.gridStorage.Location = new System.Drawing.Point(241, -2);
            this.gridStorage.Name = "gridStorage";
            this.gridStorage.ReadOnly = true;
            this.gridStorage.RowHeadersVisible = false;
            this.gridStorage.RowTemplate.Height = 25;
            this.gridStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStorage.Size = new System.Drawing.Size(637, 371);
            this.gridStorage.TabIndex = 17;
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(10, 150);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(75, 23);
            this.btnValue.TabIndex = 14;
            this.btnValue.Text = "Paieska";
            this.btnValue.UseVisualStyleBackColor = true;
            // 
            // btnDropList
            // 
            this.btnDropList.Location = new System.Drawing.Point(10, 247);
            this.btnDropList.Name = "btnDropList";
            this.btnDropList.Size = new System.Drawing.Size(75, 23);
            this.btnDropList.TabIndex = 15;
            this.btnDropList.Text = "Paieska";
            this.btnDropList.UseVisualStyleBackColor = true;
            // 
            // btnStorageParameter
            // 
            this.btnStorageParameter.Location = new System.Drawing.Point(7, 57);
            this.btnStorageParameter.Name = "btnStorageParameter";
            this.btnStorageParameter.Size = new System.Drawing.Size(75, 23);
            this.btnStorageParameter.TabIndex = 16;
            this.btnStorageParameter.Text = "Paieska";
            this.btnStorageParameter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(7, 12);
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
            this.txtStorageParameter.TabIndex = 12;
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
            this.Column2.HeaderText = "Prekes Pavadinimas";
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
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValueMax);
            this.Controls.Add(this.txtValueMin);
            this.Controls.Add(this.dropParameter);
            this.Controls.Add(this.gridStorage);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnDropList);
            this.Controls.Add(this.btnStorageParameter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStorageParameter);
            this.Name = "FormStorage";
            this.Text = "FormStorage";
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
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnDropList;
        private System.Windows.Forms.Button btnStorageParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStorageParameter;
        private System.Windows.Forms.DataGridView gridStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}