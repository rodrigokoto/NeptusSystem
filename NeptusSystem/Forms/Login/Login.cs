using NeptusSystem.Forms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeptusSystem.BLL;
using NeptusSystem.Model;

namespace NeptusSystem.Forms.Login
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public bool ValidationError = false;

        public Login()
        {

            Thread t = new Thread(new ThreadStart(Startform));
            t.Start();
            Thread.Sleep(6000);

            InitializeComponent();
            t.Abort();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            popularArea();
        }

        public void Startform()
        {
            Application.Run(new Forms.Main.frmSplashScreen());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popularArea()
        {
            cmbArea.DataSource = Enum.GetValues(typeof(ContractLicence.Area));
        }

        #region Sistema

        private void btnLogin_Click(object sender, EventArgs e)
        {

            ValidarComponentes();

            if (!ValidationError)
            {
                User user = new User();
                BllUser blluser = new BllUser();

                string usuario = txtUser.Text;

                user = blluser.ReturnUser(usuario);

                if (user.Usuario != string.Empty)
                {
                    if (user.Password == txtPassword.Text)
                    {
                        if (user.Area.ToLower() == cmbArea.Text.ToLower())
                        {
                            CriarSession(user);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            lblErroCombo.Text = cmbArea.Text + " " + "Não autorizado.";

                            lblErroCombo.Visible = true;
                        }
                    }
                    else
                    {
                        lblErroSenha.Text = "Senha não confere";
                        lblErroSenha.Visible = true;

                    }
                }
                else
                {

                    lblErroUsuario.Text = "Usuário não localizado";
                    lblErroUsuario.Visible = true;

                }
            }



        }


        #endregion

        private void ValidarComponentes()
        {

            reseterror();

            List<MetroFramework.Controls.MetroTextBox> ListTextBox = new List<MetroFramework.Controls.MetroTextBox>();
            List<MetroFramework.Controls.MetroComboBox> ListComboBox = new List<MetroFramework.Controls.MetroComboBox>();

            //Adicionado os campos obrigatorios da validação TextBox 
            ListTextBox.Add(txtUser);
            ListTextBox.Add(txtPassword);


            //Adicionadao os campos obrigatorios da validação ComboBox
            ListComboBox.Add(cmbArea);


            for (int i = 0; i < ListTextBox.Count; i++)
            {
                if (ListTextBox[i].Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(ListTextBox[i], "Campo obrigatório");
                    ValidationError = true;
                }

            }

            for (int i = 0; i < ListComboBox.Count; i++)
            {
                if (ListComboBox[i].Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(ListComboBox[i], "Campo obrigatório");
                    ValidationError = true;
                }

            }


        }

        private void reseterror()
        {
            errorProvider1.Clear();
            ValidationError = false;

            lblErroCombo.Text = "";
            lblErroCombo.Visible = false;

            lblErroSenha.Text = "";
            lblErroSenha.Visible = false;

            lblErroUsuario.Text = "";
            lblErroUsuario.Visible = false;
        }

        private void CriarSession(User user)
        {
            Session.Session session = Session.Session.Instance;

            session.SessionAcesso = user.Acesso;
            //session.SessionArea = 
            session.SessionUser = user.Usuario;
            session.SessionStart = DateTime.Now;
        }
    }
}
