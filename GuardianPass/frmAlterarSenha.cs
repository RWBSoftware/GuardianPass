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
    public partial class frmAlterarSenha : Form
    {
        DadosUsuario user;
        public frmAlterarSenha(DadosUsuario user)
        {
            InitializeComponent();
            this.user = user;
            txtBoxSenhaAtual.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HashSenha hashSenha = new HashSenha(SHA256.Create());
            if (txtBoxSenhaAtual.Text != user.Senha)
            {
                MessageBox.Show("Senha atual incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBoxSenhaNova.Text.Length < 6)
            {
                MessageBox.Show("A nova senha deve ter pelo menos 6 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBoxSenhaNova.Text != txtBoxSenhaNovamente.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Conexao conexao = new Conexao();
            if (conexao.AtualizarSenha(hashSenha.CriptografarSenha(txtBoxSenhaNova.Text), user))
            {
                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar a senha. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenhaAtual.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNova.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }
    }
}
