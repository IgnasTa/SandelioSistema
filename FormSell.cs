using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class FormSell : Form
    {
        public static int prekesId;
        public static int kiekis;
        public static double nuolaida;
        public static double price;
        public static int likutis;

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
            string query;
            DropList lvl = dropTipas.SelectedItem as DropList;
            if (lvl.Name == " ")
            {
                query = "Select pavadinimas, kiekis, kaina from tblStorage";
            }
            else
            {
                query = "Select pavadinimas, kiekis, kaina from tblStorage Where tipas = '" + lvl.Name + "'";
            }
            
            SqlDataAdapter sda = new SqlDataAdapter(query, Cnst.SqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            List<DropList> dropPavadinimas = new List<DropList>();

            for (int i = 0; i < dtbl.Rows.Count; i++)
            { 
                dropPavadinimas.Add(new DropList() {
                    DoubleValue = Convert.ToDouble(dtbl.Rows[i][2]),  //kaina produkto
                    Title = String.Format("{0,-15}|{1,-9}|{2,7}",
                           dtbl.Rows[i][0] , 
                           dtbl.Rows[i][1] + " vnt.",
                           dtbl.Rows[i][2] + " €"),
                    Name = dtbl.Rows[i][0].ToString()
                });
            }
            comboBox1.DataSource = dropPavadinimas;
            comboBox1.DisplayMember = "Title";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            DropList pavDropList = comboBox1.SelectedItem as DropList;
            DropList nuolaidaDropList = comboBox2.SelectedItem as DropList;
            kiekis = Convert.ToInt32(txtKiekis.Text);                           // kiekis - kiekis nupirktu prekiu
            nuolaida = nuolaidaDropList.DoubleValue;                            // nuolaida - pritaikyta nuolaida (%)
            price = pavDropList.DoubleValue * kiekis * (1 - nuolaida);          // price - kaina viso pirkinio
            double akcija = pavDropList.DoubleValue * kiekis * nuolaida;        // akcija - visos nuolaidos suma
            txtKaina.Text = price.ToString();
            label5.Text = "Suteikta nuolaida: " + akcija;

            string query = "Select prekesId, kiekis from tblStorage Where pavadinimas = '" + pavDropList.Name + "'";

            SqlDataAdapter conn = new SqlDataAdapter(query, Cnst.SqlCon);
            DataTable dtbl1 = new DataTable();
            conn.Fill(dtbl1);

            prekesId = Convert.ToInt32(dtbl1.Rows[0][0]);                       // prekesId - parduotos prekes ID
            int kiekisId = Convert.ToInt32(dtbl1.Rows[0][1]);                   // kiekisId - parduotos prekes likutis pries pardavima
            likutis = kiekisId - kiekis;                                        // likutis - parduotos prekes likutis po sanderio
            if (likutis < 0)
                MessageBox.Show("Likutis nepakankamas");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (likutis >= 0)
            {
                string query = "INSERT INTO tblSellLog (prekesId, kiekis, nuolaida, suma) VALUES ('" + prekesId + "' , '" +
                               kiekis + "' , '" + nuolaida + "' , '" + price + "')" + "Update tblStorage SET kiekis = '" +
                               likutis + "' Where prekesId = '" + prekesId + "'";

                Cnst.SqlCon.Open();
                var myCommand = new SqlCommand(query, Cnst.SqlCon);
                myCommand.ExecuteNonQuery();
                Cnst.SqlCon.Close();

                MessageBox.Show("Uzsakymas ivykdytas");
            }
            else
            {
                MessageBox.Show("Likutis nepakankamas");
            }
        }

        private void Return_Click(object sender, EventArgs e)
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

        private void FormSell_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }
    }
}