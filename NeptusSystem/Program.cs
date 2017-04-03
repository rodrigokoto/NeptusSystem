using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeptusSystem.Forms.Login;
using NeptusSystem.Forms.Main;

namespace NeptusSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login lg = new Login();
            
            if (lg.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }

            
        }
    }
}
