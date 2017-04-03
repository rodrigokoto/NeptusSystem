using ContractLicence;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystem.Model.Menu
{
    public class Menu
    {
        [ImportMany]
        private IEnumerable<IModulos> _modulos;


        public Dictionary<string, MetroFramework.Controls.MetroUserControl> RetornaComponentesMenu()
        {
            Dictionary<string, MetroFramework.Controls.MetroUserControl> dicControls = new Dictionary<string, MetroFramework.Controls.MetroUserControl>();

            foreach (var item in _modulos)
            {
                dicControls.Add(item.moduloTitle, item.moduloControl);
            }

            return dicControls;
        }
    }
}
