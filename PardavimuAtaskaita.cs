﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SandelioSistema
{
    public partial class PardavimuAtaskaita : Form
    {
        public PardavimuAtaskaita()
        {
            InitializeComponent();
            string query = "Select * from tblSellLog";
            showData(query, Cnst.SqlCon);
        }

        private void showData(string query, SqlConnection sqlcon)
        {
            gridStorage.Rows.Clear();
            SqlDataAdapter data = new SqlDataAdapter(query, sqlcon);
            DataTable tableStorage = new DataTable();
            data.Fill(tableStorage);
            for (int i = 0; i < tableStorage.Rows.Count; i++)
            {
                gridStorage.Rows.Add();
                gridStorage.Rows[i].Cells[0].Value = tableStorage.Rows[i][0];
                gridStorage.Rows[i].Cells[1].Value = tableStorage.Rows[i][1];
                gridStorage.Rows[i].Cells[2].Value = tableStorage.Rows[i][2];
                gridStorage.Rows[i].Cells[3].Value = tableStorage.Rows[i][3];
                gridStorage.Rows[i].Cells[4].Value = tableStorage.Rows[i][4];
                gridStorage.Rows[i].Cells[5].Value = tableStorage.Rows[i][5].ToString().Substring(0, 9);
            }           
        }        

        private void Search_Click(object sender, EventArgs e)
        {
            int pprice = 0;
            string query = "Select * from tblSellLog";

            if (txtValueMin.Text.Length > 0 && txtValueMax.Text.Length > 0)
                pprice = 1;
            
            if (pprice == 1)
            {
                int Min = Convert.ToInt32(txtValueMin.Text.Trim());
                int Max = Convert.ToInt32(txtValueMax.Text.Trim());
                query = "Select * from tblSellLog Where data >= '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' and data <= '" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "' and suma >= '" + Min + "' and suma <= '" + Max + "'";
            }

            if (pprice == 0)
            {
                query = "Select * from tblSellLog Where data >= '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' and data <= '" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "'";
            }
            showData(query, Cnst.SqlCon);
        }

        private void Back_Click(object sender, EventArgs e)
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

        private void FormLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cnst.ExitApp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Norėdami peržiūrėti pardavimo išklotinę pasirinkite datos 'langą' ir(arba) kainos 'langą' ", "Pagalba");
        }
    }
}
