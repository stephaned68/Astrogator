
namespace Astrogator
{
    partial class AffiliationsForm
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
            this.SectorLabel = new System.Windows.Forms.Label();
            this.SectorCombo = new System.Windows.Forms.ComboBox();
            this.Affiliations = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SectorLabel
            // 
            this.SectorLabel.AutoSize = true;
            this.SectorLabel.Location = new System.Drawing.Point(8, 9);
            this.SectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SectorLabel.Name = "SectorLabel";
            this.SectorLabel.Size = new System.Drawing.Size(73, 20);
            this.SectorLabel.TabIndex = 0;
            this.SectorLabel.Text = "Secteur :";
            // 
            // SectorCombo
            // 
            this.SectorCombo.FormattingEnabled = true;
            this.SectorCombo.Location = new System.Drawing.Point(94, 6);
            this.SectorCombo.Margin = new System.Windows.Forms.Padding(4);
            this.SectorCombo.Name = "SectorCombo";
            this.SectorCombo.Size = new System.Drawing.Size(206, 28);
            this.SectorCombo.TabIndex = 1;
            this.SectorCombo.SelectedIndexChanged += new System.EventHandler(this.SectorCombo_SelectedIndexChanged);
            this.SectorCombo.Leave += new System.EventHandler(this.SectorCombo_Leave);
            // 
            // Affiliations
            // 
            this.Affiliations.Location = new System.Drawing.Point(8, 49);
            this.Affiliations.Margin = new System.Windows.Forms.Padding(4);
            this.Affiliations.Multiline = true;
            this.Affiliations.Name = "Affiliations";
            this.Affiliations.Size = new System.Drawing.Size(292, 233);
            this.Affiliations.TabIndex = 2;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(100, 291);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(96, 27);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Appliquer";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(204, 291);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(96, 27);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Fermer";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AffiliationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 324);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.Affiliations);
            this.Controls.Add(this.SectorCombo);
            this.Controls.Add(this.SectorLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AffiliationsForm";
            this.ShowIcon = false;
            this.Text = "Affiliations";
            this.Load += new System.EventHandler(this.AffiliationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SectorLabel;
        private System.Windows.Forms.ComboBox SectorCombo;
        private System.Windows.Forms.TextBox Affiliations;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CloseButton;
    }
}