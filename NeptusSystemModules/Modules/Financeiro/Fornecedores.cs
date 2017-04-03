using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using NeptusSystem.Modules.ModulesControl.Financeiro;
using System.ComponentModel.Composition;
using ContractLicence;

namespace NeptusSystemModules.Modules.Financeiro
{
    [Export(typeof(IModulos))]
    class Fornecedores : IModulos
    {
        public MetroUserControl moduloControl
        {
            get
            {
                return new ucFornecedores();
            }
        }

        public string moduloTitle
        {
            get
            {
                return "Fornecedores";
            }
        }
    }
}
