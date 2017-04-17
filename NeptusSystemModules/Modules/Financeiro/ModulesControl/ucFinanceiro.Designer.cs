namespace NeptusSystemModules.Modules.Financeiro.ModulesControl
{
    partial class ucFinanceiro
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabFinanceiro = new MetroFramework.Controls.MetroTabControl();
            this.tabCPagar = new MetroFramework.Controls.MetroTabPage();
            this.tabCReceber = new MetroFramework.Controls.MetroTabPage();
            this.tabFinanceiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFinanceiro
            // 
            this.tabFinanceiro.Controls.Add(this.tabCPagar);
            this.tabFinanceiro.Controls.Add(this.tabCReceber);
            this.tabFinanceiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFinanceiro.Location = new System.Drawing.Point(0, 0);
            this.tabFinanceiro.Name = "tabFinanceiro";
            this.tabFinanceiro.SelectedIndex = 1;
            this.tabFinanceiro.Size = new System.Drawing.Size(992, 614);
            this.tabFinanceiro.TabIndex = 0;
            this.tabFinanceiro.UseSelectable = true;
            // 
            // tabCPagar
            // 
            this.tabCPagar.HorizontalScrollbarBarColor = true;
            this.tabCPagar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCPagar.HorizontalScrollbarSize = 10;
            this.tabCPagar.Location = new System.Drawing.Point(4, 38);
            this.tabCPagar.Name = "tabCPagar";
            this.tabCPagar.Size = new System.Drawing.Size(984, 572);
            this.tabCPagar.TabIndex = 0;
            this.tabCPagar.Text = "Contas a Pagar";
            this.tabCPagar.VerticalScrollbarBarColor = true;
            this.tabCPagar.VerticalScrollbarHighlightOnWheel = false;
            this.tabCPagar.VerticalScrollbarSize = 10;
            // 
            // tabCReceber
            // 
            this.tabCReceber.HorizontalScrollbarBarColor = true;
            this.tabCReceber.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCReceber.HorizontalScrollbarSize = 10;
            this.tabCReceber.Location = new System.Drawing.Point(4, 38);
            this.tabCReceber.Name = "tabCReceber";
            this.tabCReceber.Size = new System.Drawing.Size(984, 572);
            this.tabCReceber.TabIndex = 1;
            this.tabCReceber.Text = "Contas a Receber";
            this.tabCReceber.VerticalScrollbarBarColor = true;
            this.tabCReceber.VerticalScrollbarHighlightOnWheel = false;
            this.tabCReceber.VerticalScrollbarSize = 10;
            // 
            // ucFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabFinanceiro);
            this.Name = "ucFinanceiro";
            this.Size = new System.Drawing.Size(992, 614);
            this.tabFinanceiro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabFinanceiro;
        private MetroFramework.Controls.MetroTabPage tabCPagar;
        private MetroFramework.Controls.MetroTabPage tabCReceber;
    }
}
