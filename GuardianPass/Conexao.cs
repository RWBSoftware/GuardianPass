using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Reflection.PortableExecutable;

namespace GuardianPass
{
    public class Conexao
    {
        public SqliteDataReader dr;

        private static string GetDbPath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appFolder = Path.Combine(folder, "Projetos", "GuardianPass", "GuardianPass", "Data");
            Directory.CreateDirectory(appFolder);
            return Path.Combine(appFolder, "gdb.db");
        }

        public static SqliteConnection GetConnection()
        {
            Batteries.Init();
            string con = $"Data Source={GetDbPath()};";
            return new SqliteConnection(con);
        }

        public bool Login(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM GP_Usuarios WHERE Usuario = @usuario AND Senha = @senha;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }

        public bool PegarExigirSenha(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT ExigirSenha FROM GP_Usuarios WHERE Usuario = @usuario AND Senha = @senha;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    using (var dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            bool Exigir = Convert.ToBoolean(dr["ExigirSenha"]);
                            return Exigir;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }

        public int PegarId(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT Id FROM GP_Usuarios WHERE Usuario = @usuario AND Senha = @senha;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    using (var dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            int Id = Convert.ToInt32(dr["Id"]);
                            return Id;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }


        public bool Cadastro(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    if (Login(usuario, senha))
                    {
                        MessageBox.Show("Usuário já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        command.Parameters.Clear();
                        command.CommandText = "INSERT INTO GP_Usuarios (Usuario, Senha, ExigirSenha) VALUES (@usuario, @senha, true);";
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@senha", senha);
                        int linhasAfetadas = command.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                            return true;
                        else
                            return false;
                    }
                }
            }
        }

        public void AtualizarExigir(DadosUsuario user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE GP_Usuarios SET ExigirSenha = @exigir WHERE Usuario = @usuario;";
                    command.Parameters.AddWithValue("@usuario", user.Usuario);
                    command.Parameters.AddWithValue("@exigir", user.Exigir);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool AtualizarSenha(string senhaNova, DadosUsuario user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE GP_Usuarios SET Senha = @senhaNova WHERE Usuario = @usuario;";
                    command.Parameters.AddWithValue("@usuario", user.Usuario);
                    command.Parameters.AddWithValue("@senhaNova", senhaNova);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
