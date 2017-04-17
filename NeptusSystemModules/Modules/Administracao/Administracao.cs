using ContractLicence;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Drawing;
using NeptusSystemModules.Modules.Administracao.ModulesControl;

namespace NeptusSystemModules.Modules.Administracao
{
    [Export(typeof(ContractLicence.IModulos))]
    class Administracao : IModulos
    {
        public Bitmap img
        {
            get
            {
                return Properties.Resources.diagram;
            }
        }

        public Area moduloArea
        {
            get
            {
                return ContractLicence.Area.Administracao;
            }
        }

        public MetroUserControl moduloControl
        {
            get
            {
                return new ucAdministracao();
            }
        }

        public string moduloTitle
        {
            get
            {
                return "Administração";
            }
        }
    }
}
