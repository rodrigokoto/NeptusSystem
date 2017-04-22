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
using NeptusSystemModules.Modules.Administracao.Model.Proprietario;
using NeptusSystemModules.Modules.Administracao.Model.Endereco;

namespace NeptusSystemModules.Modules.Administracao.ModulesControl
{
    public partial class ucProprietario : MetroFramework.Controls.MetroUserControl
    {
        List<Proprietario> lstProprietario;
        
        public ucProprietario()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            PopularListProprietario();

            popularUF();

        }

        public async void PopularListProprietario()
        {
            dgrProprietario.Rows.Clear();

            BLL.BllProprietario bllproprietario = new BLL.BllProprietario();
            lstProprietario = bllproprietario.Return_ListProprietario();

            for (int i = 0; i < lstProprietario.Count; i++)
            {
                dgrProprietario.Rows.Add(lstProprietario[i].PROPID, lstProprietario[i].PROPNOME);
            }
        }

        bool Error = false;

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

        private void chkfisica_CheckedChanged(object sender, EventArgs e)
        {
            chkjuridica.Checked = false;
        }

        private void chkjuridica_CheckedChanged(object sender, EventArgs e)
        {
            chkfisica.Checked = false;
        }

        private void popularUF()
        {
            cbxUF.DataSource = Enum.GetValues(typeof(UF));
            cbxUF.SelectedItem = UF.SP;

        }

        private void chkfisica_OnChange(object sender, EventArgs e)
        {
            if (chkfisica.Checked == true)
            {
                chkjuridica.Checked = false;
                lblDoc.Text = "CPF";
                txtDoc.Enabled = true;
                txtDoc.MaxLength = 14;
                txtDoc.Text = "";
            }
            else
            {
                chkjuridica.Checked = true;
                lblDoc.Text = "CNPJ";
                txtDoc.Enabled = true;
                txtDoc.MaxLength = 18;
                txtDoc.Text = "";
            }
        }

