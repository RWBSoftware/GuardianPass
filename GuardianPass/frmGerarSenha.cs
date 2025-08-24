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
            cBoxSimbolos.Checked = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            txtBoxSenha.Text = GeradorDeSenha(nupQuantidade.Value, cBoxLetra.Checked, cBoxNumeros.Checked, cBoxSimbolos.Checked);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        public string GeradorDeSenha(decimal tamanho, bool usarLetras, bool usarNumeros, bool usarSimbolos)
        {
            Random random = new Random();

            if (!usarLetras && !usarNumeros && !usarSimbolos)
            {
                MessageBox.Show("Você precisa selecionar pelo menos uma opção.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }
                

            
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numeros = "0123456789";
            string simbolos = "!@#$%^&*()-_=+[]{};:,.<>?";

            StringBuilder caracteresPossiveis = new StringBuilder();

            if (usarLetras) caracteresPossiveis.Append(letras);
            if (usarNumeros) caracteresPossiveis.Append(numeros);
            if (usarSimbolos) caracteresPossiveis.Append(simbolos);

            StringBuilder senha = new StringBuilder();

            for (int i = 0; i < tamanho; i++)
            {
                int indice = random.Next(caracteresPossiveis.Length);
                senha.Append(caracteresPossiveis[indice]);
            }

            return senha.ToString();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxSenha.Text))
            {
                Clipboard.SetText(txtBoxSenha.Text);
                MessageBox.Show("Senha copiada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Não há senha para copiar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
