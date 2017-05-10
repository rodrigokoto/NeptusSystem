using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystemModules.Modules.Administracao.ModulesControl.Apartamento
{
    public partial class ucAptCadastro : MetroFramework.Controls.MetroUserControl
    {
        public ucAptCadastro()
        {
            InitializeComponent();

            PopularGridApartamento();
        }

        List<Model.Apartamento> lstApartamento = new List<Model.Apartamento>();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtBloco.Text != "" && txtIni.Text != "" && txtFim.Text != "")
            {
                pnlLoading.Visible = true;

                string bloco = txtBloco.Text;
                int ini = Convert.ToInt32(txtIni.Text);
                int fim = Convert.ToInt32(txtFim.Text);


                for (int i = ini; i <= fim; i++)
                {
                    Model.Apartamento apartamento = new Model.Apartamento()
                    {
                        blocoApart = bloco,
                        NumeroApart = i
                    };

                    lstApartamento.Add(apartamento);
                }

                grdApartamento.Rows.Clear();

                for (int i = 0; i < lstApartamento.Count; i++)
                {
                    grdApartamento.Rows.Add(new object[] { lstApartamento[i].blocoApart, lstApartamento[i].NumeroApart });
                }

                //grdApartamento.DataSource = null;
                //grdApartamento.DataSource = lstApartamento;

                pnlLoading.Visible = false;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Preencha todos os componentes para continuar.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pnlLoading.Visible = true;

            if (lstApartamento.Equals(new BLL.BllApartamento().Return_ListApartamento()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Não há novos registros para serem salvos.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL.BllApartamento bllapartamento = new BLL.BllApartamento();

                RemoverCadastrados();

                for (int i = 0; i < lstApartamento.Count; i++)
                {
                    Model.Apartamento apartamento = new Model.Apartamento();

                    apartamento = lstApartamento[i];

                    bllapartamento.Insert_Apartamento(apartamento);

                }

                MetroFramework.MetroMessageBox.Show(this, "Apartamentos cadastrados com sucesso.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PopularGridApartamento();

                pnlLoading.Visible = false;
            }
        }

        private void PopularGridApartamento()
        {
            BLL.BllApartamento bllapartamento = new BLL.BllApartamento();

            lstApartamento.Clear();

            lstApartamento = bllapartamento.Return_ListApartamento();

            if (grdApartamento.Rows.Count > 0)
                grdApartamento.Rows.Clear();
            for (int i = 0; i < lstApartamento.Count; i++)
            {
                grdApartamento.Rows.Add(new object[] { lstApartamento[i].blocoApart, lstApartamento[i].NumeroApart });
            }
        }

        public void RemoverCadastrados()
        {
            List<Model.Apartamento> lstremover = new BLL.BllApartamento().Return_ListApartamento();

            for (int i = 0; i < lstremover.Count; i++)
            {
                lstApartamento.RemoveAll(x => x.blocoApart == lstremover[i].blocoApart && x.NumeroApart == lstremover[i].NumeroApart);
            }
        }

        private void txtIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
