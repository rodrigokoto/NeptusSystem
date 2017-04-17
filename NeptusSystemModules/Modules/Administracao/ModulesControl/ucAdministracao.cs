using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeptusSystemModules.Modules.Administracao.ModulesControl.Proprietario;
using MetroFramework;

namespace NeptusSystemModules.Modules.Administracao.ModulesControl
{
    public partial class ucAdministracao : MetroFramework.Controls.MetroUserControl
    {
        public ucAdministracao()
        {
            InitializeComponent();
        }

        private void tleProprietario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ContainerModules>().Count() > 0)
            {
                MetroMessageBox.Show(this, "Ok", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ContainerModules container = new ContainerModules();
                container.Show();
                container.AddControl(new ucProprietario(), "Proprietário");
            }
          //  new ContainerModules().Show();
            //ContainerModules moduleOpen = new ContainerModules();
            //moduleOpen.AddControl(new ucProprietario(), "Proprietário");
            //moduleOpen.Show();
            
        }
    }
}
