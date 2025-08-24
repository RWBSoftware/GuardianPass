using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmAdicionar : Form
    {
        public DadosApp dadosapp = null;
        public frmAdicionar(DadosApp app = null)
        {
            this.dadosapp = app;
            InitializeComponent();
            if (app != null)
                CarregarDadosApp(app);
        }

        public void CarregarDadosApp(DadosApp app)
        {
            if (app != null)
            {
                txtBoxUsuario.Text = app.Usuario;
                txtBoxSenha.Text = app.Senha;
                txtBoxSiteApp.Text = app.SiteApp;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dadosapp != null)
            {
                VerificarCampos();
                ConexaoApps apps = new ConexaoApps();
                HashSenha hashSenha = new HashSenha(SHA256.Create());

                if (apps.AtualizarApp(txtBoxUsuario.Text, txtBoxSenha.Text, txtBoxSiteApp.Text, dadosapp.Usuario, dadosapp.SiteApp))
                {
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmExibir frmExibir = new frmExibir();
                    frmExibir.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Erro ao atualizar os dados. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            else
                SalvarDados();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
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

        public void Limpar()
        {
            txtBoxUsuario.Clear();
            txtBoxSenha.Clear();
            txtBoxSiteApp.Clear();
        }

        public void VerificarCampos()
        {
            if (txtBoxUsuario.Text.Length < 4)
            {
                MessageBox.Show("O usuário deve ter pelo menos 4 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtBoxSenha.Text.Length < 4)
            {
                MessageBox.Show("A senha deve ter pelo menos 4 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBoxSiteApp.Text.Length < 3)
            {
                MessageBox.Show("O site ou aplicativo deve ter pelo menos 3 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void SalvarDados()
        {
            VerificarCampos();
            ConexaoApps apps = new ConexaoApps();
            HashSenha hashSenha = new HashSenha(SHA256.Create());
            if (apps.CadastrarApps(txtBoxUsuario.Text, txtBoxSenha.Text, txtBoxSiteApp.Text))
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
