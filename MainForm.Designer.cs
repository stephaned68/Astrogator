
namespace Astrogator
{
    partial class MainForm
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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.AstrogatorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SectorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AffiliationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ShipClassesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StarshipsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AstrogatorMenuItem,
            this.CatalogMenuItem,
            this.ParamMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(800, 25);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // AstrogatorMenuItem
            // 
            this.AstrogatorMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AstrogatorMenuItem.Name = "AstrogatorMenuItem";
            this.AstrogatorMenuItem.Size = new System.Drawing.Size(91, 21);
            this.AstrogatorMenuItem.Text = "Astrogateur";
            this.AstrogatorMenuItem.Click += new System.EventHandler(this.AstrogatorMenuItem_Click);
            // 
            // CatalogMenuItem
            // 
            this.CatalogMenuItem.Name = "CatalogMenuItem";
            this.CatalogMenuItem.Size = new System.Drawing.Size(84, 21);
            this.CatalogMenuItem.Text = "Catalogue";
            // 
            // ParamMenuItem
            // 
            this.ParamMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SectorsMenuItem,
            this.AffiliationsMenuItem,
            this.toolStripSeparator1,
            this.ShipClassesMenuItem,
            this.StarshipsMenuItem});
            this.ParamMenuItem.Name = "ParamMenuItem";
            this.ParamMenuItem.Size = new System.Drawing.Size(88, 21);
            this.ParamMenuItem.Text = "Paramètres";
            // 
            // SectorsMenuItem
            // 
            this.SectorsMenuItem.Name = "SectorsMenuItem";
            this.SectorsMenuItem.Size = new System.Drawing.Size(199, 22);
            this.SectorsMenuItem.Text = "Secteurs";
            // 
            // AffiliationsMenuItem
            // 
            this.AffiliationsMenuItem.Name = "AffiliationsMenuItem";
            this.AffiliationsMenuItem.Size = new System.Drawing.Size(199, 22);
            this.AffiliationsMenuItem.Text = "Affiliations";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // ShipClassesMenuItem
            // 
            this.ShipClassesMenuItem.Name = "ShipClassesMenuItem";
            this.ShipClassesMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ShipClassesMenuItem.Text = "Classes de vaisseaux";
            this.ShipClassesMenuItem.Click += new System.EventHandler(this.ShipClassesMenuItem_Click);
            // 
            // StarshipsMenuItem
            // 
            this.StarshipsMenuItem.Name = "StarshipsMenuItem";
            this.StarshipsMenuItem.Size = new System.Drawing.Size(199, 22);
            this.StarshipsMenuItem.Text = "Vaisseaux";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astrogator Suite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem AstrogatorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CatalogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SectorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AffiliationsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ShipClassesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StarshipsMenuItem;
    }
}