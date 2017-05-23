using NeptusSystem.BLL;
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
    public partial class Usuario : MetroFramework.Forms.MetroForm
    {

        bool Error = false;
        List<Model.User> lstUser = new List<Model.User>();
        int cellClicked = 0;

        public Usuario()
        {
            InitializeComponent();
            PopularGridUsuario();
            PopularArea();
        }

        public void PopularGridUsuario()
        {
            BllUser blluser = new BllUser();
            lstUser = blluser.ReturnUserList();

            foreach (Model.User user in lstUser)
            {
                grdUser.Rows.Add(user.IdUsuario, user.Usuario);
            }
        }

        private void grdUser_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                cellClicked = e.RowIndex;

                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedcell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    this.grdUser.CurrentCell = clickedcell;

                    var RelativeMousePosition = grdUser.PointToClient(Cursor.Position);

                    this.mcmUser.Show(grdUser, RelativeMousePosition);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCadastro()
        {
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

        public void PopularArea()
        {
            cmbArea.DataSource = Enum.GetValues(typeof(ContractLicence.Area));
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            Error = false;

            if (!ValidarCadastro())
            {
                Model.User user = new Model.User();

                user.Acesso = "99";
                user.Area = cmbArea.SelectedItem.ToString();
                user.Usuario = txtUsuario.Text;
                user.Password = txtPassword.Text;

                var cadastrado = from p in lstUser
                                 where p.Usuario == user.Usuario
                                 select p;

                if (cadastrado.Count() > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Usuário já cadastrado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    BllUser blluser = new BllUser();

                    blluser.CreateUser(user);

                    MetroFramework.MetroMessageBox.Show(this, "Usuário cadastrado com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Erro ao cadastrar usuário , preencha todos os campos.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void resetarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           string t = grdUser.Rows[cellClicked].Cells[0].Value.ToString();

            var user = from p in lstUser
                       where p.IdUsuario == Convert.ToInt32(t)
                       select p;

            BllUser blluser = new BllUser();
            
            foreach (var u in user)
            {
                u.Password = "123mudar";
                blluser.ResetPassword(u);
            }

            MetroFramework.MetroMessageBox.Show(this, "Usuário cadastrado com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
