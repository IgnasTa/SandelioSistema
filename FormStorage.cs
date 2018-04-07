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
    public partial class FormStorage : Form
    {
        public FormStorage()
        {
            InitializeComponent();
            string query = "Select * from tblStorage";
            showData(query, Cnst.SqlCon);
            dropParameter.DataSource = Cnst.DropTipai;
            dropParameter.DisplayMember = "Name";
        }

        //------------------------------------------------------------
        private void showData(string query, SqlConnection sqlcon)
        {
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
            }
            gridStorage.BorderStyle = BorderStyle.None;
            gridStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridStorage.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridStorage.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridStorage.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridStorage.BackgroundColor = Color.White;
            
            gridStorage.EnableHeadersVisualStyles = false;
            gridStorage.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridStorage.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridStorage.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        //-------------------------------------------------------------
        private void StorageParameter_Click(object sender, EventArgs e)
        {
            string query = "Select * from tblStorage Where pavadinimas = '" + txtStorageParameter.Text.Trim() + "'";
            showData(query, Cnst.SqlCon);
        }
        //-----------------------------------------------------------
        private void btnValue_Click(object sender, EventArgs e)
        {
            DropList dl = dropParameter.SelectedItem as DropList;
            MessageBox.Show(dl.Name);
            string query = "Select * from tblStorage Where tipas = '" + dl.Name + "'";
            showData(query, Cnst.SqlCon);
        }
        //-----------------------------------------------------------
        private void btnDropList_Click(object sender, EventArgs e)
        {
            int Min = Convert.ToInt32(txtValueMin.Text.Trim());
            int Max = Convert.ToInt32(txtValueMax.Text.Trim());
            string query = "Select * from tblStorage Where kaina >= '" + Min + "' and kaina <= '" + Max + "'";
            showData(query, Cnst.SqlCon);
        }
        

    }
}
