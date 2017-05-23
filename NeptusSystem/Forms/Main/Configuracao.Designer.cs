namespace NeptusSystem.Forms.Main
{
    partial class Configuracao
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
            this.tlUser = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tlUser
            // 
            this.tlUser.ActiveControl = null;
            this.tlUser.Location = new System.Drawing.Point(62, 32);
            this.tlUser.Name = "tlUser";
            this.tlUser.Size = new System.Drawing.Size(145, 139);
            this.tlUser.TabIndex = 0;
            this.tlUser.Text = "Usuários";
            this.tlUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlUser.TileImage = global::NeptusSystem.Properties.Resources.users;
            this.tlUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlUser.UseSelectable = true;
            this.tlUser.UseTileImage = true;
            this.tlUser.Click += new System.EventHandler(this.tlUser_Click);
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlUser);
            this.Name = "Configuracao";
            this.Size = new System.Drawing.Size(990, 602);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tlUser;
    }
}
