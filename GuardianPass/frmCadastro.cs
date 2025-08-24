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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtBoxUsuario.Text.Length < 4)
            {
                MessageBox.Show("O nome de usuário deve ter pelo menos 4 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBoxSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBoxSenha.Text != txtBoxSenhaNovamente.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HashSenha hashSenha = new HashSenha(SHA256.Create());
            Conexao conexao = new Conexao();

            if (conexao.Cadastro(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)))
            {
                DadosUsuario user = new DadosUsuario
                {
                    Id = conexao.PegarId(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)),
                    Usuario = txtBoxUsuario.Text,
                    Senha = txtBoxSenha.Text,
                    Exigir = conexao.PegarExigirSenha(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text))
                };
                user.Salvar(user);



                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao realizar o cadastro. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }
    }
}
