using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            comboBox1.DataSource = Cnst.DropAutorizacija;   //automatiskai uzpildo datagridview uzkrovus
            comboBox1.DisplayMember = "Name";
        }
        bool c;
        void check()
        {
            if (txtSignInPassword.Text.Trim() == txtPasswordRepeat.Text.Trim())
                c = true;
            else
                c = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormLogIn redirect = new FormLogIn();
            this.Hide();
            redirect.Show();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            DropList level = comboBox1.SelectedItem as DropList;
            string pass = txtSignInPassword.Text.Trim();
            string hashPass = Cnst.ToMd5(pass);
            int authorization = Convert.ToInt32(level.Value);
            if (c)
            {
                Cnst.SqlCon.Open();
                string query = "INSERT INTO tblLogin (username, password, level) VALUES (@username, @password , @level)";
                SqlCommand myCommand = new SqlCommand(query, Cnst.SqlCon);
                myCommand.Parameters.AddWithValue("@username", txtSignInName.Text);
                myCommand.Parameters.AddWithValue("@password", hashPass);
                myCommand.Parameters.AddWithValue("@level", authorization);
                myCommand.ExecuteNonQuery();
                Cnst.SqlCon.Close();
                FormLogIn redirect = new FormLogIn();
                this.Hide();
                redirect.Show();
                MessageBox.Show("Priregistruota");
            }
        }

        private void RepeatPassword(object sender, EventArgs e)
        {

            check();
            if (c)
                textBox1.Text = " ";
            else 
                textBox1.Text = "Slaptazodis nesutampa";
        }

        private void FormSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }
    }
}
