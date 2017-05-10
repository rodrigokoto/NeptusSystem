namespace NeptusSystemModules.Modules.Administracao.ModulesControl
{
    partial class ucAdministracao
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tlGaragem = new MetroFramework.Controls.MetroTile();
            this.tleApartamento = new MetroFramework.Controls.MetroTile();
            this.tleProprietario = new MetroFramework.Controls.MetroTile();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipal.Controls.Add(this.metroTile1);
            this.pnlPrincipal.Controls.Add(this.tlGaragem);
            this.pnlPrincipal.Controls.Add(this.tleApartamento);
            this.pnlPrincipal.Controls.Add(this.tleProprietario);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1023, 604);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Transparent;
            this.metroTile1.Location = new System.Drawing.Point(242, 155);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(186, 108);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Cadastra Morador";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::NeptusSystemModules.Properties.Resources.family;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tlGaragem
            // 
            this.tlGaragem.ActiveControl = null;
            this.tlGaragem.BackColor = System.Drawing.Color.Transparent;
            this.tlGaragem.Location = new System.Drawing.Point(50, 155);
            this.tlGaragem.Name = "tlGaragem";
            this.tlGaragem.Size = new System.Drawing.Size(186, 108);
            this.tlGaragem.TabIndex = 2;
            this.tlGaragem.Text = "Cadastrar Garagem";
            this.tlGaragem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlGaragem.TileImage = global::NeptusSystemModules.Properties.Resources.garage;
            this.tlGaragem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlGaragem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tlGaragem.UseSelectable = true;
            this.tlGaragem.UseTileImage = true;
            this.tlGaragem.Click += new System.EventHandler(this.tlGaragem_Click);
            // 
            // tleApartamento
            // 
            this.tleApartamento.ActiveControl = null;
            this.tleApartamento.BackColor = System.Drawing.Color.Transparent;
            this.tleApartamento.Location = new System.Drawing.Point(242, 41);
            this.tleApartamento.Name = "tleApartamento";
            this.tleApartamento.Size = new System.Drawing.Size(186, 108);
            this.tleApartamento.TabIndex = 1;
            this.tleApartamento.Text = "Cadastrar Apartamento";
            this.tleApartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tleApartamento.TileImage = global::NeptusSystemModules.Properties.Resources.building;
            this.tleApartamento.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tleApartamento.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tleApartamento.UseSelectable = true;
            this.tleApartamento.UseTileImage = true;
            this.tleApartamento.Click += new System.EventHandler(this.tleApartamento_Click);
            // 
            // tleProprietario
            // 
            this.tleProprietario.ActiveControl = null;
            this.tleProprietario.Location = new System.Drawing.Point(50, 41);
            this.tleProprietario.Name = "tleProprietario";
            this.tleProprietario.Size = new System.Drawing.Size(186, 108);
            this.tleProprietario.TabIndex = 0;
            this.tleProprietario.Text = "Cadastrar Proprietário";
            this.tleProprietario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tleProprietario.TileImage = global::NeptusSystemModules.Properties.Resources.businessman;
            this.tleProprietario.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tleProprietario.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tleProprietario.UseSelectable = true;
            this.tleProprietario.UseTileImage = true;
            this.tleProprietario.Click += new System.EventHandler(this.tleProprietario_Click);
            // 
            // ucAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "ucAdministracao";
            this.Size = new System.Drawing.Size(1023, 604);
            this.pnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tleProprietario;
        private System.Windows.Forms.Panel pnlPrincipal;
        private MetroFramework.Controls.MetroTile tleApartamento;
        private MetroFramework.Controls.MetroTile tlGaragem;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
