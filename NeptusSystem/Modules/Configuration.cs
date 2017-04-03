using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystem.Modules
{
    public class Configuration
    {
        public Dictionary<string, MetroUserControl> ControlesFinanceiro()
        {

            Dictionary<string, MetroUserControl> dicFinanceiro = new Dictionary<string, MetroUserControl>();

            dicFinanceiro.Add("Fornecedores", new ModulesControl.Financeiro.ucFornecedores());
            
            return new Dictionary<string, MetroFramework.Controls.MetroUserControl>();
        }
    }
}
