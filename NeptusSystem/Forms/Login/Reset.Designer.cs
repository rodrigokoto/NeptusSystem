namespace NeptusSystem.Forms.Login
{
    partial class Reset
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtnewpass = new MetroFramework.Controls.MetroTextBox();
            this.lblnewpass = new MetroFramework.Controls.MetroLabel();
            this.lblconfirmpass = new MetroFramework.Controls.MetroLabel();
            this.txtconfirmpass = new MetroFramework.Controls.MetroTextBox();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.txtoldpass = new MetroFramework.Controls.MetroTextBox();
            this.lbloldpass = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnewpass
            // 
            // 
            // 
            // 
            this.txtnewpass.CustomButton.Image = null;
            this.txtnewpass.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtnewpass.CustomButton.Name = "";
            this.txtnewpass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtnewpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnewpass.CustomButton.TabIndex = 1;
            this.txtnewpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnewpass.CustomButton.UseSelectable = true;
            this.txtnewpass.CustomButton.Visible = false;
            this.txtnewpass.Lines = new string[0];
            this.txtnewpass.Location = new System.Drawing.Point(23, 113);
            this.txtnewpass.MaxLength = 32767;
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '*';
            this.txtnewpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnewpass.SelectedText = "";
            this.txtnewpass.SelectionLength = 0;
            this.txtnewpass.SelectionStart = 0;
            this.txtnewpass.ShortcutsEnabled = true;
            this.txtnewpass.Size = new System.Drawing.Size(244, 23);
            this.txtnewpass.TabIndex = 0;
            this.txtnewpass.UseSelectable = true;
            this.txtnewpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnewpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.Location = new System.Drawing.Point(21, 92);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(41, 19);
            this.lblnewpass.TabIndex = 1;
            this.lblnewpass.Text = "Novo";
            // 
            // lblconfirmpass
            // 
            this.lblconfirmpass.AutoSize = true;
            this.lblconfirmpass.Location = new System.Drawing.Point(21, 139);
            this.lblconfirmpass.Name = "lblconfirmpass";
            this.lblconfirmpass.Size = new System.Drawing.Size(69, 19);
            this.lblconfirmpass.TabIndex = 3;
            this.lblconfirmpass.Text = "Confirmar";
            // 
            // txtconfirmpass
            // 
            // 
            // 
            // 
            this.txtconfirmpass.CustomButton.Image = null;
            this.txtconfirmpass.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtconfirmpass.CustomButton.Name = "";
            this.txtconfirmpass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtconfirmpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtconfirmpass.CustomButton.TabIndex = 1;
            this.txtconfirmpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtconfirmpass.CustomButton.UseSelectable = true;
            this.txtconfirmpass.CustomButton.Visible = false;
            this.txtconfirmpass.Lines = new string[0];
            this.txtconfirmpass.Location = new System.Drawing.Point(23, 161);
            this.txtconfirmpass.MaxLength = 32767;
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.PasswordChar = '*';
            this.txtconfirmpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtconfirmpass.SelectedText = "";
            this.txtconfirmpass.SelectionLength = 0;
            this.txtconfirmpass.SelectionStart = 0;
            this.txtconfirmpass.ShortcutsEnabled = true;
            this.txtconfirmpass.Size = new System.Drawing.Size(244, 23);
            this.txtconfirmpass.TabIndex = 1;
            this.txtconfirmpass.UseSelectable = true;
            this.txtconfirmpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtconfirmpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(192, 255);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseSelectable = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtoldpass
            // 
            // 
            // 
            // 
            this.txtoldpass.CustomButton.Image = null;
            this.txtoldpass.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtoldpass.CustomButton.Name = "";
            this.txtoldpass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtoldpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtoldpass.CustomButton.TabIndex = 1;
            this.txtoldpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtoldpass.CustomButton.UseSelectable = true;
            this.txtoldpass.CustomButton.Visible = false;
            this.txtoldpass.Lines = new string[0];
            this.txtoldpass.Location = new System.Drawing.Point(23, 209);
            this.txtoldpass.MaxLength = 32767;
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.PasswordChar = '*';
            this.txtoldpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtoldpass.SelectedText = "";
            this.txtoldpass.SelectionLength = 0;
            this.txtoldpass.SelectionStart = 0;
            this.txtoldpass.ShortcutsEnabled = true;
            this.txtoldpass.Size = new System.Drawing.Size(244, 23);
            this.txtoldpass.TabIndex = 2;
            this.txtoldpass.UseSelectable = true;
            this.txtoldpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtoldpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbloldpass
            // 
            this.lbloldpass.AutoSize = true;
            this.lbloldpass.Location = new System.Drawing.Point(23, 187);
            this.lbloldpass.Name = "lbloldpass";
            this.lbloldpass.Size = new System.Drawing.Size(48, 19);
            this.lbloldpass.TabIndex = 6;
            this.lbloldpass.Text = "Antigo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 309);
            this.Controls.Add(this.lbloldpass);
            this.Controls.Add(this.txtoldpass);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblconfirmpass);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.lblnewpass);
            this.Controls.Add(this.txtnewpass);
            this.Name = "Reset";
            this.Text = "Alterar Senha.";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtnewpass;
        private MetroFramework.Controls.MetroLabel lblnewpass;
        private MetroFramework.Controls.MetroLabel lblconfirmpass;
        private MetroFramework.Controls.MetroTextBox txtconfirmpass;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroTextBox txtoldpass;
        private MetroFramework.Controls.MetroLabel lbloldpass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}