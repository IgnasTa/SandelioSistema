using System;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class SandelininkoMeniu : Form
    {
        public SandelininkoMeniu()
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

        private void keistiNustatymus_Click(object sender, EventArgs e)
        {
            var redirect = new VartotojuRedagavimas();
            Hide();
            redirect.Show();
        }

        private void BtnPrideti_Click(object sender, EventArgs e)
        {
            var redirect = new PridetiPrekes();
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

        private void FormMain1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Norėdami parduoti prekes spauskite 'Prekių pardavimas' " +
                "\n\nNorėdami Peržiūrėti prekių likučius spauskite 'Sandėlio likučiai' " +
                "\n\nNorėdami papildyti prekių likučius, ar pridėti naujų prekių spasukite 'Sandėlio papildymas'" +
                "\n\nNorėdami ištrinti prekę spasukite 'Trinti prekę'" +
                "\n\nKeisti vartotojo nustatymus 'Keisti vartotojo nustatymus'" +
                "\n\nKeisti atsijungti spauskite 'Atsijungti' ", "Pagalba");
        }
    }
}
