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
        }

        private void btnExigirSenha_Click(object sender, EventArgs e)
        {
            frmExigirSenha frmExigirSenha = new frmExigirSenha();
            frmExigirSenha.Show();
            this.Close();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

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
