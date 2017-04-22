namespace NeptusSystemModules.Modules
{
    partial class ContainerModules
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
            this.pnlContainer = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.HorizontalScrollbar = true;
            this.pnlContainer.HorizontalScrollbarBarColor = true;
            this.pnlContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlContainer.HorizontalScrollbarSize = 10;
            this.pnlContainer.Location = new System.Drawing.Point(20, 60);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(255, 36);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.VerticalScrollbar = true;
            this.pnlContainer.VerticalScrollbarBarColor = true;
            this.pnlContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlContainer.VerticalScrollbarSize = 10;
            // 
            // ContainerModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 116);
            this.Controls.Add(this.pnlContainer);
            this.Name = "ContainerModules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "ContainerModules";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlContainer;
    }
}