        private void chkjuridica_OnChange(object sender, EventArgs e)
        {
            if (chkjuridica.Checked == true)
            {
                chkfisica.Checked = false;
                lblDoc.Text = "CNPJ";
                txtDoc.Enabled = true;
                txtDoc.MaxLength = 18;
                txtDoc.Text = "";
            }
            else
            {
                chkfisica.Checked = true;
                lblDoc.Text = "CPF";
                txtDoc.Enabled = true;
                txtDoc.MaxLength = 14;
                txtDoc.Text = "";
            }
        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox t = sender as MetroFramework.Controls.MetroTextBox; // ou text Box
            if (chkfisica.Checked == true)
            {
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
            else if (chkjuridica.Checked == true)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                {
                    t.SelectionStart = t.Text.Length + 1;

                    if (t.Text.Length == 2 || t.Text.Length == 6)
                        t.Text += ".";
                    else if (t.Text.Length == 10)
                        t.Text += "/";
                    else if (t.Text.Length == 15)
                        t.Text += "-";
                    t.SelectionStart = t.Text.Length + 1;
                }
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

                    if (t.Name != txtSearch.Name && t.Name != txtComp.Name)
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
            return Error;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Error = false;
            BLL.BllProprietario bllprop = new BLL.BllProprietario();
            BLL.BllEndereco bllendereco = new BLL.BllEndereco();
            Endereco endereco = new Endereco();
            if (!validarComponentes())
            {
                if (btnInserir.Text == "Inserir")
                {

                    Proprietario modelProp = new Proprietario();
                    modelProp.PROPNOME = txtNome.Text;
                    modelProp.PROPDOC = txtDoc.Text;
                    modelProp.PROPRG = txtRG.Text;
                    modelProp.PROPTEL = txtTel.Text;
                    modelProp.PROPCEL = txtCel.Text;
                    modelProp.PROPDDD1 = txtDDD1.Text;
                    modelProp.PROPDDD2 = txtDDD2.Text;
                    endereco.ENDRUA = txtRua.Text;
                    endereco.ENDNUM = txtNumero.Text;
                    endereco.ENDCOMPLEMENTO = txtComp.Text == "" ? "ND" : txtComp.Text;
                    endereco.ENDBAIRRO = txtBairro.Text;
                    endereco.ENDCEP = txtCep.Text;
                    endereco.ENDCIDADE = txtCidade.Text;
                    endereco.ENDESTADO = txtEstado.Text;
                    endereco.ENDUF = cbxUF.Text;
                    if (chkfisica.Checked == true)
                    {
                        modelProp.PROPTPPESSOA = "F";
                    }
                    else if (chkjuridica.Checked == true)
                    {
                        modelProp.PROPTPPESSOA = "J";
                    }
                    modelProp.PROPEND = bllendereco.Insert_Endereco(endereco);

                    if (ValidarEmail(txtEmail.Text))
                    {
                        modelProp.PROPMAIL = txtEmail.Text;
                    }
                    else
                    {
                        Error = true;
                    }

                    if (Error == false)
                    {
                        bllprop.Insert_Proprietario(modelProp);
                        MetroMessageBox.Show(this, "Proprietário cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    PopularListProprietario();
                    LimparCampos();
                }
                else if (btnInserir.Text == "Alterar")
                {
                    Proprietario modelProp = new Proprietario();
                    modelProp.PROPID = Convert.ToInt32(lblID.Text);
                    modelProp.PROPNOME = txtNome.Text;
                    modelProp.PROPDOC = txtDoc.Text;
                    modelProp.PROPRG = txtRG.Text;
                    modelProp.PROPTEL = txtTel.Text;
                    modelProp.PROPCEL = txtCel.Text;
                    modelProp.PROPDDD1 = txtDDD1.Text;
                    modelProp.PROPDDD2 = txtDDD2.Text;
                    
                    endereco.ENDID = Convert.ToInt32(lblIdEnd.Text);
                    endereco.ENDRUA = txtRua.Text;
                    endereco.ENDNUM = txtNumero.Text;
                    endereco.ENDCOMPLEMENTO = txtComp.Text == "" ? "ND" : txtComp.Text;
                    endereco.ENDBAIRRO = txtBairro.Text;
                    endereco.ENDCEP = txtCep.Text;
                    endereco.ENDCIDADE = txtCidade.Text;
                    endereco.ENDESTADO = txtEstado.Text;
                    endereco.ENDUF = cbxUF.Text;

                    modelProp.PROPEND = endereco.ENDID;

                    if (chkfisica.Checked == true)
                    {
                        modelProp.PROPTPPESSOA = "F";
                    }
                    else if (chkjuridica.Checked == true)
                    {
                        modelProp.PROPTPPESSOA = "J";
                    }

                    bllendereco.Update_Endereco(endereco);

                    if (ValidarEmail(txtEmail.Text))
                    {
                        modelProp.PROPMAIL = txtEmail.Text;
                    }
                    else
                    {
                        Error = true;
                    }

                    if (Error == false)
                    {
                        bllprop.Update_Proprietario(modelProp);
                        MetroMessageBox.Show(this, "Proprietário alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    PopularListProprietario();
                    LimparCampos();
                }
            }
        }

        public void LimparCampos()
        {
            chkfisica.Checked = false;
            chkjuridica.Checked = false;
            txtNome.Text = "";
            txtDoc.Text = "";
            txtRG.Text = "";
            txtDDD1.Text = "";
            txtDDD2.Text = "";
            txtTel.Text = "";
            txtCel.Text = "";
            txtEmail.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtComp.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            cbxUF.SelectedItem = UF.SP;
            txtCidade.Text = "";
            txtEstado.Text = "";

            btnInserir.Text = "Inserir";
        }

        private void PopularGridProprietario(string search = "")
        {
            List<Proprietario> lstSearch = new List<Proprietario>();
            dgrProprietario.Rows.Clear();

            if (search != "")
            {
                lstSearch = lstProprietario.Where(item => item.PROPNOME.ToLower().Contains(search.ToLower())).ToList();
            }
            else
            {
                lstSearch = lstProprietario;
            }

            for (int i = 0; i < lstSearch.Count; i++)
            {
                dgrProprietario.Rows.Add(lstSearch[i].PROPID, lstSearch[i].PROPNOME);
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

        private void dgrProprietario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgrProprietario.Rows[e.RowIndex].Cells[0].Value.ToString());

            BLL.BllProprietario bllproprietario = new BLL.BllProprietario();
            BLL.BllEndereco bllendereco = new BLL.BllEndereco();

            Proprietario proprietario = new Proprietario();
            Endereco endereco = new Endereco();

            proprietario = bllproprietario.Return_Proprietario(ID);
            endereco = bllendereco.Return_Endereco(proprietario.PROPEND);

            txtNome.Text = proprietario.PROPNOME;
            txtDoc.Text = proprietario.PROPDOC;
            txtRG.Text = proprietario.PROPRG;
            txtDDD1.Text = proprietario.PROPDDD1;
            txtDDD2.Text = proprietario.PROPDDD2;

            if (proprietario.PROPTPPESSOA == "F")
            {
                chkfisica.Checked = true;
                chkjuridica.Checked = false;
            }
            else
            {
                chkfisica.Checked = false;
                chkjuridica.Checked = true;
            }

            txtTel.Text = proprietario.PROPTEL;
            txtCel.Text = proprietario.PROPCEL;
            txtEmail.Text = proprietario.PROPMAIL;
            txtRua.Text = endereco.ENDRUA;
            txtNumero.Text = endereco.ENDNUM;
            txtComp.Text = endereco.ENDCOMPLEMENTO;
            txtBairro.Text = endereco.ENDBAIRRO;
            txtCep.Text = endereco.ENDCEP;
            txtCidade.Text = endereco.ENDCIDADE;
            txtEstado.Text = endereco.ENDESTADO;
            cbxUF.SelectedItem = new Util().Retorna_UF(endereco.ENDUF);
            btnInserir.Text = "Alterar";
            lblID.Text = proprietario.PROPID.ToString();
            lblIdEnd.Text = proprietario.PROPEND.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
