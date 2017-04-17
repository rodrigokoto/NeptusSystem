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
            this.tleProprietario = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tleProprietario
            // 
            this.tleProprietario.ActiveControl = null;
            this.tleProprietario.Location = new System.Drawing.Point(183, 106);
            this.tleProprietario.Name = "tleProprietario";
            this.tleProprietario.Size = new System.Drawing.Size(183, 137);
            this.tleProprietario.TabIndex = 0;
            this.tleProprietario.Text = "Proprietário";
            this.tleProprietario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tleProprietario.TileImage = global::NeptusSystemModules.Properties.Resources.businessman;
            this.tleProprietario.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tleProprietario.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tleProprietario.UseSelectable = true;
            this.tleProprietario.UseTileImage = true;
            this.tleProprietario.Click += new System.EventHandler(this.tleProprietario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTile3);
            this.panel1.Controls.Add(this.metroTile2);
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Controls.Add(this.tleProprietario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 604);
            this.panel1.TabIndex = 4;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DarkOrange;
            this.metroTile1.Location = new System.Drawing.Point(372, 106);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(170, 137);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Proprietário";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::NeptusSystemModules.Properties.Resources.businessman;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(183, 261);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(359, 110);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Proprietário";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::NeptusSystemModules.Properties.Resources.businessman;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(183, 402);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(359, 121);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Proprietário";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = global::NeptusSystemModules.Properties.Resources.businessman;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // ucAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucAdministracao";
            this.Size = new System.Drawing.Size(1023, 604);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tleProprietario;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
