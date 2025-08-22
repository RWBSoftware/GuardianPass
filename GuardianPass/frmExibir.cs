using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmExibir : Form
    {
        public frmExibir()
        {
            InitializeComponent();
            EstilizarDataGrid(dgv1);
        }

        private void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(13, 27, 42);
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 180, 216);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(27, 38, 59);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(13, 27, 42);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 64, 87);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(46, 64, 87);

            dgv.RowTemplate.Height = 35;
            dgv.DefaultCellStyle.Padding = new Padding(5);
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAdicionar frmAdicionar = new frmAdicionar();
            frmAdicionar.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void frmExibir_Load(object sender, EventArgs e)
        {
            EstilizarDataGrid(dgv1);
        }
    }
}
