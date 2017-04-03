namespace NeptusSystem.Modules.ModulesForms
{
    partial class ModuleForms
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
            this.ucModulesForms = new MetroFramework.Controls.MetroUserControl();
            this.SuspendLayout();
            // 
            // ucModulesForms
            // 
            this.ucModulesForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucModulesForms.Location = new System.Drawing.Point(0, 0);
            this.ucModulesForms.Name = "ucModulesForms";
            this.ucModulesForms.Size = new System.Drawing.Size(470, 700);
            this.ucModulesForms.TabIndex = 0;
            this.ucModulesForms.UseSelectable = true;
            // 
            // ModuleForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 700);
            this.Controls.Add(this.ucModulesForms);
            this.Name = "ModuleForms";
            this.Text = "ModuleForms";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl ucModulesForms;
    }
}