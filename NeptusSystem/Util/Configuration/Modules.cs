using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystem.Util.Configuration
{
    public class Modules
    {
        public void ObterModulos(string acesso, ContractLicence.Area area)
        {
            switch (area)
            {
                case ContractLicence.Area.Administracao:
                    break;
                case ContractLicence.Area.Gerencia:
                    break;
                case ContractLicence.Area.Portaria:
                    break;
                case ContractLicence.Area.RH:
                    break;
                case ContractLicence.Area.Seguranca:
                    break;
                case ContractLicence.Area.Financeiro:
                    break;
                default:
                    break;
            }
        }
    }
}
