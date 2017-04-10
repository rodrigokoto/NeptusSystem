using ContractLicence;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystem.Model.Menu
{
    public class Menu
    {
        [ImportMany]
        private IEnumerable<IModulos> _modulos;


        public List<IModulos> ReturnModules()
        {
            List<IModulos> lstModulos = new List<IModulos>();

            foreach (var item in _modulos)
            {
                lstModulos.Add(item);
            }

            return lstModulos;
        }
            

       

        public Dictionary<string, MetroFramework.Controls.MetroUserControl> RetornaComponentesMenu()
        {
            Dictionary<string, MetroFramework.Controls.MetroUserControl> dicControls = new Dictionary<string, MetroFramework.Controls.MetroUserControl>();

            foreach (var item in _modulos)
            {
                dicControls.Add(item.moduloTitle, item.moduloControl);
            }

            return dicControls;
        }

        public Dictionary<string, Bitmap> RetornaImageMenu()
        {

            Dictionary<string, Bitmap> imgMenu = new Dictionary<string, Bitmap>();

            foreach (var item in _modulos)
            {
                imgMenu.Add(item.moduloTitle, item.img);
            }

            return new Dictionary<string, Bitmap>();
        }
    }
}
