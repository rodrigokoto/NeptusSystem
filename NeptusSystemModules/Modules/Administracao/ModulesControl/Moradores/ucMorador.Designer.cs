namespace NeptusSystemModules.Modules.Administracao.ModulesControl
{
    partial class ucMorador
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMorador));
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtDoc = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblDoc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblRG = new MetroFramework.Controls.MetroLabel();
            this.txtRG = new MetroFramework.Controls.MetroTextBox();
            this.lblListProp = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgrMorador = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnInserir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbxApartamento = new System.Windows.Forms.ComboBox();
            this.lblApartamento = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDDD2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDDD1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMorador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(45, 63);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(350, 23);
            this.txtNome.TabIndex = 0;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDoc
            // 
            // 
            // 
            // 
            this.txtDoc.CustomButton.Image = null;
            this.txtDoc.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtDoc.CustomButton.Name = "";
            this.txtDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDoc.CustomButton.TabIndex = 1;
            this.txtDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDoc.CustomButton.UseSelectable = true;
            this.txtDoc.CustomButton.Visible = false;
            this.txtDoc.Lines = new string[0];
            this.txtDoc.Location = new System.Drawing.Point(46, 108);
            this.txtDoc.MaxLength = 14;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.PasswordChar = '\0';
            this.txtDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDoc.SelectedText = "";
            this.txtDoc.SelectionLength = 0;
            this.txtDoc.SelectionStart = 0;
            this.txtDoc.ShortcutsEnabled = true;
            this.txtDoc.Size = new System.Drawing.Size(232, 23);
            this.txtDoc.TabIndex = 2;
            this.txtDoc.UseSelectable = true;
            this.txtDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoc_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 19);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nome";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(45, 86);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(33, 19);
            this.lblDoc.TabIndex = 7;
            this.lblDoc.Text = "CPF";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(45, 134);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Email";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(449, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(45, 158);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(471, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(284, 86);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 19);
            this.lblRG.TabIndex = 27;
            this.lblRG.Text = "RG";
            // 
            // txtRG
            // 
            // 
            // 
            // 
            this.txtRG.CustomButton.Image = null;
            this.txtRG.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtRG.CustomButton.Name = "";
            this.txtRG.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRG.CustomButton.TabIndex = 1;
            this.txtRG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRG.CustomButton.UseSelectable = true;
            this.txtRG.CustomButton.Visible = false;
            this.txtRG.Lines = new string[0];
            this.txtRG.Location = new System.Drawing.Point(284, 108);
            this.txtRG.MaxLength = 14;
            this.txtRG.Name = "txtRG";
            this.txtRG.PasswordChar = '\0';
            this.txtRG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRG.SelectedText = "";
            this.txtRG.SelectionLength = 0;
            this.txtRG.SelectionStart = 0;
            this.txtRG.ShortcutsEnabled = true;
            this.txtRG.Size = new System.Drawing.Size(232, 23);
            this.txtRG.TabIndex = 3;
            this.txtRG.UseSelectable = true;
            this.txtRG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // lblListProp
            // 
            this.lblListProp.AutoSize = true;
            this.lblListProp.Location = new System.Drawing.Point(542, 41);
            this.lblListProp.Name = "lblListProp";
            this.lblListProp.Size = new System.Drawing.Size(133, 19);
            this.lblListProp.TabIndex = 46;
            this.lblListProp.Text = "Lista de Propriétarios";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgrMorador
            // 
            this.dgrMorador.AllowUserToAddRows = false;
            this.dgrMorador.AllowUserToDeleteRows = false;
            this.dgrMorador.AllowUserToOrderColumns = true;
            this.dgrMorador.AllowUserToResizeColumns = false;
            this.dgrMorador.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrMorador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrMorador.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgrMorador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrMorador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrMorador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrMorador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMorador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clName});
            this.dgrMorador.DoubleBuffered = true;
            this.dgrMorador.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrMorador.EnableHeadersVisualStyles = false;
            this.dgrMorador.GridColor = System.Drawing.Color.Silver;
            this.dgrMorador.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.dgrMorador.HeaderForeColor = System.Drawing.Color.Black;
            this.dgrMorador.Location = new System.Drawing.Point(542, 65);
            this.dgrMorador.MultiSelect = false;
            this.dgrMorador.Name = "dgrMorador";
            this.dgrMorador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrMorador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrMorador.Size = new System.Drawing.Size(240, 281);
            this.dgrMorador.TabIndex = 10;
            this.dgrMorador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMorador_CellClick);
            // 
            // clId
            // 
            this.clId.HeaderText = "ID";
            this.clId.Name = "clId";
            this.clId.Width = 50;
            // 
            // clName
            // 
            this.clName.HeaderText = "Nome";
            this.clName.Name = "clName";
            this.clName.Width = 190;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(542, 15);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Pesquisar";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Size = new System.Drawing.Size(207, 23);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Pesquisar";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnInserir
            // 
            this.btnInserir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.BorderRadius = 0;
            this.btnInserir.ButtonText = "Inserir";
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.DisabledColor = System.Drawing.Color.Gray;
            this.btnInserir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInserir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInserir.Iconimage")));
            this.btnInserir.Iconimage_right = null;
            this.btnInserir.Iconimage_right_Selected = null;
            this.btnInserir.Iconimage_Selected = null;
            this.btnInserir.IconMarginLeft = 0;
            this.btnInserir.IconMarginRight = 0;
            this.btnInserir.IconRightVisible = true;
            this.btnInserir.IconRightZoom = 0D;
            this.btnInserir.IconVisible = true;
            this.btnInserir.IconZoom = 90D;
            this.btnInserir.IsTab = false;
            this.btnInserir.Location = new System.Drawing.Point(674, 390);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInserir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInserir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInserir.selected = false;
            this.btnInserir.Size = new System.Drawing.Size(108, 36);
            this.btnInserir.TabIndex = 11;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Textcolor = System.Drawing.Color.White;
            this.btnInserir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Image = global::NeptusSystemModules.Properties.Resources.search;
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(757, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 23);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSearch.TabIndex = 54;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(54, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 0);
            this.lblID.TabIndex = 55;
            this.lblID.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.Red;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = global::NeptusSystemModules.Properties.Resources.negative_24px;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 50D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(560, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(108, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxApartamento
            // 
            this.cbxApartamento.FormattingEnabled = true;
            this.cbxApartamento.Location = new System.Drawing.Point(401, 65);
            this.cbxApartamento.Name = "cbxApartamento";
            this.cbxApartamento.Size = new System.Drawing.Size(115, 21);
            this.cbxApartamento.TabIndex = 1;
            this.cbxApartamento.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbxApartamento_Format);
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Location = new System.Drawing.Point(401, 41);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(87, 19);
            this.lblApartamento.TabIndex = 59;
            this.lblApartamento.Text = "Apartamento";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(98, 232);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 67;
            this.metroLabel4.Text = "Celular";
            // 
            // txtCel
            // 
            // 
            // 
            // 
            this.txtCel.CustomButton.Image = null;
            this.txtCel.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtCel.CustomButton.Name = "";
            this.txtCel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCel.CustomButton.TabIndex = 1;
            this.txtCel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCel.CustomButton.UseSelectable = true;
            this.txtCel.CustomButton.Visible = false;
            this.txtCel.Lines = new string[0];
            this.txtCel.Location = new System.Drawing.Point(98, 254);
            this.txtCel.MaxLength = 10;
            this.txtCel.Name = "txtCel";
            this.txtCel.PasswordChar = '\0';
            this.txtCel.PromptText = "xxxxx-xxxx";
            this.txtCel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCel.SelectedText = "";
            this.txtCel.SelectionLength = 0;
            this.txtCel.SelectionStart = 0;
            this.txtCel.ShortcutsEnabled = true;
            this.txtCel.Size = new System.Drawing.Size(139, 23);
            this.txtCel.TabIndex = 8;
            this.txtCel.UseSelectable = true;
            this.txtCel.WaterMark = "xxxxx-xxxx";
            this.txtCel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(45, 232);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 66;
            this.metroLabel5.Text = "DDD";
            // 
            // txtDDD2
            // 
            // 
            // 
            // 
            this.txtDDD2.CustomButton.Image = null;
            this.txtDDD2.CustomButton.Location = new System.Drawing.Point(24, 1);
            this.txtDDD2.CustomButton.Name = "";
            this.txtDDD2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDDD2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDDD2.CustomButton.TabIndex = 1;
            this.txtDDD2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDDD2.CustomButton.UseSelectable = true;
            this.txtDDD2.CustomButton.Visible = false;
            this.txtDDD2.Lines = new string[0];
            this.txtDDD2.Location = new System.Drawing.Point(46, 254);
            this.txtDDD2.MaxLength = 3;
            this.txtDDD2.Name = "txtDDD2";
            this.txtDDD2.PasswordChar = '\0';
            this.txtDDD2.PromptText = "0xx";
            this.txtDDD2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDDD2.SelectedText = "";
            this.txtDDD2.SelectionLength = 0;
            this.txtDDD2.SelectionStart = 0;
            this.txtDDD2.ShortcutsEnabled = true;
            this.txtDDD2.Size = new System.Drawing.Size(46, 23);
            this.txtDDD2.TabIndex = 7;
            this.txtDDD2.UseSelectable = true;
            this.txtDDD2.WaterMark = "0xx";
            this.txtDDD2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDDD2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(98, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 65;
            this.metroLabel3.Text = "Telefone";
            // 
            // txtTel
            // 
            // 
            // 
            // 
            this.txtTel.CustomButton.Image = null;
            this.txtTel.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtTel.CustomButton.Name = "";
            this.txtTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTel.CustomButton.TabIndex = 1;
            this.txtTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTel.CustomButton.UseSelectable = true;
            this.txtTel.CustomButton.Visible = false;
            this.txtTel.Lines = new string[0];
            this.txtTel.Location = new System.Drawing.Point(98, 206);
            this.txtTel.MaxLength = 9;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.PromptText = "xxxx-xxxx";
            this.txtTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel.SelectedText = "";
            this.txtTel.SelectionLength = 0;
            this.txtTel.SelectionStart = 0;
            this.txtTel.ShortcutsEnabled = true;
            this.txtTel.Size = new System.Drawing.Size(139, 23);
            this.txtTel.TabIndex = 6;
            this.txtTel.UseSelectable = true;
            this.txtTel.WaterMark = "xxxx-xxxx";
            this.txtTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 184);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 64;
            this.metroLabel1.Text = "DDD";
            // 
            // txtDDD1
            // 
            // 
            // 
            // 
            this.txtDDD1.CustomButton.Image = null;
            this.txtDDD1.CustomButton.Location = new System.Drawing.Point(24, 1);
            this.txtDDD1.CustomButton.Name = "";
            this.txtDDD1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDDD1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDDD1.CustomButton.TabIndex = 1;
            this.txtDDD1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDDD1.CustomButton.UseSelectable = true;
            this.txtDDD1.CustomButton.Visible = false;
            this.txtDDD1.Lines = new string[0];
            this.txtDDD1.Location = new System.Drawing.Point(46, 206);
            this.txtDDD1.MaxLength = 3;
            this.txtDDD1.Name = "txtDDD1";
            this.txtDDD1.PasswordChar = '\0';
            this.txtDDD1.PromptText = "0xx";
            this.txtDDD1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDDD1.SelectedText = "";
            this.txtDDD1.SelectionLength = 0;
            this.txtDDD1.SelectionStart = 0;
            this.txtDDD1.ShortcutsEnabled = true;
            this.txtDDD1.Size = new System.Drawing.Size(46, 23);
            this.txtDDD1.TabIndex = 5;
            this.txtDDD1.UseSelectable = true;
            this.txtDDD1.WaterMark = "0xx";
            this.txtDDD1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDDD1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ucMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtDDD2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDDD1);
            this.Controls.Add(this.lblApartamento);
            this.Controls.Add(this.cbxApartamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgrMorador);
            this.Controls.Add(this.lblListProp);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtNome);
            this.Name = "ucMorador";
            this.Size = new System.Drawing.Size(808, 443);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMorador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtDoc;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblDoc;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private Bunifu.Framework.UI.BunifuFlatButton btnInserir;
        private MetroFramework.Controls.MetroLabel lblRG;
        private MetroFramework.Controls.MetroTextBox txtRG;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel lblListProp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgrMorador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private MetroFramework.Controls.MetroLabel lblIdEnd;
        private MetroFramework.Controls.MetroLabel lblID;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private MetroFramework.Controls.MetroLabel lblApartamento;
        private System.Windows.Forms.ComboBox cbxApartamento;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDDD2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDDD1;
    }
}
