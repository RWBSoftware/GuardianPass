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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionar frmAdicionar = new frmAdicionar();
            frmAdicionar.Show();
            this.Close();
        }

        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            frmGerarSenha frmGerarSenha = new frmGerarSenha();
            frmGerarSenha.Show();
            this.Close();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            frmExibir frmExibir = new frmExibir();
            frmExibir.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
