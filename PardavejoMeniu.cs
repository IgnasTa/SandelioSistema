using System;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class PardavejoMeniu : Form
    {
        public PardavejoMeniu()
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

        private void FormMain0_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void Atsijungti_Click(object sender, EventArgs e)
        {
            Cnst.alevel = -1;
            Cnst.User = string.Empty;
            var redirect = new Prisijungimas();
            Hide();
            redirect.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Norėdami parduoti prekes spauskite 'Prekių pardavimas' " +
                "\n\nNorėdami Peržiūrėti prekių likučius spauskite 'Sandėlio likučiai' " +
                "\n\nKeisti vartotojo nustatymus 'Keisti vartotojo nustatymus'" +
                "\n\nKeisti atsijungti spauskite 'Atsijungti' ", "Pagalba");
        }
    }
}
