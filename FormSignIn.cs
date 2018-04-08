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
            if (txtSignInPassword.Text.Trim() == txtPasswordRepeat.Text.Trim())
            {
                Cnst.SqlCon.Open();
                string query = "INSERT INTO tblLogin (username, password, level) VALUES (@username, @password , @level)";
                SqlCommand myCommand = new SqlCommand(query, Cnst.SqlCon);
                myCommand.Parameters.AddWithValue("@username", txtSignInName.Text);
                myCommand.Parameters.AddWithValue("@password", hashPass);
                myCommand.Parameters.AddWithValue("@level", authorization);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Priregistruota");
            }
        }

        private void RepeatPassword(object sender, EventArgs e)
        {
            if (txtSignInPassword.Text.Trim() == txtPasswordRepeat.Text.Trim())
                textBox1.Text = " ";

            else if (txtSignInPassword.Text.Trim() != txtPasswordRepeat.Text.Trim())
                textBox1.Text = "Doesn't match";
        }

        private void FormSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }
    }
}
