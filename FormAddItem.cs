using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class FormAddItem : Form
    {
        public FormAddItem()
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
            MessageBox.Show("Priregistruota preke");
        }

        private void DropTipas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            DropList tipas = dropTipas.SelectedItem as DropList;
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

            MessageBox.Show(pavadinimas.Name);

            var query = "Select kiekis from tblStorage Where pavadinimas = '" + pavadinimas.Name + "'";
            var conn = new SqlDataAdapter(query, Cnst.SqlCon);
            DataTable dtbl1 = new DataTable();
            conn.Fill(dtbl1);
            int kiekis = Convert.ToInt32(dtbl1.Rows[0][0]);
            int likutis = kiekis + Convert.ToInt32(txtKiekisPildymas.Text);
            MessageBox.Show("Kiekis: " + kiekis + " likutis: " + likutis);
        
            Cnst.SqlCon.Open();
            query = "UPDATE tblStorage SET  kiekis = @kiekis WHERE pavadinimas = @pavadinimas";
            SqlCommand myCommand = new SqlCommand(query, Cnst.SqlCon);
            myCommand.Parameters.AddWithValue("@pavadinimas", pavadinimas.Name);
            myCommand.Parameters.AddWithValue("@kiekis", likutis);
            myCommand.ExecuteNonQuery();
            MessageBox.Show("Likutis Atnaujintas");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (Cnst.alevel)
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
            }
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {

        }

        private void FormAddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }
    }
}
