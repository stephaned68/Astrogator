
namespace Astrogator
{
    partial class StarCatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarCatalogForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SectorsToolstripDropList = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SectorGrid = new System.Windows.Forms.DataGridView();
            this.SectorGridSystemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorGridLongitudeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorGridLatitudeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorGridHeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorGridAffiliationCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SectorGridTLCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SectorsToolstripDropList,
            this.toolStripSeparator,
            this.SaveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1007, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SectorsToolstripDropList
            // 
            this.SectorsToolstripDropList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SectorsToolstripDropList.Image = ((System.Drawing.Image)(resources.GetObject("SectorsToolstripDropList.Image")));
            this.SectorsToolstripDropList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SectorsToolstripDropList.Name = "SectorsToolstripDropList";
            this.SectorsToolstripDropList.Size = new System.Drawing.Size(84, 24);
            this.SectorsToolstripDropList.Text = "Secteurs";
            this.SectorsToolstripDropList.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SectorsToolstripDropList_DropDownItemClicked);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.SaveToolStripButton.Text = "&Sauvegarder";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // SectorGrid
            // 
            this.SectorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SectorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectorGridSystemNameCol,
            this.SectorGridLongitudeCol,
            this.SectorGridLatitudeCol,
            this.SectorGridHeightCol,
            this.SectorGridAffiliationCol,
            this.SectorGridTLCol});
            this.SectorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectorGrid.Location = new System.Drawing.Point(0, 27);
            this.SectorGrid.Margin = new System.Windows.Forms.Padding(4);
            this.SectorGrid.Name = "SectorGrid";
            this.SectorGrid.RowTemplate.Height = 25;
            this.SectorGrid.Size = new System.Drawing.Size(1007, 492);
            this.SectorGrid.TabIndex = 1;
            this.SectorGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.SectorGrid_DataError);
            // 
            // SectorGridSystemNameCol
            // 
            this.SectorGridSystemNameCol.HeaderText = "Système stellaire";
            this.SectorGridSystemNameCol.Name = "SectorGridSystemNameCol";
            this.SectorGridSystemNameCol.Width = 250;
            // 
            // SectorGridLongitudeCol
            // 
            this.SectorGridLongitudeCol.HeaderText = "Longitude";
            this.SectorGridLongitudeCol.Name = "SectorGridLongitudeCol";
            // 
            // SectorGridLatitudeCol
            // 
            this.SectorGridLatitudeCol.HeaderText = "Latitude";
            this.SectorGridLatitudeCol.Name = "SectorGridLatitudeCol";
            // 
            // SectorGridHeightCol
            // 
            this.SectorGridHeightCol.HeaderText = "Hauteur";
            this.SectorGridHeightCol.Name = "SectorGridHeightCol";
            this.SectorGridHeightCol.Width = 80;
            // 
            // SectorGridAffiliationCol
            // 
            this.SectorGridAffiliationCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SectorGridAffiliationCol.HeaderText = "Affiliation";
            this.SectorGridAffiliationCol.Name = "SectorGridAffiliationCol";
            this.SectorGridAffiliationCol.Width = 200;
            // 
            // SectorGridTLCol
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.SectorGridTLCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.SectorGridTLCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SectorGridTLCol.HeaderText = "NT";
            this.SectorGridTLCol.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SectorGridTLCol.Name = "SectorGridTLCol";
            this.SectorGridTLCol.Width = 60;
            // 
            // StarCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 519);
            this.Controls.Add(this.SectorGrid);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "StarCatalogForm";
            this.ShowIcon = false;
            this.Text = "Catalogue Stellaire";
            this.Load += new System.EventHandler(this.StarCatalogForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton SectorsToolstripDropList;
        private System.Windows.Forms.DataGridView SectorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorGridSystemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorGridLongitudeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorGridLatitudeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorGridHeightCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn SectorGridAffiliationCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn SectorGridTLCol;
    }
}