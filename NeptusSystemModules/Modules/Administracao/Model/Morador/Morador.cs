using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystemModules.Modules.Administracao.Model
{
    public class Morador
    {
        public int MORADORID { get; set; }
        public string MORADORNOME { get; set; }
        public string MORADORRG { get; set; }
        public string MORADORCPF { get; set; }
        public string MORADOREMAIL { get; set; }
        public int MORADORAPART { get; set; }
        public string MORADORDDD1 { get; set; }
        public string MORADORDDD2 { get; set; }
        public string MORADORDTEL { get; set; }
        public string MORADORDCEL { get; set; }
    }
}
