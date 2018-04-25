using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class Prisijungimas : Form
    {
        public Prisijungimas()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var passMd5 = Cnst.ToMd5(txtPassword.Text.Trim()); // pass pakeistas i md5 hash
            var query = "Select * from tblLogin Where username = '" + txtUserName.Text.Trim() + "' and password = '" + passMd5 + "'";
            var sda = new SqlDataAdapter(query, Cnst.SqlCon);
            var dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Check username and (or) password");
            }
            else
            {
                Cnst.User = txtUserName.Text.Trim();
                Cnst.alevel = Int32.Parse(dtbl.Rows[0]["level"].ToString()); // authorization level
                switch (Cnst.alevel)
                {
                    case 0:
                    {
                        var redirect = new PardavejoMeniu();
                        Hide();
                        redirect.Show();
                        break;
                    }

                    case 1:
                    {
                        var redirect = new SandelininkoMeniu();
                        Hide();
                        redirect.Show();
                        break;
                    }

                    case 2:
                    {
                        var redirect = new AdministratoriausMeniu();
                        Hide();
                        redirect.Show();
                        break;
                    }
                }
            }
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            var redirect = new Registracija();
            Hide();
            redirect.Show();
        }

        private void FormLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void help(object sender, EventArgs e)
        {
            MessageBox.Show("Darbą sukūrė Ignas Tamašauskas, P-6/1R grupes mokinys \n \nŠi programa skirta tvarkyti parduotuvės" +
                " duomenis. \n \nNorėdami pradėti iveskite prisijungimo duomenis ir spauskite 'Prisijungti'" +
                " arba susikurkite paskyrą spausdami 'Užsiregistruoti'.", "Pagalba");
        }
    }
}
