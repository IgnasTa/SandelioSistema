namespace SandelioSistema
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtPasswordRepeat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSignInPassword = new System.Windows.Forms.TextBox();
            this.txtSignInName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(300, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 13);
            this.textBox1.TabIndex = 23;
            this.textBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(117, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Authorization";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(300, 172);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(117, 142);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(106, 23);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // txtPasswordRepeat
            // 
            this.txtPasswordRepeat.Location = new System.Drawing.Point(117, 74);
            this.txtPasswordRepeat.MaxLength = 30;
            this.txtPasswordRepeat.Name = "txtPasswordRepeat";
            this.txtPasswordRepeat.Size = new System.Drawing.Size(158, 20);
            this.txtPasswordRepeat.TabIndex = 3;
            this.txtPasswordRepeat.UseSystemPasswordChar = true;
            this.txtPasswordRepeat.WordWrap = false;
            this.txtPasswordRepeat.TextChanged += new System.EventHandler(this.RepeatPassword);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Repeat password";
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.Location = new System.Drawing.Point(117, 48);
            this.txtSignInPassword.MaxLength = 30;
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.Size = new System.Drawing.Size(158, 20);
            this.txtSignInPassword.TabIndex = 2;
            this.txtSignInPassword.UseSystemPasswordChar = true;
            this.txtSignInPassword.WordWrap = false;
            // 
            // txtSignInName
            // 
            this.txtSignInName.Location = new System.Drawing.Point(117, 22);
            this.txtSignInName.MaxLength = 30;
            this.txtSignInName.Name = "txtSignInName";
            this.txtSignInName.Size = new System.Drawing.Size(158, 20);
            this.txtSignInName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username";
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtPasswordRepeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSignInPassword);
            this.Controls.Add(this.txtSignInName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSignIn";
            this.Text = "Uzsiregistruoti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSignIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtPasswordRepeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSignInPassword;
        private System.Windows.Forms.TextBox txtSignInName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}