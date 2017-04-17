using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using NeptusSystem.Modules.ModulesControl.Financeiro;
using System.ComponentModel.Composition;
using ContractLicence;
using System.Drawing;

namespace NeptusSystemModules.Modules.Financeiro
{
    [Export(typeof(IModulos))]
    class Fornecedores : IModulos
    {
        public Bitmap img
        {
            get
            {
                return Properties.Resources.edit_24px;
            }
        }

        public Area moduloArea
        {
            get
            {
              return  ContractLicence.Area.Financeiro;
            }
        }

        public MetroUserControl moduloControl
        {
            get
            {
                return new ucFornecedores();            }
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
