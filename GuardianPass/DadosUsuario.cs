using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GuardianPass
{
    public  class DadosUsuario
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool Exigir { get; set; }

        public void Salvar(DadosUsuario user)
        {
            string pasta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "GuardianPass"
            );

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            string caminhoArquivo = Path.Combine(pasta, "usuarios.json");

            string json = JsonSerializer.Serialize(user);
            File.WriteAllText(caminhoArquivo, json);
        }

        public DadosUsuario Carregar()
        {
            string pasta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "GuardianPass"
            );

            string caminhoArquivo = Path.Combine(pasta, "usuarios.json");

            if (!File.Exists(caminhoArquivo))
                return new DadosUsuario();

            string json = File.ReadAllText(caminhoArquivo);
            return JsonSerializer.Deserialize<DadosUsuario>(json) ?? new DadosUsuario();
        }


    }
}
