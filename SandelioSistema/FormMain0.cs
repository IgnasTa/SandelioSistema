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
    public partial class FormMain0 : Form
    {
        public FormMain0()
        {
            InitializeComponent();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            var redirect = new FormSell();
            Hide();
            redirect.Show();
        }

        private void FormMain0_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            var redirect = new FormStorage();
            Hide();
            redirect.Show();
        }

        private void Sandelys_Click(object sender, EventArgs e)
        {
            var redirect = new FormAddItem();
            Hide();
            redirect.Show();
        }
    }
}
