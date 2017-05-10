using MetroFramework;
using NeptusSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystem.Forms.Login
{
    public partial class Reset : MetroFramework.Forms.MetroForm
    {
        public string Login { get; set; }
        private bool Error = false;

        public Reset()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                if (txtnewpass.Text == txtconfirmpass.Text)
                {
                    BLL.BllUser blluser = new BLL.BllUser();
                    User user = blluser.ReturnUser(Login);

                    if (user.Password != txtoldpass.Text)
                    {
                        MetroMessageBox.Show(this, "Senha antiga não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        user.Password = txtnewpass.Text;

                        blluser.ResetPassword(user);

                        DialogResult result = MetroMessageBox.Show(this, "Senha alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Senha antiga não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                }

               
                
            }
        }
        private bool ValidarCampos()
        {
            Error = false;

            foreach (var c in this.Controls)
            {
                if (c is MetroFramework.Controls.MetroTextBox)
                {
                    MetroFramework.Controls.MetroTextBox t = new MetroFramework.Controls.MetroTextBox();
                    t = (MetroFramework.Controls.MetroTextBox)c;

                    if (t.Text == "")
                    {
                        errorProvider1.SetError(t, "Campo Obrigatório");
                        Error = true;

                    }
                    else if (Error != true)
                    {
                        Error = false;
                    }
                }
            }
            return Error;
        }
    }
}
