using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
            comboBox1.DataSource = Cnst.DropAutorizacija;   //automatiskai uzpildo combobox uzkrovus
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

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            var query = "Select * from tblLogin Where username = '" + txtSignInName.Text.Trim() + "'";
            var con = new SqlDataAdapter(query, Cnst.SqlCon);
            var check = new DataTable();
            con.Fill(check);
            if (check.Rows.Count == 0)
            {
                MessageBox.Show("Vartotojas tokiu prisijungimo vardu jau yra");
            }
            else
            {
                DropList level = comboBox1.SelectedItem as DropList;
                string pass = txtSignInPassword.Text.Trim();
                string hashPass = Cnst.ToMd5(pass);
                int authorization = Convert.ToInt32(level.Value);
                if (c)
                {
                    Cnst.SqlCon.Open();
                    query = "INSERT INTO tblLogin (username, password, level) VALUES (@username, @password , @level)";
                    SqlCommand myCommand = new SqlCommand(query, Cnst.SqlCon);
                    myCommand.Parameters.AddWithValue("@username", txtSignInName.Text);
                    myCommand.Parameters.AddWithValue("@password", hashPass);
                    myCommand.Parameters.AddWithValue("@level", authorization);
                    myCommand.ExecuteNonQuery();
                    Cnst.SqlCon.Close();
                    Prisijungimas redirect = new Prisijungimas();
                    this.Hide();
                    redirect.Show();
                    MessageBox.Show("Priregistruota");
                }
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Prisijungimas redirect = new Prisijungimas();
            this.Hide();
            redirect.Show();
        }

        private void FormSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void help(object sender, EventArgs e)
        {
            MessageBox.Show("Norėdami susikurti paskyrą iveskite prisijungimo vardą, slaptažodį, jį pakartokite" +
                " ir spustelikte 'Sukurti Paskyrą' \n\nNoredami grįžti į prisijungimo langa " +
                "spustelkite 'Grižti į prisijungimą'" , "Pagalba");
        }
    }
}
