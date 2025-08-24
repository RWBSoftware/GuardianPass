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
    public partial class frmExigirSenha : Form
    {
        DadosApp dadosApp = null;
        public frmExigirSenha(DadosApp dadosApp)
        {
            this.dadosApp = dadosApp;
            InitializeComponent();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DadosUsuario user = new DadosUsuario();
            user = user.Carregar();
            if (txtBoxSenha.Text == user.Senha)
            {
                frmAdicionar frmAdicionar = new frmAdicionar(dadosApp);
                frmAdicionar.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha incorreta. Tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxSenha.Clear();
                txtBoxSenha.Focus();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }
    }
}
