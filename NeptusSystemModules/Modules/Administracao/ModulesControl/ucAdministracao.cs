using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeptusSystemModules.Modules.Administracao.ModulesControl;
using MetroFramework;

namespace NeptusSystemModules.Modules.Administracao.ModulesControl
{
    public partial class ucAdministracao : MetroFramework.Controls.MetroUserControl
    {
        public ucAdministracao()
        {
            InitializeComponent();

            Connection con = Connection.Instance;

        }

        private void tleProprietario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ContainerModules>().Count() > 0)
            {
                MetroMessageBox.Show(this, "Já há um modulo aberto , feche-o e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ContainerModules container = new ContainerModules();
                container.Show();
                container.AddControl(new ucProprietario(), "Proprietário");
            }
        }

        private void tleApartamento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ContainerModules>().Count() > 0)
            {
                MetroMessageBox.Show(this, "Já há um modulo aberto , feche-o e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ContainerModules container = new ContainerModules();
                container.Show();
                container.AddControl(new Apartamento.ucAptCadastro(), "Apartamento");
            }
        }

        private void tlGaragem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ContainerModules>().Count() > 0)
            {
                MetroMessageBox.Show(this, "Já há um modulo aberto , feche-o e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ContainerModules container = new ContainerModules();
                container.Show();
                container.AddControl(new Garagem.ucGarCadastro(), "Garagem");
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ContainerModules>().Count() > 0)
            {
                MetroMessageBox.Show(this, "Já há um modulo aberto , feche-o e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ContainerModules container = new ContainerModules();
                container.Show();
                container.AddControl(new ModulesControl. ucMorador(), "Morador");
            }
        }
    }
}
