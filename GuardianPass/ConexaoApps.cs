using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianPass
{
    public class ConexaoApps : Conexao
    {
        public bool CadastrarApps(string usuario, string senha, string site)
        {
            DadosUsuario user = new DadosUsuario().Carregar();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO GP_Apps (Usuario, Senha, Site, UsuarioId) VALUES (@usuario, @senha, @site, @usuarioId);";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.Parameters.AddWithValue("@site", site);
                    command.Parameters.AddWithValue("@usuarioId", user.Id);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        public void PesquisarApps(string site, DataGridView dgv)
        {
            DadosUsuario user = new DadosUsuario();
            user = user.Carregar();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    // Query corrigida
                    command.CommandText = "SELECT * FROM GP_Apps WHERE Site LIKE @site AND UsuarioId = @usuarioId;";
                    command.Parameters.AddWithValue("@site", $"%{site}%");// % para busca parcial
                    command.Parameters.AddWithValue("@usuaioId", user.Id);

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;

                    dgv.Columns[0].HeaderText = "Nome do Site/App";
                    dgv.AutoResizeColumns();
                }
            }
        }

        public void CarregarSitesNoDGV(DataGridView dgv)
        {
            DadosUsuario user = new DadosUsuario().Carregar();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Site, Usuario, Senha FROM GP_Apps WHERE UsuarioId = @usuarioId;";
                    command.Parameters.AddWithValue("@usuarioId", user.Id);

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    dgv.DataSource = dt;

                    dgv.Columns[0].HeaderText = "Nome do Site/App";
                    dgv.AutoResizeColumns();
                }
            }
        }


        public bool ExcluirApps(string usuario, string senha, string site)
        {
            DadosUsuario user =new DadosUsuario();
            user = user.Carregar();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM GP_Apps WHERE Usuario = @usuario AND Senha = @senha AND Site = @site AND UsuarioId = @usuarioId;";
                    
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.Parameters.AddWithValue("@site", site);
                    command.Parameters.AddWithValue("@usuarioId", user.Id);
                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public bool AtualizarApp(string usuario, string senha, string site, string usuarioAntigo, string siteAntigo)
        {
            DadosUsuario user = new DadosUsuario();
            user = user.Carregar();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE GP_Apps SET Usuario = @usuario, Site = @site, Senha = @senha WHERE Usuario = @usuarioAntigo AND Site = @siteAntigo AND UsuarioId = @usuarioId";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    command.Parameters.AddWithValue("@site", site);
                    command.Parameters.AddWithValue("@usuarioAntigo", usuarioAntigo);
                    command.Parameters.AddWithValue("@siteAntigo", siteAntigo);
                    command.Parameters.AddWithValue("@usuarioId", user.Id);

                    int linhasAfetadas = command.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

    }
}
