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
    public partial class FormSell : Form
    {
        public FormSell()
        {
            InitializeComponent();
            List<DropList> dropAkcija = new List<DropList>
            {
                new DropList() {DoubleValue = 0, Name = ""},
                new DropList() {DoubleValue = 0.05, Name = "5% Nuolaida"},
                new DropList() {DoubleValue = 0.1, Name = "10% Nuolaida"},
                new DropList() {DoubleValue = 0.15, Name = "15% Nuolaida"}
            };

            comboBox2.DataSource = dropAkcija;
            comboBox2.DisplayMember = "Name";

            dropTipas.DataSource = Cnst.DropTipai;
            dropTipas.DisplayMember = "Name";
        }

        private void DropTipas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropList lvl = dropTipas.SelectedItem as DropList;
            string query = "Select pavadinimas, kaina from tblStorage Where tipas = '" + lvl.Name + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Cnst.SqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            List<DropList> dropPavadinimas = new List<DropList>();
            for (int i = 0; i < dtbl.Rows.Count; i++)
                dropPavadinimas.Add(new DropList() { DoubleValue = Convert.ToDouble(dtbl.Rows[i][1]), Name = dtbl.Rows[i][0].ToString() });
            comboBox1.DataSource = dropPavadinimas;
            comboBox1.DisplayMember = "Name";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DropList pavDropList = comboBox1.SelectedItem as DropList;
            DropList nuolaidaDropList = comboBox2.SelectedItem as DropList;
            int kiekis = Convert.ToInt32(txtKiekis.Text);
            double nuolaida = nuolaidaDropList.DoubleValue;
            double price = pavDropList.DoubleValue * kiekis * (1 - nuolaida);
            double akcija = pavDropList.DoubleValue * kiekis * nuolaida;
            txtKaina.Text = price.ToString();
            label5.Text = "Suteikta nuolaida: " + akcija.ToString();

            string query = "Select prekesId from tblStorage Where pavadinimas = '" + pavDropList.Name + "'";
            SqlCommand cmd1 = new SqlCommand(query, Cnst.SqlCon);
            int prekesId = Convert.ToInt32(cmd1.ExecuteScalar());
            query = "INSERT INTO tblSellLog (prekesId, kiekis, nuolaida) VALUES ('"+ prekesId + "', '" + kiekis + "', '" + nuolaida + "')" + "Update kiekis From tblStorage Where prekesId = '"+ prekesId +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Cnst.SqlCon);

        }
    }
}