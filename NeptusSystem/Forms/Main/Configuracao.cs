using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystem.Forms.Main
{
    public partial class Configuracao : MetroFramework.Controls.MetroUserControl
    {
        public Configuracao()
        {
            InitializeComponent();
        }

        private void tlUser_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            usu.Show();
        }
    }
}
