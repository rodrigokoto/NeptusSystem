using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystem.Forms.Main
{
    public partial class frmSplashScreen : MetroFramework.Forms.MetroForm
    {
        public frmSplashScreen()
        {
            InitializeComponent();

            CarregarLabels();

        }

        private void CarregarLabels()
        {
            var pos = this.PointToScreen(lblVersion.Location);
            pos = pictureBox1.PointToClient(pos);
            lblVersion.Parent = pictureBox1;
            lblVersion.Location = pos;
            lblVersion.BackColor = Color.Transparent;

            var pos1 = this.PointToScreen(lblLoading.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            lblLoading.Parent = pictureBox1;
            lblLoading.Location = pos1;
            lblLoading.BackColor = Color.Transparent;

        }


    }
}
