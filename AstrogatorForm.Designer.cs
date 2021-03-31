
namespace Astrogator
{
    partial class AstrogatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DepSystemCombo = new System.Windows.Forms.ComboBox();
            this.depLongitudeLabel = new System.Windows.Forms.Label();
            this.DepLongitude = new System.Windows.Forms.TextBox();
            this.DepLatitude = new System.Windows.Forms.TextBox();
            this.depLatitudeLabel = new System.Windows.Forms.Label();
            this.DepHeight = new System.Windows.Forms.TextBox();
            this.depHeightLabel = new System.Windows.Forms.Label();
            this.departureGroup = new System.Windows.Forms.GroupBox();
            this.DepSectorCombo = new System.Windows.Forms.ComboBox();
            this.arrivalGroup = new System.Windows.Forms.GroupBox();
            this.ArrSectorCombo = new System.Windows.Forms.ComboBox();
            this.ArrSystemCombo = new System.Windows.Forms.ComboBox();
            this.arrHeightLabel = new System.Windows.Forms.Label();
            this.arrLongitudeLabel = new System.Windows.Forms.Label();
            this.ArrHeight = new System.Windows.Forms.TextBox();
            this.ArrLongitude = new System.Windows.Forms.TextBox();
            this.arrLatitudeLabel = new System.Windows.Forms.Label();
            this.ArrLatitude = new System.Windows.Forms.TextBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StarshipGroup = new System.Windows.Forms.GroupBox();
            this.StarshipSpeed = new System.Windows.Forms.NumericUpDown();
            this.StarshipSpeedLabel = new System.Windows.Forms.Label();
            this.StarshipCombo = new System.Windows.Forms.ComboBox();
            this.departureGroup.SuspendLayout();
            this.arrivalGroup.SuspendLayout();
            this.StarshipGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarshipSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // DepSystemCombo
            // 
            this.DepSystemCombo.FormattingEnabled = true;
            this.DepSystemCombo.Location = new System.Drawing.Point(6, 52);
            this.DepSystemCombo.Name = "DepSystemCombo";
            this.DepSystemCombo.Size = new System.Drawing.Size(210, 25);
            this.DepSystemCombo.TabIndex = 1;
            this.DepSystemCombo.SelectedIndexChanged += new System.EventHandler(this.DepartureCombo_SelectedIndexChanged);
            // 
            // depLongitudeLabel
            // 
            this.depLongitudeLabel.AutoSize = true;
            this.depLongitudeLabel.Location = new System.Drawing.Point(223, 31);
            this.depLongitudeLabel.Name = "depLongitudeLabel";
            this.depLongitudeLabel.Size = new System.Drawing.Size(74, 17);
            this.depLongitudeLabel.TabIndex = 2;
            this.depLongitudeLabel.Text = "Longitude :";
            // 
            // DepLongitude
            // 
            this.DepLongitude.Location = new System.Drawing.Point(223, 52);
            this.DepLongitude.Name = "DepLongitude";
            this.DepLongitude.Size = new System.Drawing.Size(100, 22);
            this.DepLongitude.TabIndex = 3;
            // 
            // DepLatitude
            // 
            this.DepLatitude.Location = new System.Drawing.Point(330, 52);
            this.DepLatitude.Name = "DepLatitude";
            this.DepLatitude.Size = new System.Drawing.Size(100, 22);
            this.DepLatitude.TabIndex = 4;
            // 
            // depLatitudeLabel
            // 
            this.depLatitudeLabel.AutoSize = true;
            this.depLatitudeLabel.Location = new System.Drawing.Point(330, 31);
            this.depLatitudeLabel.Name = "depLatitudeLabel";
            this.depLatitudeLabel.Size = new System.Drawing.Size(64, 17);
            this.depLatitudeLabel.TabIndex = 5;
            this.depLatitudeLabel.Text = "Latitude :";
            // 
            // DepHeight
            // 
            this.DepHeight.Location = new System.Drawing.Point(437, 52);
            this.DepHeight.Name = "DepHeight";
            this.DepHeight.Size = new System.Drawing.Size(100, 22);
            this.DepHeight.TabIndex = 6;
            // 
            // depHeightLabel
            // 
            this.depHeightLabel.AutoSize = true;
            this.depHeightLabel.Location = new System.Drawing.Point(437, 31);
            this.depHeightLabel.Name = "depHeightLabel";
            this.depHeightLabel.Size = new System.Drawing.Size(61, 17);
            this.depHeightLabel.TabIndex = 7;
            this.depHeightLabel.Text = "Hauteur :";
            // 
            // departureGroup
            // 
            this.departureGroup.Controls.Add(this.DepSectorCombo);
            this.departureGroup.Controls.Add(this.DepSystemCombo);
            this.departureGroup.Controls.Add(this.depHeightLabel);
            this.departureGroup.Controls.Add(this.depLongitudeLabel);
            this.departureGroup.Controls.Add(this.DepHeight);
            this.departureGroup.Controls.Add(this.DepLongitude);
            this.departureGroup.Controls.Add(this.depLatitudeLabel);
            this.departureGroup.Controls.Add(this.DepLatitude);
            this.departureGroup.Location = new System.Drawing.Point(1, 12);
            this.departureGroup.Name = "departureGroup";
            this.departureGroup.Size = new System.Drawing.Size(548, 88);
            this.departureGroup.TabIndex = 8;
            this.departureGroup.TabStop = false;
            this.departureGroup.Text = "Départ :";
            // 
            // DepSectorCombo
            // 
            this.DepSectorCombo.FormattingEnabled = true;
            this.DepSectorCombo.Location = new System.Drawing.Point(6, 21);
            this.DepSectorCombo.Name = "DepSectorCombo";
            this.DepSectorCombo.Size = new System.Drawing.Size(210, 25);
            this.DepSectorCombo.TabIndex = 8;
            this.DepSectorCombo.SelectedIndexChanged += new System.EventHandler(this.DepSectorCombo_SelectedIndexChanged);
            // 
            // arrivalGroup
            // 
            this.arrivalGroup.Controls.Add(this.ArrSectorCombo);
            this.arrivalGroup.Controls.Add(this.ArrSystemCombo);
            this.arrivalGroup.Controls.Add(this.arrHeightLabel);
            this.arrivalGroup.Controls.Add(this.arrLongitudeLabel);
            this.arrivalGroup.Controls.Add(this.ArrHeight);
            this.arrivalGroup.Controls.Add(this.ArrLongitude);
            this.arrivalGroup.Controls.Add(this.arrLatitudeLabel);
            this.arrivalGroup.Controls.Add(this.ArrLatitude);
            this.arrivalGroup.Location = new System.Drawing.Point(1, 106);
            this.arrivalGroup.Name = "arrivalGroup";
            this.arrivalGroup.Size = new System.Drawing.Size(548, 87);
            this.arrivalGroup.TabIndex = 9;
            this.arrivalGroup.TabStop = false;
            this.arrivalGroup.Text = "Arrivée";
            // 
            // ArrSectorCombo
            // 
            this.ArrSectorCombo.FormattingEnabled = true;
            this.ArrSectorCombo.Location = new System.Drawing.Point(6, 21);
            this.ArrSectorCombo.Name = "ArrSectorCombo";
            this.ArrSectorCombo.Size = new System.Drawing.Size(210, 25);
            this.ArrSectorCombo.TabIndex = 9;
            this.ArrSectorCombo.SelectedIndexChanged += new System.EventHandler(this.ArrSectorCombo_SelectedIndexChanged);
            // 
            // ArrSystemCombo
            // 
            this.ArrSystemCombo.FormattingEnabled = true;
            this.ArrSystemCombo.Location = new System.Drawing.Point(6, 52);
            this.ArrSystemCombo.Name = "ArrSystemCombo";
            this.ArrSystemCombo.Size = new System.Drawing.Size(210, 25);
            this.ArrSystemCombo.TabIndex = 1;
            this.ArrSystemCombo.SelectedIndexChanged += new System.EventHandler(this.ArrivalCombo_SelectedIndexChanged);
            // 
            // arrHeightLabel
            // 
            this.arrHeightLabel.AutoSize = true;
            this.arrHeightLabel.Location = new System.Drawing.Point(437, 31);
            this.arrHeightLabel.Name = "arrHeightLabel";
            this.arrHeightLabel.Size = new System.Drawing.Size(61, 17);
            this.arrHeightLabel.TabIndex = 7;
            this.arrHeightLabel.Text = "Hauteur :";
            // 
            // arrLongitudeLabel
            // 
            this.arrLongitudeLabel.AutoSize = true;
            this.arrLongitudeLabel.Location = new System.Drawing.Point(223, 31);
            this.arrLongitudeLabel.Name = "arrLongitudeLabel";
            this.arrLongitudeLabel.Size = new System.Drawing.Size(74, 17);
            this.arrLongitudeLabel.TabIndex = 2;
            this.arrLongitudeLabel.Text = "Longitude :";
            // 
            // ArrHeight
            // 
            this.ArrHeight.Location = new System.Drawing.Point(437, 52);
            this.ArrHeight.Name = "ArrHeight";
            this.ArrHeight.Size = new System.Drawing.Size(100, 22);
            this.ArrHeight.TabIndex = 6;
            // 
            // ArrLongitude
            // 
            this.ArrLongitude.Location = new System.Drawing.Point(223, 52);
            this.ArrLongitude.Name = "ArrLongitude";
            this.ArrLongitude.Size = new System.Drawing.Size(100, 22);
            this.ArrLongitude.TabIndex = 3;
            // 
            // arrLatitudeLabel
            // 
            this.arrLatitudeLabel.AutoSize = true;
            this.arrLatitudeLabel.Location = new System.Drawing.Point(330, 31);
            this.arrLatitudeLabel.Name = "arrLatitudeLabel";
            this.arrLatitudeLabel.Size = new System.Drawing.Size(64, 17);
            this.arrLatitudeLabel.TabIndex = 5;
            this.arrLatitudeLabel.Text = "Latitude :";
            // 
            // ArrLatitude
            // 
            this.ArrLatitude.Location = new System.Drawing.Point(330, 52);
            this.ArrLatitude.Name = "ArrLatitude";
            this.ArrLatitude.Size = new System.Drawing.Size(100, 22);
            this.ArrLatitude.TabIndex = 4;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DistanceLabel.Location = new System.Drawing.Point(123, 359);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(22, 28);
            this.DistanceLabel.TabIndex = 10;
            this.DistanceLabel.Text = "-";
            // 
            // CalculateButton
            // 
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Location = new System.Drawing.Point(9, 359);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(108, 28);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calcul";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // StarshipGroup
            // 
            this.StarshipGroup.Controls.Add(this.StarshipSpeed);
            this.StarshipGroup.Controls.Add(this.StarshipSpeedLabel);
            this.StarshipGroup.Controls.Add(this.StarshipCombo);
            this.StarshipGroup.Location = new System.Drawing.Point(1, 199);
            this.StarshipGroup.Name = "StarshipGroup";
            this.StarshipGroup.Size = new System.Drawing.Size(548, 99);
            this.StarshipGroup.TabIndex = 12;
            this.StarshipGroup.TabStop = false;
            this.StarshipGroup.Text = "Vaisseau";
            // 
            // StarshipSpeed
            // 
            this.StarshipSpeed.Location = new System.Drawing.Point(223, 24);
            this.StarshipSpeed.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.StarshipSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StarshipSpeed.Name = "StarshipSpeed";
            this.StarshipSpeed.Size = new System.Drawing.Size(58, 22);
            this.StarshipSpeed.TabIndex = 6;
            this.StarshipSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StarshipSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StarshipSpeedLabel
            // 
            this.StarshipSpeedLabel.AutoSize = true;
            this.StarshipSpeedLabel.Location = new System.Drawing.Point(284, 26);
            this.StarshipSpeedLabel.Name = "StarshipSpeedLabel";
            this.StarshipSpeedLabel.Size = new System.Drawing.Size(41, 17);
            this.StarshipSpeedLabel.TabIndex = 3;
            this.StarshipSpeedLabel.Text = "EAL/h";
            // 
            // StarshipCombo
            // 
            this.StarshipCombo.FormattingEnabled = true;
            this.StarshipCombo.Location = new System.Drawing.Point(6, 21);
            this.StarshipCombo.Name = "StarshipCombo";
            this.StarshipCombo.Size = new System.Drawing.Size(210, 25);
            this.StarshipCombo.TabIndex = 0;
            this.StarshipCombo.SelectedIndexChanged += new System.EventHandler(this.StarshipCombo_SelectedIndexChanged);
            // 
            // AstrogatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StarshipGroup);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.arrivalGroup);
            this.Controls.Add(this.departureGroup);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AstrogatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astrogator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.departureGroup.ResumeLayout(false);
            this.departureGroup.PerformLayout();
            this.arrivalGroup.ResumeLayout(false);
            this.arrivalGroup.PerformLayout();
            this.StarshipGroup.ResumeLayout(false);
            this.StarshipGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarshipSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DepSystemCombo;
        private System.Windows.Forms.Label depLongitudeLabel;
        private System.Windows.Forms.TextBox DepLongitude;
        private System.Windows.Forms.TextBox DepLatitude;
        private System.Windows.Forms.Label depLatitudeLabel;
        private System.Windows.Forms.TextBox DepHeight;
        private System.Windows.Forms.Label depHeightLabel;
        private System.Windows.Forms.GroupBox departureGroup;
        private System.Windows.Forms.GroupBox arrivalGroup;
        private System.Windows.Forms.ComboBox ArrSystemCombo;
        private System.Windows.Forms.Label arrHeightLabel;
        private System.Windows.Forms.Label arrLongitudeLabel;
        private System.Windows.Forms.TextBox ArrHeight;
        private System.Windows.Forms.TextBox ArrLongitude;
        private System.Windows.Forms.Label arrLatitudeLabel;
        private System.Windows.Forms.TextBox ArrLatitude;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox StarshipGroup;
        private System.Windows.Forms.Label StarshipSpeedLabel;
        private System.Windows.Forms.ComboBox StarshipCombo;
        private System.Windows.Forms.NumericUpDown StarshipSpeed;
        private System.Windows.Forms.ComboBox DepSectorCombo;
        private System.Windows.Forms.ComboBox ArrSectorCombo;
    }
}

