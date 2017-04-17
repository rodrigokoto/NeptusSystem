using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystemModules.Modules
{
    public partial class ContainerModules : MetroFramework.Forms.MetroForm
    {
        private string Title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

      

        
        public ContainerModules()
        {
            InitializeComponent();
        }

        public void AddControl(MetroFramework.Controls.MetroUserControl control, string ControlTitle )
        {
            pnlContainer.Controls.Clear();
            Title = ControlTitle;

            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            Size full = new Size(workingRectangle.Width, workingRectangle.Height);
            Size comparation = this.Size + control.Size;
            Size size = new Size();

            if (comparation.Width > full.Width)
            {
                size.Width = full.Width;
            }
            else
            {
                size.Width = comparation.Width;
            }

            if (comparation.Height > full.Height)
            {
                size.Height = full.Height;
            }
            else {
                size.Height = comparation.Height;
            }

            this.Size = size;
            pnlContainer.Controls.Add(control);
        }
    }
}
