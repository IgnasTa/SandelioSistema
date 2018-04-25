using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class PridetiPrekes : Form
    {
        public PridetiPrekes()
        {
            InitializeComponent();
            dropTipas.DataSource = Cnst.DropTipai;
            dropTipas.DisplayMember = "Name";
            dropTipasPildymas.DataSource = Cnst.DropTipai;
            dropTipasPildymas.DisplayMember = "Name";
        }

        private void btnPrideti_Click(object sender, EventArgs e)
        {
            DropList tipas = dropTipas.SelectedItem as DropList;  
            Cnst.SqlCon.Open();
            string query = "INSERT INTO tblStorage (pavadinimas, kiekis, kaina, tipas) VALUES (@pavadinimas, @kiekis, @kaina, @tipas)";
            SqlCommand myCommand = new SqlCommand(query, Cnst.SqlCon);
            myCommand.Parameters.AddWithValue("@pavadinimas", txtPavadinimas.Text);
            myCommand.Parameters.AddWithValue("@kiekis", txtLikutis.Text);
            myCommand.Parameters.AddWithValue("@kaina", txtKaina.Text);
            myCommand.Parameters.AddWithValue("@tipas", tipas.Name);
            myCommand.ExecuteNonQuery();
            Cnst.SqlCon.Close();
            MessageBox.Show("Priregistruota preke");
            txtPavadinimas.Text = "";
            txtKaina.Text = "";
            txtLikutis.Text = "";
            dropTipas.Focus();
        }

        private void DropTipas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            DropList tipas = dropTipasPildymas.SelectedItem as DropList;
            if (tipas.Name == " ")
                query = "Select pavadinimas, kiekis, kaina from tblStorage";
            else
                query = "Select pavadinimas, kiekis, kaina from tblStorage Where tipas = '" + tipas.Name + "'";
            
            SqlDataAdapter sda = new SqlDataAdapter(query, Cnst.SqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            List<DropList> dropPavadinimas = new List<DropList>();
            for (int i = 0; i < dtbl.Rows.Count; i++)
            {
                dropPavadinimas.Add(new DropList()
                {
                    DoubleValue = Convert.ToDouble(dtbl.Rows[i][2]),  //kaina produkto
                    Title = String.Format("{0,-15}|{1,-9}|{2,7}",
                        dtbl.Rows[i][0],
                        dtbl.Rows[i][1] + " vnt.",
                        dtbl.Rows[i][2] + " €"),
                    Name = dtbl.Rows[i][0].ToString()
                });
            }
            this.dropPavadinimas.DataSource = dropPavadinimas;
            this.dropPavadinimas.DisplayMember = "Title";
        }

     

        private void Update(object sender, EventArgs e)
        {
            DropList tipas = dropTipas.SelectedItem as DropList;
            DropList pavadinimas = dropPavadinimas.SelectedItem as DropList;

            var query = "Select kiekis from tblStorage Where pavadinimas = '" + pavadinimas.Name + "'";
            var conn = new SqlDataAdapter(query, Cnst.SqlCon);
            DataTable dtbl1 = new DataTable();
            conn.Fill(dtbl1);
            int kiekis = Convert.ToInt32(dtbl1.Rows[0][0]);
            int likutis = kiekis + Convert.ToInt32(txtKiekisPildymas.Text);

            if (txtNewPrice.Text.Length > 0)
                query = "UPDATE tblStorage SET  kiekis = @kiekis, kaina = @kaina WHERE pavadinimas = @pavadinimas";
            else
                query = "UPDATE tblStorage SET  kiekis = @kiekis WHERE pavadinimas = @pavadinimas";

            Cnst.SqlCon.Open();
            SqlCommand myCommand = new SqlCommand(query, Cnst.SqlCon);
            myCommand.Parameters.AddWithValue("@pavadinimas", pavadinimas.Name);
            myCommand.Parameters.AddWithValue("@kiekis", likutis);
            myCommand.Parameters.AddWithValue("@kaina", txtNewPrice.Text);
            myCommand.ExecuteNonQuery();
            Cnst.SqlCon.Close();
            MessageBox.Show("Likutis Atnaujintas");
            dropPavadinimas.Focus();
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

        private void FormAddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Norėdami papildyti jau esančios sandelyje prekės likutį pasirinkite langą " +
                "'Papildyti Likuti' pasirinkite prekės tipą kad susiaurinti paiešką ir tada iš sarašo" +
                " išsirinkite prekę (galima nepasirinkti tipo, tuomet matysite visas prekes), ir iveskite" +
                " kiek vienetu bus papildytas prekes likutis \n\nNorėdami Užregistruoti dar nesančios prekės" +
                "] sandėlyje, pasirinkite langą'Prideti preke', pasirinkite pridedamos prekės tipą įrašykite " +
                "pavadinimą kiekį ir kainą ", "Pagalba");
        }

        
    }
}
