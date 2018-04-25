using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class IstrintiPrekes : Form
    {
        public IstrintiPrekes()
        {
            InitializeComponent();
            deleteTipas.DataSource = Cnst.DropTipai;
            deleteTipas.DisplayMember = "Name";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DropList pavadinimas = deletePavadinimas.SelectedItem as DropList;
            var query = "DELETE FROM tblStorage  WHERE pavadinimas = '" + pavadinimas.Name + "'";
            Cnst.SqlCon.Open();
            SqlCommand myCommand = new SqlCommand(query, Cnst.SqlCon);
            myCommand.ExecuteNonQuery();
            Cnst.SqlCon.Close();
            MessageBox.Show("Prekė sėkmingai ištrinta");
        }

        private void delTipas_SelectedIndexChanged(object sender, EventArgs e)
        {           
            string query;
            DropList tipas = deleteTipas.SelectedItem as DropList;
            if (tipas.Name == " ")
                query = "Select pavadinimas, kiekis, kaina from tblStorage";
            else
                query = "Select pavadinimas, kiekis, kaina from tblStorage Where tipas = '" + tipas.Name + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, Cnst.SqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            List<DropList> deletePavadinimas = new List<DropList>();
            for (int i = 0; i < dtbl.Rows.Count; i++)
            {
                deletePavadinimas.Add(new DropList()
                {
                    DoubleValue = Convert.ToDouble(dtbl.Rows[i][2]),  //kaina produkto
                    Title = String.Format("{0,-15}|{1,-9}|{2,7}",
                        dtbl.Rows[i][0],
                        dtbl.Rows[i][1] + " vnt.",
                        dtbl.Rows[i][2] + " €"),
                    Name = dtbl.Rows[i][0].ToString()
                });
            }
            this.deletePavadinimas.DataSource = deletePavadinimas;
            this.deletePavadinimas.DisplayMember = "Title";
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Norėdami ištrinti prekes iš sandėlio pasirinkite ir spauskite 'Ištrinti'", "Pagalba");
        }
    }
}
