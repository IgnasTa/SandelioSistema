﻿using System;
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
    }
}