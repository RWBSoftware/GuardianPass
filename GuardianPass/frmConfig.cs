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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            VerificarACorDoBotao();
        }

        public void VerificarACorDoBotao()
        {
            DadosUsuario user = new DadosUsuario();
            user = user.Carregar();
            if (user.Exigir)
            {
                btnExigirSenha.BackColor = Color.FromArgb(0, 180, 216);
            }
            else
            {
                btnExigirSenha.BackColor = Color.LightGray;
            }
        }


        private void btnExigirSenha_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            DadosUsuario user = new DadosUsuario();
            user = user.Carregar();
            if (user.Exigir)
            {
                btnExigirSenha.BackColor = Color.LightGray;
                user.Exigir = false;
                conexao.AtualizarExigir(user);
            }
            else
            {
                btnExigirSenha.BackColor = Color.FromArgb(0, 180, 216);
                user.Exigir = true;
                conexao.AtualizarExigir(user);
            }
            user.Salvar(user);
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frmAlterarSenha = new frmAlterarSenha(new DadosUsuario().Carregar());
            frmAlterarSenha.Show();
            this.Close();
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }
    }
}
