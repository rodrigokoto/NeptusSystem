using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystem.Forms.Main
{
    public partial class Sobre : MetroFramework.Forms.MetroForm
    {
        public Sobre()
        {
            InitializeComponent();
            CarregarAssembly();
        }

        private void CarregarAssembly()
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                Version ver;
                ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;

                StringBuilder sb = new StringBuilder();

                sb.Append(ver.Build);
                sb.Append(ver.Major);
                sb.Append(ver.Minor);
                sb.Append(ver.Build);
                sb.Append(ver.Revision);

                txtBoxInfo.Text = sb.ToString();
            }
        }
    }
}
