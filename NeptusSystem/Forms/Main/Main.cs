using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ContractLicence;
using Bunifu.Framework.UI;

namespace NeptusSystem.Forms.Main
{
    public partial class Main : Form
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
            MaximizedState();
            CarregarSession();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            MontarMenu();
        }



        private void MaximizedState()
        {
            var rectangle = Screen.FromControl(this).Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            Size = new Size(rectangle.Width, rectangle.Height);
            Location = new Point(0, 0);
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
        }

        private void CarregarSession()
        {
            //lblUsuario.Text = session.SessionUser;

        }


        private BunifuFlatButton CriarButtonModulo(IModulos modulo)
        {
            BunifuFlatButton btnModulo = new BunifuFlatButton();

            btnModulo.Activecolor = Color.Gray;
            btnModulo.BackColor = Color.Transparent;
            btnModulo.BackgroundImageLayout = ImageLayout.Stretch;
            btnModulo.BorderRadius = 0;
            btnModulo.ButtonText = "   " + modulo.moduloTitle;
            btnModulo.Cursor = Cursors.Hand;
            btnModulo.DisabledColor = Color.DimGray;
            btnModulo.Dock = DockStyle.Top;
            btnModulo.Iconcolor = Color.Transparent;
            btnModulo.Iconimage = modulo.img;
            btnModulo.Iconimage_right = null;
            btnModulo.Iconimage_right_Selected = null;
            btnModulo.Iconimage_Selected = null;
            btnModulo.IconMarginLeft = 0;
            btnModulo.IconMarginRight = 0;
            btnModulo.IconRightVisible = true;
            btnModulo.IconRightZoom = 0D;
            btnModulo.IconVisible = true;
            btnModulo.IconZoom = 30D;
            btnModulo.IsTab = false;
            btnModulo.Location = new Point(0, 126);
            btnModulo.Name = "btn" + modulo.moduloTitle;
            btnModulo.Normalcolor = Color.Transparent;
            btnModulo.OnHovercolor = Color.Gray;
            btnModulo.OnHoverTextColor = Color.White;
            btnModulo.selected = false;
            btnModulo.Size = new Size(244, 42);
            btnModulo.TabIndex = 3;
            btnModulo.Text = "   " + modulo.moduloTitle;
            btnModulo.TextAlign = ContentAlignment.MiddleLeft;
            btnModulo.Textcolor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnModulo.TextFont = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnModulo.Click += delegate (object sender, EventArgs e) { AbrirUsercontrol(sender, e, modulo.moduloControl); };

            return btnModulo;
        }



        private void MontarMenu()
        {

            for (int i = 0; i < lstModulo.Count; i++)
            {
                pnlModulo.Controls.Add(CriarButtonModulo(lstModulo[i]));
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

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(controle);

            //pnlMainContent.Controls.Clear();
            //pnlMainContent.Controls.Add(controle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlSide_Paint(object sender, PaintEventArgs e)
        {

        }




        //private void btnConfig_Click(object sender, EventArgs e)
        //{
        //    ctmConfig.Show(btnConfig, btnConfig.Location.X, btnConfig.Location.Y + pnlHorizontalMenu.Height);
        //}

    }
}
