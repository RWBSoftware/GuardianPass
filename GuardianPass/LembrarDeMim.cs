using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianPass
{
    public class LembrarDeMim
    {
        public void Salvar(string usuario, string senha, bool lembrar)
        {
            Properties.Settings.Default.Usuario = usuario;
            Properties.Settings.Default.Senha = senha;
            Properties.Settings.Default.Lembrar = lembrar;
            Properties.Settings.Default.Save();
        }

        public void Apagar()
        {
            Properties.Settings.Default.Usuario = "";
            Properties.Settings.Default.Senha = "";
            Properties.Settings.Default.Lembrar = false;
            Properties.Settings.Default.Save();
        }

    }
}
