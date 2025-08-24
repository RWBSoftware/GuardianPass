using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            CarregarLembrarDeMim();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public void CarregarLembrarDeMim()
        {
            LembrarDeMim lembrarDeMim = new LembrarDeMim();
            if (Properties.Settings.Default.Lembrar)
            {
                txtBoxUsuario.Text = Properties.Settings.Default.Usuario;
                txtBoxSenha.Text = Properties.Settings.Default.Senha;
                cBoxLembrarDeMim.Checked = true;
            }
            else
            {
                txtBoxUsuario.Text = "";
                txtBoxSenha.Text = "";
                cBoxLembrarDeMim.Checked = false;
            }
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            HashSenha hashSenha = new HashSenha(SHA256.Create());
            Conexao conexao = new Conexao();

            if (conexao.Login(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)))
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
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void cBoxLembrarDeMim_CheckedChanged(object sender, EventArgs e)
        {
            LembrarDeMim lembrarDeMim = new LembrarDeMim();
            if (cBoxLembrarDeMim.Checked)
                lembrarDeMim.Salvar(txtBoxUsuario.Text, txtBoxSenha.Text, cBoxLembrarDeMim.Checked);
            else
                lembrarDeMim.Apagar();
        }
    }
}
