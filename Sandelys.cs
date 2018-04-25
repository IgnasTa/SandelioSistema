using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class Sandelys : Form
    {
        public Sandelys()
        {
            InitializeComponent();
            string query = "Select * from tblStorage";
            showData(query, Cnst.SqlCon);
            dropParameter.DataSource = Cnst.DropTipai;
            dropParameter.DisplayMember = "Name";
        }

        //------------------------------------------------------------
        private void showData(string query, SqlConnection sqlcon)
        {
            gridStorage.Rows.Clear();
            SqlDataAdapter data = new SqlDataAdapter(query, sqlcon);
            DataTable tableStorage = new DataTable();
            data.Fill(tableStorage);
            for (int i = 0; i < tableStorage.Rows.Count; i++)
            {
                gridStorage.Rows.Add();
                gridStorage.Rows[i].Cells[0].Value = tableStorage.Rows[i][0];
                gridStorage.Rows[i].Cells[1].Value = tableStorage.Rows[i][1];
                gridStorage.Rows[i].Cells[2].Value = tableStorage.Rows[i][2];
                gridStorage.Rows[i].Cells[3].Value = tableStorage.Rows[i][3];
                gridStorage.Rows[i].Cells[4].Value = tableStorage.Rows[i][4];
            }
        }
        //-------------------------------------------------------------
        private void StorageParameter_Click(object sender, EventArgs e)
        {
            string query = "Select * from tblStorage Where pavadinimas = '" + txtStorageParameter.Text.Trim() + "'";
            showData(query, Cnst.SqlCon);
        }
        
        private void Search_Click(object sender, EventArgs e)
        {
            DropList dropTipas = dropParameter.SelectedItem as DropList;
            int pprice = 0, ptype = 0;
            string query = "Select * from tblStorage";

            if (txtValueMin.Text.Length > 0 && txtValueMax.Text.Length > 0)
                pprice = 1;

            if (dropTipas.Name != " ")
                ptype = 1;
                        
            if (pprice == 1 && ptype == 1)
            {
                int Min = Convert.ToInt32(txtValueMin.Text.Trim());
                int Max = Convert.ToInt32(txtValueMax.Text.Trim());
                query = "Select * from tblStorage Where tipas = '" + dropTipas.Name + "' and kaina >= '" + Min + "' and kaina <= '" + Max + "'";
            }

            if (pprice == 1 && ptype == 0)
            {
                int Min = Convert.ToInt32(txtValueMin.Text.Trim());
                int Max = Convert.ToInt32(txtValueMax.Text.Trim());
                query = "Select * from tblStorage Where kaina >= '" + Min + "' and kaina <= '" + Max + "'";
            }
            
            if (pprice == 0 && ptype == 1)
            {
                query = "Select * from tblStorage Where tipas = '" + dropTipas.Name + "'";
            }

            showData(query, Cnst.SqlCon);
        }        

        private void button1_Click(object sender, EventArgs e)
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

        private void FormStorage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Norėdami ieškoti pagal pavadinimą iveskite pavadinimą \n\n" +
                "Norėdami žiūrėti sandėlio likučius pagal prekių kainas arba tipą užpildykite " +
                "laukelius ir spauskite 'Pasirinkti' \n\nNorėdami grįžti į meniu spauskite 'Grįžti į meniu'", "Pagalba");
        }
    }
}
