
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.AstrogatorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AffiliationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StarshipsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlashMessages = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabbedForms = new System.Windows.Forms.TabControl();
            this.TabContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.TabContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AstrogatorMenuItem,
            this.CatalogMenuItem,
            this.ParamMenuItem,
            this.HelpMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuBar.Size = new System.Drawing.Size(944, 31);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // AstrogatorMenuItem
            // 
            this.AstrogatorMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AstrogatorMenuItem.Name = "AstrogatorMenuItem";
            this.AstrogatorMenuItem.Size = new System.Drawing.Size(117, 25);
            this.AstrogatorMenuItem.Tag = "AstrogatorForm";
            this.AstrogatorMenuItem.Text = "Astrogateur";
            this.AstrogatorMenuItem.Click += new System.EventHandler(this.AstrogatorMenuItem_Click);
            // 
            // CatalogMenuItem
            // 
            this.CatalogMenuItem.Name = "CatalogMenuItem";
            this.CatalogMenuItem.Size = new System.Drawing.Size(108, 25);
            this.CatalogMenuItem.Tag = "StarCatalogForm";
            this.CatalogMenuItem.Text = "Catalogue";
            this.CatalogMenuItem.Click += new System.EventHandler(this.CatalogMenuItem_Click);
            // 
            // ParamMenuItem
            // 
            this.ParamMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AffiliationsMenuItem,
            this.toolStripSeparator1,
            this.StarshipsMenuItem});
            this.ParamMenuItem.Name = "ParamMenuItem";
            this.ParamMenuItem.Size = new System.Drawing.Size(111, 25);
            this.ParamMenuItem.Text = "Paramètres";
            // 
            // AffiliationsMenuItem
            // 
            this.AffiliationsMenuItem.Name = "AffiliationsMenuItem";
            this.AffiliationsMenuItem.Size = new System.Drawing.Size(233, 26);
            this.AffiliationsMenuItem.Tag = "AffiliationsForm";
            this.AffiliationsMenuItem.Text = "Secteurs, Affiliations";
            this.AffiliationsMenuItem.Click += new System.EventHandler(this.AffiliationsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // StarshipsMenuItem
            // 
            this.StarshipsMenuItem.Name = "StarshipsMenuItem";
            this.StarshipsMenuItem.Size = new System.Drawing.Size(233, 26);
            this.StarshipsMenuItem.Tag = "StarshipsForm";
            this.StarshipsMenuItem.Text = "Vaisseaux";
            this.StarshipsMenuItem.Click += new System.EventHandler(this.StarshipsMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(31, 25);
            this.HelpMenuItem.Text = "?";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(150, 26);
            this.AboutMenuItem.Text = "A propos";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // FlashMessages
            // 
            this.FlashMessages.Icon = ((System.Drawing.Icon)(resources.GetObject("FlashMessages.Icon")));
            this.FlashMessages.Visible = true;
            // 
            // TabbedForms
            // 
            this.TabbedForms.ContextMenuStrip = this.TabContextMenuStrip;
            this.TabbedForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabbedForms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabbedForms.Location = new System.Drawing.Point(0, 31);
            this.TabbedForms.Margin = new System.Windows.Forms.Padding(4);
            this.TabbedForms.Multiline = true;
            this.TabbedForms.Name = "TabbedForms";
            this.TabbedForms.SelectedIndex = 0;
            this.TabbedForms.Size = new System.Drawing.Size(944, 38);
            this.TabbedForms.TabIndex = 2;
            this.TabbedForms.Visible = false;
            this.TabbedForms.SelectedIndexChanged += new System.EventHandler(this.TabbedForms_SelectedIndexChanged);
            // 
            // TabContextMenuStrip
            // 
            this.TabContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseContextMenuItem});
            this.TabContextMenuStrip.Name = "TabContextMenuStrip";
            this.TabContextMenuStrip.Size = new System.Drawing.Size(112, 26);
            // 
            // CloseContextMenuItem
            // 
            this.CloseContextMenuItem.Name = "CloseContextMenuItem";
            this.CloseContextMenuItem.Size = new System.Drawing.Size(111, 22);
            this.CloseContextMenuItem.Text = "Fermer";
            this.CloseContextMenuItem.Click += new System.EventHandler(this.CloseContextMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.TabbedForms);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astrogator Suite";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.TabContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem AstrogatorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CatalogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AffiliationsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem StarshipsMenuItem;
        private System.Windows.Forms.NotifyIcon FlashMessages;
        private System.Windows.Forms.TabControl TabbedForms;
        private System.Windows.Forms.ContextMenuStrip TabContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    }
}