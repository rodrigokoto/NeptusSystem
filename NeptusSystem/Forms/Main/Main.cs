using NeptusSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContractLicence;


namespace NeptusSystem.Forms.Main
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        List<IModulos> lstModulo = new List<IModulos>();
        private Session.Session session = Session.Session.Instance;

        public Main()
        {
            var catalog = new AggregateCatalog(
                new AssemblyCatalog(Assembly.GetExecutingAssembly()),
                new DirectoryCatalog("."));
            var container = new CompositionContainer(catalog);
            var menu = new NeptusSystem.Model.Menu.Menu();
            container.ComposeParts(menu);
            lstModulo = menu.ReturnModules();

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MontarMenu();
            CarregarSession();
        }

        

        private void CarregarSession()
        {
            //lblUsuario.Text = session.SessionUser;

        }

        private void picSearch_Click(object sender, EventArgs e)
        {

        }



        private void MontarMenu()
        {

            switch (ContractLicence.Area)
            {
                case Area.Administracao:
                    break;
                case Area.Gerencia:
                    break;
                case Area.Portaria:
                    break;
                case Area.RH:
                    break;
                case Area.Seguranca:
                    break;
                case Area.Financeiro:
                    break;
                default:
                    break;
            }

            for (int i = 0; i < lstModulo.Count; i++)
            {
                Label lblmodulo = new Label();
                lblmodulo.Text = lstModulo[i].moduloTitle;
                pnlMenu.Controls.Add(lblmodulo);
            }
            //MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();

            //LinkLabel lblmenuitem = new LinkLabel();

            //foreach (var item in dicControls)
            //{
            //    System.Drawing.Size size = new Size(235, 39);
            //    tile.Text = item.Key;
            //    tile.Name = "tl" + item.Key;
            //    tile.UseTileImage = true;
            //    tile.Size = size;
            //    tile.TextAlign = ContentAlignment.MiddleCenter;
            //    tile.Click += delegate (object sender, EventArgs e) { AbrirUsercontrol(sender, e, item.Value); };

            //}


        }



        private void AbrirUsercontrol(object sender, EventArgs e, MetroFramework.Controls.MetroUserControl controle)
        {
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(controle);
        }

        private void PopularMenu()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ctmConfig.Show(btnConfig, btnConfig.Location.X, btnConfig.Location.Y + pnlConfig.Height);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sobre().Show();
        }
    }
}
