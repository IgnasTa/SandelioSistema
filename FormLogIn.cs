using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
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
                var alevel = Int32.Parse(dtbl.Rows[0]["level"].ToString()); // authorization level
                switch (alevel)
                {
                    case 0:
                        {
                            var redirect = new FormMain0();
                            Hide();
                            redirect.Show();
                            break;
                        }

                    case 1:
                        {
                            var redirect = new FormMain1();
                            Hide();
                            redirect.Show();
                            break;
                        }

                    case 2:
                        {
                            var redirect = new FormMain2();
                            Hide();
                            redirect.Show();
                            break;
                        }

                    default:
                        MessageBox.Show("Check username and (or) password");
                        break;
                }
            }
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            var redirect = new FormSignIn();
            Hide();
            redirect.Show();
        }
    }
}
