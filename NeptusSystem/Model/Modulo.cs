using ContractLicence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Drawing;

namespace NeptusSystem.Model
{
    public class Modulo : IModulos
    {
        public Bitmap img
        {
            get;set;   
                    }

        public Area moduloArea
        {
            get; set;
            
        }

        public MetroUserControl moduloControl
        {
            get; set;
        }

        public string moduloTitle
        {
            get; set;
        }
    }
}
