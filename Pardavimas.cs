using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class Pardavimas : Form
    {
        public int nr = 0;
        public double suma;
        List<Cart> ShoppingCart = new List<Cart>();

        public Pardavimas()
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

            listView.Hide();
        }

        void listViewCart()
        {
            suma = 0;
            listView.Items.Clear();
            listView.Show();
            foreach (var preke in ShoppingCart)
            {
                ListViewItem item = new ListViewItem(preke.Pavadinimas);
                item.SubItems.Add(preke.VntKaina.ToString());
                item.SubItems.Add(preke.Kiekis.ToString());
                item.SubItems.Add(preke.Kaina.ToString());
                listView.Items.Add(item);
                suma += Convert.ToDouble(preke.Kaina);
            }
        }

        void sortCart()
        {
            int cut = 0;
            ShoppingCart.Sort((x, y) => x.PrekesId.CompareTo(y.PrekesId));
            for (int i = 0; i < ShoppingCart.Count; i++)
                for (int j = i + 1; j < ShoppingCart.Count; j++)
                    if (ShoppingCart[i].PrekesId == ShoppingCart[j].PrekesId)
                    {
                        ShoppingCart[i].Kiekis += ShoppingCart[j].Kiekis;
                        ShoppingCart[j].Kiekis = -1;
                        cut++;
                        nr--;
                    }

            if (cut > 0)
            {
                ShoppingCart.Sort((y, x) => x.Kiekis.CompareTo(y.Kiekis));
                ShoppingCart.RemoveAt(ShoppingCart.Count - cut);
            }             
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
                dropPavadinimas.Add(new DropList()
                {
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

            ShoppingCart.Add(new Cart());
            ShoppingCart[nr].Pavadinimas = pavDropList.Name;
            ShoppingCart[nr].Kiekis = Convert.ToInt32(txtKiekis.Text);           // Kiekis - kiekis nupirktu prekiu
            ShoppingCart[nr].VntKaina = pavDropList.DoubleValue;                 // VntKaina - kaina vieno vieneto
            ShoppingCart[nr].Nuolaida = nuolaidaDropList.DoubleValue;            // Nuolaida - pritaikyta nuolaida (%)

            double akcija = Math.Round(pavDropList.DoubleValue * ShoppingCart[nr].Kiekis * ShoppingCart[nr].Nuolaida, 2);       // akcija - visos nuolaidos suma
            txtKaina.Text = ShoppingCart[nr].Kaina.ToString();
            label5.Text = "Suteikta nuolaida: " + akcija;
            
            string query = "Select prekesId, kiekis from tblStorage Where pavadinimas = '" + pavDropList.Name + "'";
            SqlDataAdapter conn = new SqlDataAdapter(query, Cnst.SqlCon);
            DataTable dtbl1 = new DataTable();
            conn.Fill(dtbl1);
            ShoppingCart[nr].PrekesId = Convert.ToInt32(dtbl1.Rows[0][0]);       // PrekesId - parduotos prekes ID   
            ShoppingCart[nr].PradinisKiekis = Convert.ToInt32(dtbl1.Rows[0][1]); // PradinisKiekis - parduotos prekes likutis pries pardavima

            if (ShoppingCart[nr].Likutis < 0)
            {
                MessageBox.Show("Likutis nepakankamas");
                ShoppingCart.RemoveAt(ShoppingCart.Count - 1);
            }
            else
            {
                sortCart();
                listViewCart();
                nr++;
            }
            txtSuma.Text = "Suma: " + suma.ToString();
            dropTipas.Focus();
        }      

        private void Click_Order(object sender, EventArgs e)
        {
            Cnst.SqlCon.Open();
            foreach (var eile in ShoppingCart)
            {
                if (eile.Likutis >= 0)
                {
                    string query = "INSERT INTO tblSellLog (prekesId, pavadinimas , kiekis, nuolaida, suma) VALUES ('" + eile.PrekesId + "' , '"+ eile.Pavadinimas +"' , '" +
                                   eile.Kiekis + "' , '" + eile.Nuolaida + "' , '" + eile.Kaina + "')" + "Update tblStorage SET kiekis = '" +
                                   eile.Likutis + "' Where prekesId = '" + eile.PrekesId + "'";
                    var myCommand = new SqlCommand(query, Cnst.SqlCon);
                    myCommand.ExecuteNonQuery();
                }
            }
            
            MessageBox.Show("Mokėtina suma: " + suma + " €");

            Cnst.SqlCon.Close();
            txtSuma.Text = "";
            listView.Items.Clear();
            ShoppingCart.Clear();
            listView.Hide();
            nr = 0;
        }

        private void Click_clearList(object sender, EventArgs e)
        {
            txtSuma.Text = "";
            ShoppingCart.Clear();
            listViewCart();
            nr = 0;
            MessageBox.Show("Krepšelis išvalytas");
            listView.Hide();
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

        private void FormSell_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Noredami pridėti prekes į krepselį pasirinkite prekę, kiekį, galite " +
                "pritaikyti nuolaidą ir spauskite 'Pridėti į krepselį' \n\nNorėdami baigti užsakyma " +
                "spauskite 'Užsakyti' \n\nNorėdami išvalyti krepšelį spauskite 'Išvalyti krepšelį' ", "Pagalba");
        }
    }
}

