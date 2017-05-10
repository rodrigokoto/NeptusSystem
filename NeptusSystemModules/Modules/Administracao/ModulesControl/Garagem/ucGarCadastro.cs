using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptusSystemModules.Modules.Administracao.ModulesControl.Garagem
{
    public partial class ucGarCadastro : MetroFramework.Controls.MetroUserControl
    {
        public ucGarCadastro()
        {
            InitializeComponent();

            PopularGridGaragem();
        }

        List<Model.Garagem> lstGaragem = new List<Model.Garagem>();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtIni.Text != "" && txtFim.Text != "")
            {
                pnlLoading.Visible = true;

                string bloco = lblcharIdent.Text;
                int ini = Convert.ToInt32(txtIni.Text);
                int fim = Convert.ToInt32(txtFim.Text);


                for (int i = ini; i <= fim; i++)
                {
                    Model.Garagem garagem = new Model.Garagem()
                    {
                        GARIDENTIFICADOR = bloco,
                        GARNUMERO = i,
                        GARBOX = chkBox.Checked ? "S" : "N"
                      
                    };

                    lstGaragem.Add(garagem);
                }

                grdGaragem.Rows.Clear();

                for (int i = 0; i < lstGaragem.Count; i++)
                {
                    grdGaragem.Rows.Add(new object[] { lstGaragem[i].GARIDENTIFICADOR, lstGaragem[i].GARNUMERO , lstGaragem[i].GARBOX});
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

            if (lstGaragem.Equals(new BLL.BllGaragem().Return_ListGaragem()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Não há novos registros para serem salvos.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL.BllGaragem bllGaragem = new BLL.BllGaragem();

                RemoverCadastrados();

                for (int i = 0; i < lstGaragem.Count; i++)
                {
                    Model.Garagem garagem = new Model.Garagem();

                    garagem = lstGaragem[i];

                    bllGaragem.Insert_Garagem(garagem);

                }

                MetroFramework.MetroMessageBox.Show(this, "Garagens cadastrados com sucesso.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PopularGridGaragem();

                pnlLoading.Visible = false;
            }
        }

        private void PopularGridGaragem()
        {
            BLL.BllGaragem bllGaragem = new BLL.BllGaragem();

            lstGaragem.Clear();

            lstGaragem = bllGaragem.Return_ListGaragem();

            if (grdGaragem.Rows.Count > 0)
                grdGaragem.Rows.Clear();
            for (int i = 0; i < lstGaragem.Count; i++)
            {
                grdGaragem.Rows.Add(new object[] { lstGaragem[i].GARIDENTIFICADOR, lstGaragem[i].GARNUMERO, lstGaragem[i].GARBOX });
            }
        }

        public void RemoverCadastrados()
        {
            List<Model.Garagem> lstremover = new BLL.BllGaragem().Return_ListGaragem();

            for (int i = 0; i < lstremover.Count; i++)
            {
                lstGaragem.RemoveAll(x => x.GARIDENTIFICADOR == lstremover[i].GARIDENTIFICADOR && x.GARNUMERO == lstremover[i].GARNUMERO);
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
