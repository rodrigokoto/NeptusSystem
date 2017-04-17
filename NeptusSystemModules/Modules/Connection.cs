using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContractLicence;
using System.Data.SqlClient;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace NeptusSystemModules.Modules
{
    class Connection
    {
        [Import]
        public IConnection NeptusConection;

        public Connection()
        {
            var catalog = new AggregateCatalog(
             new AssemblyCatalog(Assembly.GetExecutingAssembly()),
             new DirectoryCatalog("."));
            var container = new CompositionContainer(catalog);
            var con = this;
            container.ComposeParts(con);

            NeptusConection = con.NeptusConection;
        }

    }
}
