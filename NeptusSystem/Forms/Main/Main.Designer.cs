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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new NeptusSystem.Util.NeptusControls.ShadowPanel();
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
            this.ucHome1 = new NeptusSystem.Forms.Main.UcHome();
            this.pnlHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.pnlHeader.Controls.Add(this.panel3);
            this.pnlHeader.Controls.Add(this.pictureBox4);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1299, 45);
            this.pnlHeader.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(919, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 45);
            this.panel3.TabIndex = 6;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(26, 12);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(256, 28);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.Text = "Pesquisar";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::NeptusSystem.Properties.Resources.close_white;
            this.btnClose.Location = new System.Drawing.Point(328, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 45);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NeptusSystem.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(3, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
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
            // ucHome1
            // 
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1055, 776);
            this.ucHome1.TabIndex = 0;
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnClose;
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
    }
}