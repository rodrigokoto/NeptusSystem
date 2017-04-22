using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystemModules.Modules.Administracao.Model.Endereco
{
    public class Endereco
    {
        public int ENDID { get; set; }
        public string ENDRUA { get; set; }
        public string ENDBAIRRO { get; set; }
        public string ENDCIDADE { get; set; }
        public string ENDESTADO { get; set; }
        public string ENDCOMPLEMENTO { get; set; }
        public string ENDNUM { get; set; }
        public string ENDCEP { get; set; }
        public string ENDUF { get; set; }
    }
}
