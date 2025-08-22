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
    public partial class frmGerarSenha : Form
    {
        public frmGerarSenha()
        {
            InitializeComponent();
            OrganizarValores();
        }

        public void OrganizarValores()
        {
            nupQuantidade.Value = 12;
            cBoxLetra.Checked = true;
            cBoxNumeros.Checked = true;
            cBoxSimbolos.Checked = false;
        }

        private void btnGerar_Click(object sender, EventArgs e)
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
