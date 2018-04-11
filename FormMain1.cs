using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class FormMain1 : Form
    {
        public FormMain1()
        {
            InitializeComponent();
        }
        private void BtnSell_Click(object sender, EventArgs e)
        {
            var redirect = new FormSell();
            Hide();
            redirect.Show();
        }

        private void FormMain1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            var redirect = new FormStorage();
            Hide();
            redirect.Show();
        }

        private void BtnPrideti_Click(object sender, EventArgs e)
        {
            var redirect = new FormAddItem();
            Hide();
            redirect.Show();
        }
    }
}
