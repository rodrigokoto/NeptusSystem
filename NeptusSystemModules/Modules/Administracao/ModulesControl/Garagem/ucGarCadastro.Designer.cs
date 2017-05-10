namespace NeptusSystemModules.Modules.Administracao.ModulesControl.Garagem
{
    partial class ucGarCadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGarCadastro));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIni = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFim = new MetroFramework.Controls.MetroTextBox();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.grdGaragem = new MetroFramework.Controls.MetroGrid();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdent = new MetroFramework.Controls.MetroLabel();
            this.lblcharIdent = new MetroFramework.Controls.MetroLabel();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chkBox = new MetroFramework.Controls.MetroCheckBox();
            this.clBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNrApart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdGaragem)).BeginInit();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Nº Inicial";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtIni
            // 
            // 
            // 
            // 
            this.txtIni.CustomButton.Image = null;
            this.txtIni.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtIni.CustomButton.Name = "";
            this.txtIni.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIni.CustomButton.TabIndex = 1;
            this.txtIni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIni.CustomButton.UseSelectable = true;
            this.txtIni.CustomButton.Visible = false;
            this.txtIni.Lines = new string[0];
            this.txtIni.Location = new System.Drawing.Point(19, 84);
            this.txtIni.MaxLength = 32767;
            this.txtIni.Name = "txtIni";
            this.txtIni.PasswordChar = '\0';
            this.txtIni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIni.SelectedText = "";
            this.txtIni.SelectionLength = 0;
            this.txtIni.SelectionStart = 0;
            this.txtIni.ShortcutsEnabled = true;
            this.txtIni.Size = new System.Drawing.Size(83, 23);
            this.txtIni.TabIndex = 3;
            this.txtIni.UseSelectable = true;
            this.txtIni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIni_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(108, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Nº Final";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // txtFim
            // 
            // 
            // 
            // 
            this.txtFim.CustomButton.Image = null;
            this.txtFim.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtFim.CustomButton.Name = "";
            this.txtFim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFim.CustomButton.TabIndex = 1;
            this.txtFim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFim.CustomButton.UseSelectable = true;
            this.txtFim.CustomButton.Visible = false;
            this.txtFim.Lines = new string[0];
            this.txtFim.Location = new System.Drawing.Point(108, 84);
            this.txtFim.MaxLength = 32767;
            this.txtFim.Name = "txtFim";
            this.txtFim.PasswordChar = '\0';
            this.txtFim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFim.SelectedText = "";
            this.txtFim.SelectionLength = 0;
            this.txtFim.SelectionStart = 0;
            this.txtFim.ShortcutsEnabled = true;
            this.txtFim.Size = new System.Drawing.Size(83, 23);
            this.txtFim.TabIndex = 5;
            this.txtFim.UseSelectable = true;
            this.txtFim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFim_KeyPress);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(330, 84);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grdGaragem
            // 
            this.grdGaragem.AllowUserToResizeRows = false;
            this.grdGaragem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdGaragem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdGaragem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdGaragem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGaragem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdGaragem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGaragem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBloco,
            this.clNrApart,
            this.clBox});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdGaragem.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdGaragem.EnableHeadersVisualStyles = false;
            this.grdGaragem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdGaragem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdGaragem.Location = new System.Drawing.Point(20, 122);
            this.grdGaragem.Name = "grdGaragem";
            this.grdGaragem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGaragem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdGaragem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdGaragem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGaragem.Size = new System.Drawing.Size(385, 256);
            this.grdGaragem.TabIndex = 8;
            // 
            // pnlLoading
            // 
            this.pnlLoading.Controls.Add(this.label1);
            this.pnlLoading.Controls.Add(this.pictureBox1);
            this.pnlLoading.Location = new System.Drawing.Point(121, 185);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(200, 133);
            this.pnlLoading.TabIndex = 12;
            this.pnlLoading.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Carregando Aguarde...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeptusSystemModules.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(68, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblIdent
            // 
            this.lblIdent.AutoSize = true;
            this.lblIdent.Location = new System.Drawing.Point(20, 21);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(82, 19);
            this.lblIdent.TabIndex = 13;
            this.lblIdent.Text = "Identificador";
            this.lblIdent.UseCustomBackColor = true;
            // 
            // lblcharIdent
            // 
            this.lblcharIdent.AutoSize = true;
            this.lblcharIdent.Location = new System.Drawing.Point(20, 40);
            this.lblcharIdent.Name = "lblcharIdent";
            this.lblcharIdent.Size = new System.Drawing.Size(18, 19);
            this.lblcharIdent.TabIndex = 14;
            this.lblcharIdent.Text = "G";
            this.lblcharIdent.UseCustomBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.BorderRadius = 0;
            this.btnSalvar.ButtonText = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Iconimage")));
            this.btnSalvar.Iconimage_right = null;
            this.btnSalvar.Iconimage_right_Selected = null;
            this.btnSalvar.Iconimage_Selected = null;
            this.btnSalvar.IconMarginLeft = 0;
            this.btnSalvar.IconMarginRight = 0;
            this.btnSalvar.IconRightVisible = true;
            this.btnSalvar.IconRightZoom = 0D;
            this.btnSalvar.IconVisible = true;
            this.btnSalvar.IconZoom = 90D;
            this.btnSalvar.IsTab = false;
            this.btnSalvar.Location = new System.Drawing.Point(310, 395);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalvar.selected = false;
            this.btnSalvar.Size = new System.Drawing.Size(95, 32);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Textcolor = System.Drawing.Color.White;
            this.btnSalvar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(197, 92);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(42, 15);
            this.chkBox.TabIndex = 15;
            this.chkBox.Text = "Box";
            this.chkBox.UseSelectable = true;
            // 
            // clBloco
            // 
            this.clBloco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clBloco.DividerWidth = 2;
            this.clBloco.FillWeight = 147F;
            this.clBloco.HeaderText = "Identificador";
            this.clBloco.Name = "clBloco";
            // 
            // clNrApart
            // 
            this.clNrApart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNrApart.DividerWidth = 2;
            this.clNrApart.FillWeight = 147F;
            this.clNrApart.HeaderText = "Garagem Nº";
            this.clNrApart.Name = "clNrApart";
            // 
            // clBox
            // 
            this.clBox.HeaderText = "Box";
            this.clBox.Name = "clBox";
            // 
            // ucGarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.lblcharIdent);
            this.Controls.Add(this.lblIdent);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grdGaragem);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtIni);
            this.Name = "ucGarCadastro";
            this.Size = new System.Drawing.Size(424, 435);
            ((System.ComponentModel.ISupportInitialize)(this.grdGaragem)).EndInit();
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIni;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFim;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private MetroFramework.Controls.MetroGrid grdGaragem;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel lblIdent;
        private MetroFramework.Controls.MetroLabel lblcharIdent;
        private MetroFramework.Controls.MetroCheckBox chkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNrApart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBox;
    }
}
