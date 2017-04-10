using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Drawing;

namespace ContractLicence
{
    public interface IModulos
    {
        Area moduloArea { get; }
        string moduloTitle { get;  }
        MetroUserControl moduloControl { get;  }
        Bitmap img { get;  }        
    }
}
