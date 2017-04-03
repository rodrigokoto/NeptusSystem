using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace ContractLicence
{
    public interface IModulos
    {
        string moduloTitle { get; }
        MetroUserControl moduloControl { get; }
    }
}
