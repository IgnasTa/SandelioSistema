using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class VartotojuRedagavimas : Form
    {
        public VartotojuRedagavimas()
        {
            InitializeComponent();
        }

        private void Keisti_Click(object sender, EventArgs e)
        {
            if (Cnst.alevel != 2) { 
                if (txtOldName.Text.Length > 0 && txtOldPass.Text.Length > 0)
                {

                    var pass = Cnst.ToMd5(txtOldPass.Text);
                    var query = "SELECT password from tblLogin where username = '" + txtOldName.Text + "'";// AND SELECT password from tblLogin where username = '" + txtNewName.Text + "'";
                    var sda = new SqlDataAdapter(query, Cnst.SqlCon);
                    var dtbl = new DataTable();
                    sda.Fill(dtbl);
                    var passCheck = dtbl.Rows[0][0].ToString();

                    if (passCheck == pass && Cnst.User == txtOldName.Text)
                    {
                        if (txtNewPass.Text.Length > 0 && txtNewName.Text.Length > 0)
                        {
                            Cnst.SqlCon.Open();
                            query = "UPDATE tblLogin SET password = '" + pass + "' and username = '" + txtNewName.Text + "' WHERE username = '" + txtOldName.Text + "' ";
                            var myCommand = new SqlCommand(query, Cnst.SqlCon);
                            myCommand.ExecuteNonQuery();
                            Cnst.SqlCon.Close();
                            Cnst.User = txtNewName.Text;
                        }
                        else
                        {
                            Cnst.SqlCon.Open();
                            query = "UPDATE tblLogin SET password = '" + pass + "' WHERE username = '" + txtOldName.Text + "' ";
                            var myCommand = new SqlCommand(query, Cnst.SqlCon);
                            myCommand.ExecuteNonQuery();
                            Cnst.SqlCon.Close();
                        }
                        MessageBox.Show("Duomenys sėkmingai pakeisti");
                    }
                }
            }
            else
            {
                if (txtNewPass.Text.Length > 0 && txtNewName.Text.Length > 0)
                {
                    Cnst.SqlCon.Open();
                    var query = "UPDATE tblLogin SET password = '" + Cnst.ToMd5(txtNewPass.Text) + "' and username = '" + txtNewName.Text + "' WHERE username = '" + txtOldName.Text + "' ";
                    var myCommand = new SqlCommand(query, Cnst.SqlCon);
                    myCommand.ExecuteNonQuery();
                    Cnst.SqlCon.Close();
                    Cnst.User = txtNewName.Text;
                    MessageBox.Show("Duomenys sėkmingai pakeisti");
                }
                else if (txtNewPass.Text.Length > 0)
                {
                    Cnst.SqlCon.Open();
                    var query = "UPDATE tblLogin SET password = '" + Cnst.ToMd5(txtNewPass.Text) + "' WHERE username = '" + txtOldName.Text + "' ";
                    var myCommand = new SqlCommand(query, Cnst.SqlCon);
                    myCommand.ExecuteNonQuery();
                    Cnst.SqlCon.Close();
                    MessageBox.Show("Duomenys sėkmingai pakeisti");
                }
                
            }
        }
        private void Return_Click(object sender, EventArgs e)
        {
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

                default:
                {
                    var redirect = new Prisijungimas();
                    Hide();
                    redirect.Show();
                    break;
                }
            }
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void hel(object sender, EventArgs e)
        {
           MessageBox.Show("Norėdami pakeisti paskyros vardą ar slaptažodį pirma turite įrašyti dabartinius prisijungimo duomenis ir užpildyti laukelius " +
               "'Naujas slaptažodis' ir (nebūtina) 'Naujas prisijungimo vardas'" +
               "\n\nPrisijungimo duomenis Administratorius gali keisti turėdamas tik prisijungimo vardą " , "Pagalba");
        }
    }
}
