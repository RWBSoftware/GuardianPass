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
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxUsuario.Clear();
            txtBoxSenha.Clear();
            txtBoxSiteApp.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }
    }
}
