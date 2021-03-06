
namespace Astrogator
{
    partial class StarshipsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarshipsForm));
            this.StarshipList = new System.Windows.Forms.ListView();
            this.ShipColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.ClassColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.SpeedColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ShipSpeed = new System.Windows.Forms.NumericUpDown();
            this.ShipClassCombo = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ShipName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // StarshipList
            // 
            this.StarshipList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShipColumnHeader,
            this.ClassColumnHeader,
            this.SpeedColumnHeader});
            this.StarshipList.FullRowSelect = true;
            this.StarshipList.GridLines = true;
            this.StarshipList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StarshipList.HideSelection = false;
            this.StarshipList.Location = new System.Drawing.Point(4, 0);
            this.StarshipList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StarshipList.MultiSelect = false;
            this.StarshipList.Name = "StarshipList";
            this.StarshipList.Size = new System.Drawing.Size(456, 248);
            this.StarshipList.TabIndex = 0;
            this.StarshipList.UseCompatibleStateImageBehavior = false;
            this.StarshipList.View = System.Windows.Forms.View.Details;
            this.StarshipList.DoubleClick += new System.EventHandler(this.StarshipList_DoubleClick);
            // 
            // ShipColumnHeader
            // 
            this.ShipColumnHeader.Text = "Vaisseau";
            this.ShipColumnHeader.Width = 180;
            // 
            // ClassColumnHeader
            // 
            this.ClassColumnHeader.Text = "Classe";
            this.ClassColumnHeader.Width = 90;
            // 
            // SpeedColumnHeader
            // 
            this.SpeedColumnHeader.Text = "Vitesse TL";
            this.SpeedColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpeedColumnHeader.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.ShipSpeed);
            this.groupBox1.Controls.Add(this.ShipClassCombo);
            this.groupBox1.Controls.Add(this.OkButton);
            this.groupBox1.Controls.Add(this.SpeedLabel);
            this.groupBox1.Controls.Add(this.ClassLabel);
            this.groupBox1.Controls.Add(this.ShipName);
            this.groupBox1.Location = new System.Drawing.Point(4, 254);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(456, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaisseau :";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(364, 50);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(85, 23);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Annuler";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ShipSpeed
            // 
            this.ShipSpeed.Location = new System.Drawing.Point(211, 67);
            this.ShipSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShipSpeed.Name = "ShipSpeed";
            this.ShipSpeed.Size = new System.Drawing.Size(137, 23);
            this.ShipSpeed.TabIndex = 3;
            this.ShipSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ShipClassCombo
            // 
            this.ShipClassCombo.FormattingEnabled = true;
            this.ShipClassCombo.Location = new System.Drawing.Point(7, 66);
            this.ShipClassCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShipClassCombo.Name = "ShipClassCombo";
            this.ShipClassCombo.Size = new System.Drawing.Size(196, 25);
            this.ShipClassCombo.TabIndex = 2;
            this.ShipClassCombo.SelectedIndexChanged += new System.EventHandler(this.ShipClassCombo_SelectedIndexChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(364, 21);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(85, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(220, 46);
            this.SpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(108, 17);
            this.SpeedLabel.TabIndex = 2;
            this.SpeedLabel.Text = "Vitesse (EAL/h) :";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(7, 46);
            this.ClassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(57, 17);
            this.ClassLabel.TabIndex = 1;
            this.ClassLabel.Text = "Classe :";
            // 
            // ShipName
            // 
            this.ShipName.Location = new System.Drawing.Point(7, 21);
            this.ShipName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShipName.Name = "ShipName";
            this.ShipName.PlaceholderText = "Nom du vaisseau";
            this.ShipName.Size = new System.Drawing.Size(340, 23);
            this.ShipName.TabIndex = 0;
            // 
            // StarshipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StarshipList);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StarshipsForm";
            this.ShowIcon = false;
            this.Text = "Vaisseaux";
            this.Load += new System.EventHandler(this.StarshipsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StarshipList;
        private System.Windows.Forms.ColumnHeader ShipColumnHeader;
        private System.Windows.Forms.ColumnHeader ClassColumnHeader;
        private System.Windows.Forms.ColumnHeader SpeedColumnHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ShipClassCombo;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox ShipName;
        private System.Windows.Forms.NumericUpDown ShipSpeed;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ResetButton;
    }
}