using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianPass
{
    public class DadosApp
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string SiteApp { get; set; }
        public DadosApp(string usuario, string senha, string siteApp)
        {
            Usuario = usuario;
            Senha = senha;
            SiteApp = siteApp;
        }
        public DadosApp() { }
    }
}
