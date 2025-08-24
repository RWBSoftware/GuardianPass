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
    public partial class frmExibir : Form
    {
        ConexaoApps apps = new ConexaoApps();
        public frmExibir()
        {
            InitializeComponent();
            EstilizarDGV(dgv1);
            apps.CarregarSitesNoDGV(dgv1);
        }



        private void EstilizarDGV(DataGridView dgv)
        {
            // Bordas arredondadas não tem nativo, mas a gente "imita" com estilo
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // linhas alternadas
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215); // azul Windows 10/11
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Fonte padrão das células
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;

            // Grid invisível pra ficar flat
            dgv.GridColor = Color.LightGray;

            // Auto ajuste
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowHeadersVisible = false;

            // Altura das linhas
            dgv.RowTemplate.Height = 35;

            // Seleção apenas em linha inteira
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;


        }




        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = (dgv1.SelectedRows[0].DataBoundItem as DataRowView).Row;

            DadosApp dadosApp = new DadosApp
            {
                Usuario = row["Usuario"].ToString(),
                Senha = row["Senha"].ToString(),
                SiteApp = row["Site"].ToString()
            };


            DadosUsuario user = new DadosUsuario();
            user = user.Carregar();
            if (user.Exigir)
            {
                frmExigirSenha frmExigirSenha = new frmExigirSenha(dadosApp);
                frmExigirSenha.Show();
                this.Close();
            }
            else
            {
                frmAdicionar frmAdicionar = new frmAdicionar(dadosApp);
                frmAdicionar.Show();
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                apps.ExcluirApps(
                    dgv1.SelectedRows[0].Cells["Usuario"].Value.ToString(),
                    dgv1.SelectedRows[0].Cells["Senha"].Value.ToString(),
                    dgv1.SelectedRows[0].Cells["Site"].Value.ToString()
                );
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                apps.CarregarSitesNoDGV(dgv1);
                EstilizarDGV(dgv1);
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void frmExibir_Load(object sender, EventArgs e)
        {
            EstilizarDGV(dgv1);
        }

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            apps.PesquisarApps(txtBoxUsuario.Text, dgv1);
        }
    }
}
