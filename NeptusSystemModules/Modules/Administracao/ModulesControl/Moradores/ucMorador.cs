using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeptusSystemModules.Modules.ControlesNeptus.UserControls.Endereco;
using NeptusSystemModules.Modules.ControlesNeptus.Util;
using System.Text.RegularExpressions;
using MetroFramework;
using NeptusSystemModules.Modules.Administracao.Model;


namespace NeptusSystemModules.Modules.Administracao.ModulesControl
{
    public partial class ucMorador : MetroFramework.Controls.MetroUserControl
    {
        List<Morador> lstMorador;
        List<Model.Apartamento> lstApartamento;
        bool Error = false;

        public ucMorador()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PopularListMorador();
            PopularApartamento();
        }

        public void PopularListMorador()
        {
            dgrMorador.Rows.Clear();

            BLL.BllMorador bllMorador = new BLL.BllMorador();
            lstMorador = bllMorador.Return_ListMorador();

            for (int i = 0; i < lstMorador.Count; i++)
            {
                dgrMorador.Rows.Add(lstMorador[i].MORADORID, lstMorador[i].MORADORNOME);
            }
        }

        public bool ValidarEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, "E-mail não é valido, por gentileza inserir um e-mail valido.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox t = sender as MetroFramework.Controls.MetroTextBox; // ou text Box
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 3 || t.Text.Length == 7)
                    t.Text += ".";
                else if (t.Text.Length == 11)
                    t.Text += "-";
                t.SelectionStart = t.Text.Length + 1;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox t = sender as MetroFramework.Controls.MetroTextBox; // ou text Box
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 2 || t.Text.Length == 6)
                    t.Text += ".";
                else if (t.Text.Length == 10)
                    t.Text += "-";
                t.SelectionStart = t.Text.Length + 1;
            }
        }

        protected bool validarComponentes()
        {
            foreach (var c in this.Controls)
            {
                if (c is MetroFramework.Controls.MetroTextBox)
                {
                    MetroFramework.Controls.MetroTextBox t = new MetroFramework.Controls.MetroTextBox();
                    t = (MetroFramework.Controls.MetroTextBox)c;

                    if (t.Name != txtSearch.Name && t.Name != txtEmail.Name)
                    {
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
            }

            if (cbxApartamento.SelectedValue == null)
            {
                errorProvider1.SetError(cbxApartamento, "Selecione um apartamento");
                Error = true;
            }
            return Error;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Error = false;
            BLL.BllMorador bllMorador = new BLL.BllMorador();

            if (!validarComponentes())
            {
                if (btnInserir.Text == "Inserir")
                {

                    Morador modelMorador = new Morador();
                    modelMorador.MORADORNOME = txtNome.Text;
                    modelMorador.MORADORCPF = txtDoc.Text;
                    modelMorador.MORADORRG = txtRG.Text;
                    modelMorador.MORADORDTEL = txtTel.Text;
                    modelMorador.MORADORDCEL = txtCel.Text;
                    modelMorador.MORADORDDD1 = txtDDD1.Text;
                    modelMorador.MORADORDDD2 = txtDDD2.Text;

                    modelMorador.MORADORAPART = Convert.ToInt32(cbxApartamento.SelectedValue);

                    if (ValidarEmail(txtEmail.Text))
                    {
                        modelMorador.MORADOREMAIL = txtEmail.Text;
                    }
                    else
                    {
                        Error = true;
                    }

                    if (Error == false)
                    {
                        bllMorador.Insert_Morador(modelMorador);
                        MetroMessageBox.Show(this, "Morador cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    PopularListMorador();
                    LimparCampos();
                }
                else if (btnInserir.Text == "Alterar")
                {

                    Morador modelMorador = new Morador();
                    modelMorador.MORADORID = Convert.ToInt32(lblID.Text);
                    modelMorador.MORADORNOME = txtNome.Text;
                    modelMorador.MORADORCPF = txtDoc.Text;
                    modelMorador.MORADORRG = txtRG.Text;
                    modelMorador.MORADORDTEL = txtTel.Text;
                    modelMorador.MORADORDCEL = txtCel.Text;
                    modelMorador.MORADORDDD1 = txtDDD1.Text;
                    modelMorador.MORADORDDD2 = txtDDD2.Text;

                    modelMorador.MORADORAPART = Convert.ToInt32(cbxApartamento.SelectedValue);

                    if (ValidarEmail(txtEmail.Text))
                    {
                        modelMorador.MORADOREMAIL = txtEmail.Text;
                    }
                    else
                    {
                        Error = true;
                    }

                    if (Error == false)
                    {
                        bllMorador.Update_Proprietario(modelMorador);
                        MetroMessageBox.Show(this, "Morador alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    PopularListMorador();
                    LimparCampos();
                }
            }
        }

        public void ValidarApartamentoCadastrado()
        {
            List<Model.Apartamento> lstFiltro = new BLL.BllApartamento().Retorna_Cadastrados();

            for (int i = 0; i < lstFiltro.Count; i++)
            {
                lstApartamento.RemoveAll(x => x.idApart == lstFiltro[i].idApart);
            }

        }

        public void LimparCampos()
        {
            txtNome.Text = "";
            txtDoc.Text = "";
            txtRG.Text = "";
            txtDDD1.Text = "";
            txtDDD2.Text = "";
            txtTel.Text = "";
            txtCel.Text = "";
            txtEmail.Text = "";
            cbxApartamento.SelectedValue = 0;

            btnInserir.Text = "Inserir";
        }

        private void PopularGridProprietario(string search = "")
        {
            List<Morador> lstSearch = new List<Morador>();
            dgrMorador.Rows.Clear();

            if (search != "")
            {
                lstSearch = lstMorador.Where(item => item.MORADORNOME.ToLower().Contains(search.ToLower())).ToList();
            }
            else
            {
                lstSearch = lstMorador;
            }

            for (int i = 0; i < lstSearch.Count; i++)
            {
                dgrMorador.Rows.Add(lstSearch[i].MORADORID, lstSearch[i].MORADORNOME);
            }
        }


        private void btnCarregar_Click_1(object sender, EventArgs e)
        {
            PopularGridProprietario();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopularGridProprietario(txtSearch.Text);
        }

        private void dgrMorador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInserir.Text = "Alterar";

            PopularApartamento();

            if (e.RowIndex != -1)
            {
                int ID = Convert.ToInt32(dgrMorador.Rows[e.RowIndex].Cells[0].Value.ToString());

                BLL.BllMorador bllMorador = new BLL.BllMorador();

                Morador morador = new Morador();
                Endereco endereco = new Endereco();

                morador = bllMorador.Return_Morador(ID);

                txtNome.Text = morador.MORADORNOME;
                txtDoc.Text = morador.MORADORCPF;
                txtRG.Text = morador.MORADORRG;
                txtDDD1.Text = morador.MORADORDDD1;
                txtDDD2.Text = morador.MORADORDDD2;

                cbxApartamento.SelectedValue = Convert.ToInt32(morador.MORADORAPART.ToString());

                txtTel.Text = morador.MORADORDTEL;
                txtCel.Text = morador.MORADORDCEL;
                txtEmail.Text = morador.MORADOREMAIL;
                lblID.Text = morador.MORADORID.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox t = sender as MetroFramework.Controls.MetroTextBox; // ou text Box


            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 4)
                {
                    t.Text += '-';
                    t.SelectionStart = t.Text.Length + 1;
                }
            }
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox t = sender as MetroFramework.Controls.MetroTextBox; // ou text Box
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 5)
                {
                    t.Text += '-';
                    t.SelectionStart = t.Text.Length + 1;
                }
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox t = sender as MetroFramework.Controls.MetroTextBox; // ou text Box
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 5)
                {
                    t.Text += '-';
                    t.SelectionStart = t.Text.Length + 1;
                }
            }
        }

        private void PopularApartamento()
        {
            lstApartamento = new BLL.BllApartamento().Return_ListApartamento();

            cbxApartamento.DataSource = lstApartamento;
            cbxApartamento.DisplayMember = "NumeroApart";
            cbxApartamento.ValueMember = "idApart";
        }

        private void cbxApartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            string ApartNumber = ((Model.Apartamento)e.ListItem).NumeroApart.ToString();
            string ApartBloco = ((Model.Apartamento)e.ListItem).blocoApart;

            e.Value = ApartNumber + " " + ApartBloco;
        }
    }
}
