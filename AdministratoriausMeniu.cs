using System;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class AdministratoriausMeniu : Form
    {
        public AdministratoriausMeniu()
        {
            InitializeComponent();
        }
        private void BtnSell_Click(object sender, EventArgs e)
        {
            var redirect = new Pardavimas();
            Hide();
            redirect.Show();
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            var redirect = new Sandelys();
            Hide();
            redirect.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var redirect = new PridetiPrekes();
            Hide();
            redirect.Show();
        }

        private void keistiNustatymus_Click(object sender, EventArgs e)
        {
            var redirect = new VartotojuRedagavimas();
            Hide();
            redirect.Show();
        }

        private void Log(object sender, EventArgs e)
        {
            var redirect = new PardavimuAtaskaita();
            Hide();
            redirect.Show();
        }

        private void Atsijungti_Click(object sender, EventArgs e)
        {
            Cnst.alevel = -1;
            Cnst.User = string.Empty;
            var redirect = new Prisijungimas();
            Hide();
            redirect.Show();
        }

        private void FormMain2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Norėdami parduoti prekes spauskite 'Prekių pardavimas' " +
                "\n\nNorėdami Peržiūrėti prekių likučius spauskite 'Sandėlio likučiai' " +
                "\n\nNorėdami papildyti prekių likučius, ar pridėti naujų prekių spasukite 'Sandėlio papildymas'" +
                "\n\nNorėdami pamatyti pardavimų ataskaitas spauskite 'Pardavimų ataskaitos'" +
                "\n\nNorėdami ištrinti prekę spasukite 'Trinti prekę'" +
                "\n\nKeisti vartotojo nustatymus 'Keisti vartotojo nustatymus'" +
                "\n\nKeisti atsijungti spauskite 'Atsijungti' ", "Pagalba");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var redirect = new IstrintiPrekes();
            Hide();
            redirect.Show();
        }
    }
}
