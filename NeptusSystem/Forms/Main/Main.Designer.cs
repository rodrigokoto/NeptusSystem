namespace NeptusSystem.Forms.Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.txtPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.picFind = new System.Windows.Forms.PictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mcmUser = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer = new NeptusSystem.Util.NeptusControls.ShadowPanel();
            this.ucHome1 = new NeptusSystem.Forms.Main.UcHome();
            this.shadowPanel1 = new NeptusSystem.Util.NeptusControls.ShadowPanel();
            this.pnlModulo = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModulos = new System.Windows.Forms.Label();
            this.pnlPrincipalMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConfig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRelatorios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHeadPrincipal = new System.Windows.Forms.Panel();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFind)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.mcmUser.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.shadowPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPrincipalMenu.SuspendLayout();
            this.pnlHeadPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.pnlHeader.Controls.Add(this.pnlSearch);
            this.pnlHeader.Controls.Add(this.pictureBox4);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1299, 45);
            this.pnlHeader.TabIndex = 2;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.pnlPesquisar);
            this.pnlSearch.Controls.Add(this.pnlUser);
            this.pnlSearch.Controls.Add(this.btnClose);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSearch.Location = new System.Drawing.Point(608, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(691, 45);
            this.pnlSearch.TabIndex = 6;
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Controls.Add(this.txtPesquisar);
            this.pnlPesquisar.Controls.Add(this.picFind);
            this.pnlPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPesquisar.Location = new System.Drawing.Point(0, 0);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(384, 45);
            this.pnlPesquisar.TabIndex = 7;
            // 
            // txtPesquisar
            // 
            // 
            // 
            // 
            this.txtPesquisar.CustomButton.Image = null;
            this.txtPesquisar.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.txtPesquisar.CustomButton.Name = "";
            this.txtPesquisar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisar.CustomButton.TabIndex = 1;
            this.txtPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisar.CustomButton.UseSelectable = true;
            this.txtPesquisar.CustomButton.Visible = false;
            this.txtPesquisar.Lines = new string[0];
            this.txtPesquisar.Location = new System.Drawing.Point(39, 12);
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.PromptText = "Pesquisar";
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.ShortcutsEnabled = true;
            this.txtPesquisar.Size = new System.Drawing.Size(297, 23);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.UseSelectable = true;
            this.txtPesquisar.WaterMark = "Pesquisar";
            this.txtPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // picFind
            // 
            this.picFind.Image = global::NeptusSystem.Properties.Resources.search;
            this.picFind.Location = new System.Drawing.Point(17, 18);
            this.picFind.Name = "picFind";
            this.picFind.Size = new System.Drawing.Size(16, 16);
            this.picFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFind.TabIndex = 6;
            this.picFind.TabStop = false;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Controls.Add(this.picUser);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUser.Location = new System.Drawing.Point(384, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(255, 45);
            this.pnlUser.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(52, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 16);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "label2";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // picUser
            // 
            this.picUser.Image = global::NeptusSystem.Properties.Resources.user_blue;
            this.picUser.Location = new System.Drawing.Point(17, 12);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(29, 26);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::NeptusSystem.Properties.Resources.close_white;
            this.btnClose.Location = new System.Drawing.Point(639, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 45);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::NeptusSystem.Properties.Resources.menu_alt;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashboard Neptus";
            // 
            // mcmUser
            // 
            this.mcmUser.AllowDrop = true;
            this.mcmUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPassword});
            this.mcmUser.Name = "mcmUser";
            this.mcmUser.Size = new System.Drawing.Size(153, 48);
            // 
            // tsmPassword
            // 
            this.tsmPassword.Name = "tsmPassword";
            this.tsmPassword.Size = new System.Drawing.Size(152, 22);
            this.tsmPassword.Text = "Alterar Senha";
            this.tsmPassword.Click += new System.EventHandler(this.tsmPassword_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderColor = System.Drawing.Color.Empty;
            this.pnlContainer.Controls.Add(this.ucHome1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(244, 45);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.PanelColor = System.Drawing.Color.White;
            this.pnlContainer.Size = new System.Drawing.Size(1055, 776);
            this.pnlContainer.TabIndex = 6;
            // 
            // ucHome1
            // 
            this.ucHome1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucHome1.BackgroundImage")));
            this.ucHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1055, 776);
            this.ucHome1.TabIndex = 0;
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BackColor = System.Drawing.Color.White;
            this.shadowPanel1.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Controls.Add(this.pnlModulo);
            this.shadowPanel1.Controls.Add(this.panel2);
            this.shadowPanel1.Controls.Add(this.pnlPrincipalMenu);
            this.shadowPanel1.Controls.Add(this.pnlHeadPrincipal);
            this.shadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.shadowPanel1.Location = new System.Drawing.Point(0, 45);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Size = new System.Drawing.Size(244, 776);
            this.shadowPanel1.TabIndex = 5;
            // 
            // pnlModulo
            // 
            this.pnlModulo.BackColor = System.Drawing.Color.Transparent;
            this.pnlModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModulo.Location = new System.Drawing.Point(0, 286);
            this.pnlModulo.Name = "pnlModulo";
            this.pnlModulo.Size = new System.Drawing.Size(244, 490);
            this.pnlModulo.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.lblModulos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 35);
            this.panel2.TabIndex = 5;
            // 
            // lblModulos
            // 
            this.lblModulos.AutoSize = true;
            this.lblModulos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblModulos.ForeColor = System.Drawing.Color.White;
            this.lblModulos.Location = new System.Drawing.Point(12, 11);
            this.lblModulos.Name = "lblModulos";
            this.lblModulos.Size = new System.Drawing.Size(75, 21);
            this.lblModulos.TabIndex = 0;
            this.lblModulos.Text = "Modulos";
            // 
            // pnlPrincipalMenu
            // 
            this.pnlPrincipalMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipalMenu.Controls.Add(this.btnHelp);
            this.pnlPrincipalMenu.Controls.Add(this.btnInfo);
            this.pnlPrincipalMenu.Controls.Add(this.btnConfig);
            this.pnlPrincipalMenu.Controls.Add(this.btnRelatorios);
            this.pnlPrincipalMenu.Controls.Add(this.btnHome);
            this.pnlPrincipalMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipalMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlPrincipalMenu.Name = "pnlPrincipalMenu";
            this.pnlPrincipalMenu.Size = new System.Drawing.Size(244, 216);
            this.pnlPrincipalMenu.TabIndex = 4;
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.Gray;
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.ButtonText = "   Ajuda";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.DisabledColor = System.Drawing.Color.DimGray;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHelp.Iconimage = global::NeptusSystem.Properties.Resources.question;
            this.btnHelp.Iconimage_right = null;
            this.btnHelp.Iconimage_right_Selected = null;
            this.btnHelp.Iconimage_Selected = null;
            this.btnHelp.IconMarginLeft = 0;
            this.btnHelp.IconMarginRight = 0;
            this.btnHelp.IconRightVisible = true;
            this.btnHelp.IconRightZoom = 0D;
            this.btnHelp.IconVisible = true;
            this.btnHelp.IconZoom = 30D;
            this.btnHelp.IsTab = false;
            this.btnHelp.Location = new System.Drawing.Point(0, 168);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHelp.OnHovercolor = System.Drawing.Color.Gray;
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.selected = false;
            this.btnHelp.Size = new System.Drawing.Size(244, 42);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "   Ajuda";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnInfo
            // 
            this.btnInfo.Activecolor = System.Drawing.Color.Gray;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.BorderRadius = 0;
            this.btnInfo.ButtonText = "   Sobre";
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.DisabledColor = System.Drawing.Color.DimGray;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInfo.Iconimage = global::NeptusSystem.Properties.Resources.info;
            this.btnInfo.Iconimage_right = null;
            this.btnInfo.Iconimage_right_Selected = null;
            this.btnInfo.Iconimage_Selected = null;
            this.btnInfo.IconMarginLeft = 0;
            this.btnInfo.IconMarginRight = 0;
            this.btnInfo.IconRightVisible = true;
            this.btnInfo.IconRightZoom = 0D;
            this.btnInfo.IconVisible = true;
            this.btnInfo.IconZoom = 30D;
            this.btnInfo.IsTab = false;
            this.btnInfo.Location = new System.Drawing.Point(0, 126);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInfo.OnHovercolor = System.Drawing.Color.Gray;
            this.btnInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInfo.selected = false;
            this.btnInfo.Size = new System.Drawing.Size(244, 42);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "   Sobre";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInfo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Activecolor = System.Drawing.Color.Gray;
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.BorderRadius = 0;
            this.btnConfig.ButtonText = "   Configuração";
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.DisabledColor = System.Drawing.Color.DimGray;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfig.Iconimage = global::NeptusSystem.Properties.Resources.setting_24px;
            this.btnConfig.Iconimage_right = null;
            this.btnConfig.Iconimage_right_Selected = null;
            this.btnConfig.Iconimage_Selected = null;
            this.btnConfig.IconMarginLeft = 0;
            this.btnConfig.IconMarginRight = 0;
            this.btnConfig.IconRightVisible = true;
            this.btnConfig.IconRightZoom = 0D;
            this.btnConfig.IconVisible = true;
            this.btnConfig.IconZoom = 30D;
            this.btnConfig.IsTab = false;
            this.btnConfig.Location = new System.Drawing.Point(0, 84);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConfig.OnHovercolor = System.Drawing.Color.Gray;
            this.btnConfig.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfig.selected = false;
            this.btnConfig.Size = new System.Drawing.Size(244, 42);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "   Configuração";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Activecolor = System.Drawing.Color.Gray;
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorios.BorderRadius = 0;
            this.btnRelatorios.ButtonText = "   Relatórios";
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.DisabledColor = System.Drawing.Color.DimGray;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Iconimage = global::NeptusSystem.Properties.Resources.bars_chart;
            this.btnRelatorios.Iconimage_right = null;
            this.btnRelatorios.Iconimage_right_Selected = null;
            this.btnRelatorios.Iconimage_Selected = null;
            this.btnRelatorios.IconMarginLeft = 0;
            this.btnRelatorios.IconMarginRight = 0;
            this.btnRelatorios.IconRightVisible = true;
            this.btnRelatorios.IconRightZoom = 0D;
            this.btnRelatorios.IconVisible = true;
            this.btnRelatorios.IconZoom = 30D;
            this.btnRelatorios.IsTab = false;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 42);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRelatorios.OnHovercolor = System.Drawing.Color.Gray;
            this.btnRelatorios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRelatorios.selected = false;
            this.btnRelatorios.Size = new System.Drawing.Size(244, 42);
            this.btnRelatorios.TabIndex = 1;
            this.btnRelatorios.Text = "   Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRelatorios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.DimGray;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "    Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.DimGray;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 30D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.Gray;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(244, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlHeadPrincipal
            // 
            this.pnlHeadPrincipal.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeadPrincipal.Controls.Add(this.lblPrincipal);
            this.pnlHeadPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlHeadPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadPrincipal.Name = "pnlHeadPrincipal";
            this.pnlHeadPrincipal.Size = new System.Drawing.Size(244, 35);
            this.pnlHeadPrincipal.TabIndex = 2;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblPrincipal.Location = new System.Drawing.Point(12, 11);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(75, 21);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1299, 821);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.shadowPanel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Neptus System";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFind)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.mcmUser.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.shadowPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPrincipalMenu.ResumeLayout(false);
            this.pnlHeadPrincipal.ResumeLayout(false);
            this.pnlHeadPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Util.NeptusControls.ShadowPanel shadowPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnlModulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblModulos;
        private System.Windows.Forms.Panel pnlPrincipalMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
        private Bunifu.Framework.UI.BunifuFlatButton btnInfo;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfig;
        private Bunifu.Framework.UI.BunifuFlatButton btnRelatorios;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.Panel pnlHeadPrincipal;
        private System.Windows.Forms.Label lblPrincipal;
        private Util.NeptusControls.ShadowPanel pnlContainer;
        private UcHome ucHome1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlPesquisar;
        private MetroFramework.Controls.MetroTextBox txtPesquisar;
        private System.Windows.Forms.PictureBox picFind;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox picUser;
        private MetroFramework.Controls.MetroContextMenu mcmUser;
        private System.Windows.Forms.ToolStripMenuItem tsmPassword;
    }
}