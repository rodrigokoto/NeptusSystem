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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tleProprietario = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tleProprietario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 604);
            this.panel1.TabIndex = 4;
            // 
            // tleProprietario
            // 
            this.tleProprietario.ActiveControl = null;
            this.tleProprietario.Location = new System.Drawing.Point(50, 41);
            this.tleProprietario.Name = "tleProprietario";
            this.tleProprietario.Size = new System.Drawing.Size(138, 105);
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
    }
}
