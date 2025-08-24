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
            string json = JsonSerializer.Serialize(user);
            File.WriteAllText("usuarios.json", json);
        }

        public DadosUsuario Carregar()
        {
            if(!File.Exists("usuarios.json"))
                return new DadosUsuario();

            string json = File.ReadAllText("usuarios.json");
            return JsonSerializer.Deserialize<DadosUsuario>(json) ?? new DadosUsuario();
        }


    }
}
