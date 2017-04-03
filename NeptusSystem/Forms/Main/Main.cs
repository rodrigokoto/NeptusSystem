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


namespace NeptusSystem.Forms.Main
{
    public partial class Main : Form
    {
        Dictionary<string, MetroFramework.Controls.MetroUserControl> dicControls = new Dictionary<string, MetroFramework.Controls.MetroUserControl>();
        
        public Main()
        {
            var catalog = new AggregateCatalog(
                new AssemblyCatalog(Assembly.GetExecutingAssembly()),
                new DirectoryCatalog("."));
            var container = new CompositionContainer(catalog);
            var menu = new NeptusSystem.Model.Menu.Menu();
            container.ComposeParts(menu);
            dicControls = menu.RetornaComponentesMenu();
            
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MontarMenu();
            CarregarSession();

        }

        private Session.Session session = Session.Session.Instance;

        private void CarregarSession()
        {
            lblUsuario.Text = session.SessionUser;

        }

        private void picSearch_Click(object sender, EventArgs e)
        {

        }

        

        private void MontarMenu()
        {
            LinkLabel lblmenuitem = new LinkLabel();
            
            foreach (var item in dicControls)
            {

                MetroFramework.Controls.MetroUserControl controle =  item.Value;
                lblmenuitem.Text = item.Key;
                lblmenuitem.Name = "lbl" + item.Key;
                lblmenuitem.Click += delegate(object sender , EventArgs e) { AbrirUsercontrol(sender, e, item.Value); };
            }

            pnlMenu.Controls.Add(lblmenuitem);
        }

        
            
        private void AbrirUsercontrol(object sender , EventArgs e,  MetroFramework.Controls.MetroUserControl controle)
        {
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(controle);
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Aqua;
        }

        private void PopularMenu()
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
