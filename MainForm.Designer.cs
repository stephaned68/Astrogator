
namespace Astrogator
{
    partial class MainForm
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
            this.DepartureCombo = new System.Windows.Forms.ComboBox();
            this.depLongitudeLabel = new System.Windows.Forms.Label();
            this.depLongitude = new System.Windows.Forms.TextBox();
            this.depLatitude = new System.Windows.Forms.TextBox();
            this.depLatitudeLabel = new System.Windows.Forms.Label();
            this.depHeight = new System.Windows.Forms.TextBox();
            this.depHeightLabel = new System.Windows.Forms.Label();
            this.departureGroup = new System.Windows.Forms.GroupBox();
            this.arrivalGroup = new System.Windows.Forms.GroupBox();
            this.ArrivalCombo = new System.Windows.Forms.ComboBox();
            this.arrHeightLabel = new System.Windows.Forms.Label();
            this.arrLongitudeLabel = new System.Windows.Forms.Label();
            this.arrHeight = new System.Windows.Forms.TextBox();
            this.arrLongitude = new System.Windows.Forms.TextBox();
            this.arrLatitudeLabel = new System.Windows.Forms.Label();
            this.arrLatitude = new System.Windows.Forms.TextBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StarshipGroup = new System.Windows.Forms.GroupBox();
            this.StarshipSpeedLabel = new System.Windows.Forms.Label();
            this.StarshipLabel = new System.Windows.Forms.Label();
            this.StarshipSpeed = new System.Windows.Forms.TextBox();
            this.StarshipCombo = new System.Windows.Forms.ComboBox();
            this.departureGroup.SuspendLayout();
            this.arrivalGroup.SuspendLayout();
            this.StarshipGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartureCombo
            // 
            this.DepartureCombo.FormattingEnabled = true;
            this.DepartureCombo.Location = new System.Drawing.Point(8, 21);
            this.DepartureCombo.Name = "DepartureCombo";
            this.DepartureCombo.Size = new System.Drawing.Size(207, 25);
            this.DepartureCombo.TabIndex = 1;
            this.DepartureCombo.SelectedIndexChanged += new System.EventHandler(this.DepartureCombo_SelectedIndexChanged);
            // 
            // depLongitudeLabel
            // 
            this.depLongitudeLabel.AutoSize = true;
            this.depLongitudeLabel.Location = new System.Drawing.Point(8, 49);
            this.depLongitudeLabel.Name = "depLongitudeLabel";
            this.depLongitudeLabel.Size = new System.Drawing.Size(74, 17);
            this.depLongitudeLabel.TabIndex = 2;
            this.depLongitudeLabel.Text = "Longitude :";
            // 
            // depLongitude
            // 
            this.depLongitude.Location = new System.Drawing.Point(8, 70);
            this.depLongitude.Name = "depLongitude";
            this.depLongitude.Size = new System.Drawing.Size(100, 22);
            this.depLongitude.TabIndex = 3;
            // 
            // depLatitude
            // 
            this.depLatitude.Location = new System.Drawing.Point(115, 70);
            this.depLatitude.Name = "depLatitude";
            this.depLatitude.Size = new System.Drawing.Size(100, 22);
            this.depLatitude.TabIndex = 4;
            // 
            // depLatitudeLabel
            // 
            this.depLatitudeLabel.AutoSize = true;
            this.depLatitudeLabel.Location = new System.Drawing.Point(115, 49);
            this.depLatitudeLabel.Name = "depLatitudeLabel";
            this.depLatitudeLabel.Size = new System.Drawing.Size(64, 17);
            this.depLatitudeLabel.TabIndex = 5;
            this.depLatitudeLabel.Text = "Latitude :";
            // 
            // depHeight
            // 
            this.depHeight.Location = new System.Drawing.Point(222, 70);
            this.depHeight.Name = "depHeight";
            this.depHeight.Size = new System.Drawing.Size(100, 22);
            this.depHeight.TabIndex = 6;
            // 
            // depHeightLabel
            // 
            this.depHeightLabel.AutoSize = true;
            this.depHeightLabel.Location = new System.Drawing.Point(222, 49);
            this.depHeightLabel.Name = "depHeightLabel";
            this.depHeightLabel.Size = new System.Drawing.Size(61, 17);
            this.depHeightLabel.TabIndex = 7;
            this.depHeightLabel.Text = "Hauteur :";
            // 
            // departureGroup
            // 
            this.departureGroup.Controls.Add(this.DepartureCombo);
            this.departureGroup.Controls.Add(this.depHeightLabel);
            this.departureGroup.Controls.Add(this.depLongitudeLabel);
            this.departureGroup.Controls.Add(this.depHeight);
            this.departureGroup.Controls.Add(this.depLongitude);
            this.departureGroup.Controls.Add(this.depLatitudeLabel);
            this.departureGroup.Controls.Add(this.depLatitude);
            this.departureGroup.Location = new System.Drawing.Point(1, 1);
            this.departureGroup.Name = "departureGroup";
            this.departureGroup.Size = new System.Drawing.Size(334, 109);
            this.departureGroup.TabIndex = 8;
            this.departureGroup.TabStop = false;
            this.departureGroup.Text = "Départ :";
            // 
            // arrivalGroup
            // 
            this.arrivalGroup.Controls.Add(this.ArrivalCombo);
            this.arrivalGroup.Controls.Add(this.arrHeightLabel);
            this.arrivalGroup.Controls.Add(this.arrLongitudeLabel);
            this.arrivalGroup.Controls.Add(this.arrHeight);
            this.arrivalGroup.Controls.Add(this.arrLongitude);
            this.arrivalGroup.Controls.Add(this.arrLatitudeLabel);
            this.arrivalGroup.Controls.Add(this.arrLatitude);
            this.arrivalGroup.Location = new System.Drawing.Point(1, 116);
            this.arrivalGroup.Name = "arrivalGroup";
            this.arrivalGroup.Size = new System.Drawing.Size(334, 109);
            this.arrivalGroup.TabIndex = 9;
            this.arrivalGroup.TabStop = false;
            this.arrivalGroup.Text = "Arrivée";
            // 
            // ArrivalCombo
            // 
            this.ArrivalCombo.FormattingEnabled = true;
            this.ArrivalCombo.Location = new System.Drawing.Point(8, 21);
            this.ArrivalCombo.Name = "ArrivalCombo";
            this.ArrivalCombo.Size = new System.Drawing.Size(207, 25);
            this.ArrivalCombo.TabIndex = 1;
            this.ArrivalCombo.SelectedIndexChanged += new System.EventHandler(this.ArrivalCombo_SelectedIndexChanged);
            // 
            // arrHeightLabel
            // 
            this.arrHeightLabel.AutoSize = true;
            this.arrHeightLabel.Location = new System.Drawing.Point(222, 49);
            this.arrHeightLabel.Name = "arrHeightLabel";
            this.arrHeightLabel.Size = new System.Drawing.Size(61, 17);
            this.arrHeightLabel.TabIndex = 7;
            this.arrHeightLabel.Text = "Hauteur :";
            // 
            // arrLongitudeLabel
            // 
            this.arrLongitudeLabel.AutoSize = true;
            this.arrLongitudeLabel.Location = new System.Drawing.Point(8, 49);
            this.arrLongitudeLabel.Name = "arrLongitudeLabel";
            this.arrLongitudeLabel.Size = new System.Drawing.Size(74, 17);
            this.arrLongitudeLabel.TabIndex = 2;
            this.arrLongitudeLabel.Text = "Longitude :";
            // 
            // arrHeight
            // 
            this.arrHeight.Location = new System.Drawing.Point(222, 70);
            this.arrHeight.Name = "arrHeight";
            this.arrHeight.Size = new System.Drawing.Size(100, 22);
            this.arrHeight.TabIndex = 6;
            // 
            // arrLongitude
            // 
            this.arrLongitude.Location = new System.Drawing.Point(8, 70);
            this.arrLongitude.Name = "arrLongitude";
            this.arrLongitude.Size = new System.Drawing.Size(100, 22);
            this.arrLongitude.TabIndex = 3;
            // 
            // arrLatitudeLabel
            // 
            this.arrLatitudeLabel.AutoSize = true;
            this.arrLatitudeLabel.Location = new System.Drawing.Point(115, 49);
            this.arrLatitudeLabel.Name = "arrLatitudeLabel";
            this.arrLatitudeLabel.Size = new System.Drawing.Size(64, 17);
            this.arrLatitudeLabel.TabIndex = 5;
            this.arrLatitudeLabel.Text = "Latitude :";
            // 
            // arrLatitude
            // 
            this.arrLatitude.Location = new System.Drawing.Point(115, 70);
            this.arrLatitude.Name = "arrLatitude";
            this.arrLatitude.Size = new System.Drawing.Size(100, 22);
            this.arrLatitude.TabIndex = 4;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DistanceLabel.Location = new System.Drawing.Point(123, 321);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(22, 28);
            this.DistanceLabel.TabIndex = 10;
            this.DistanceLabel.Text = "-";
            // 
            // CalculateButton
            // 
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Location = new System.Drawing.Point(9, 321);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(108, 28);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calcul";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // StarshipGroup
            // 
            this.StarshipGroup.Controls.Add(this.StarshipSpeedLabel);
            this.StarshipGroup.Controls.Add(this.StarshipLabel);
            this.StarshipGroup.Controls.Add(this.StarshipSpeed);
            this.StarshipGroup.Controls.Add(this.StarshipCombo);
            this.StarshipGroup.Location = new System.Drawing.Point(1, 231);
            this.StarshipGroup.Name = "StarshipGroup";
            this.StarshipGroup.Size = new System.Drawing.Size(333, 84);
            this.StarshipGroup.TabIndex = 12;
            this.StarshipGroup.TabStop = false;
            this.StarshipGroup.Text = "Vaisseau";
            // 
            // StarshipSpeedLabel
            // 
            this.StarshipSpeedLabel.AutoSize = true;
            this.StarshipSpeedLabel.Location = new System.Drawing.Point(223, 20);
            this.StarshipSpeedLabel.Name = "StarshipSpeedLabel";
            this.StarshipSpeedLabel.Size = new System.Drawing.Size(57, 17);
            this.StarshipSpeedLabel.TabIndex = 3;
            this.StarshipSpeedLabel.Text = "Vitesse :";
            // 
            // StarshipLabel
            // 
            this.StarshipLabel.AutoSize = true;
            this.StarshipLabel.Location = new System.Drawing.Point(9, 21);
            this.StarshipLabel.Name = "StarshipLabel";
            this.StarshipLabel.Size = new System.Drawing.Size(116, 17);
            this.StarshipLabel.TabIndex = 2;
            this.StarshipLabel.Text = "Vaisseau (classe) :";
            // 
            // StarshipSpeed
            // 
            this.StarshipSpeed.Location = new System.Drawing.Point(223, 42);
            this.StarshipSpeed.Name = "StarshipSpeed";
            this.StarshipSpeed.Size = new System.Drawing.Size(99, 22);
            this.StarshipSpeed.TabIndex = 1;
            // 
            // StarshipCombo
            // 
            this.StarshipCombo.FormattingEnabled = true;
            this.StarshipCombo.Location = new System.Drawing.Point(8, 42);
            this.StarshipCombo.Name = "StarshipCombo";
            this.StarshipCombo.Size = new System.Drawing.Size(207, 25);
            this.StarshipCombo.TabIndex = 0;
            this.StarshipCombo.SelectedIndexChanged += new System.EventHandler(this.StarshipCombo_SelectedIndexChanged);
            // 
            // MainForm
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astrogator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.departureGroup.ResumeLayout(false);
            this.departureGroup.PerformLayout();
            this.arrivalGroup.ResumeLayout(false);
            this.arrivalGroup.PerformLayout();
            this.StarshipGroup.ResumeLayout(false);
            this.StarshipGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DepartureCombo;
        private System.Windows.Forms.Label depLongitudeLabel;
        private System.Windows.Forms.TextBox depLongitude;
        private System.Windows.Forms.TextBox depLatitude;
        private System.Windows.Forms.Label depLatitudeLabel;
        private System.Windows.Forms.TextBox depHeight;
        private System.Windows.Forms.Label depHeightLabel;
        private System.Windows.Forms.GroupBox departureGroup;
        private System.Windows.Forms.GroupBox arrivalGroup;
        private System.Windows.Forms.ComboBox ArrivalCombo;
        private System.Windows.Forms.Label arrHeightLabel;
        private System.Windows.Forms.Label arrLongitudeLabel;
        private System.Windows.Forms.TextBox arrHeight;
        private System.Windows.Forms.TextBox arrLongitude;
        private System.Windows.Forms.Label arrLatitudeLabel;
        private System.Windows.Forms.TextBox arrLatitude;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox StarshipGroup;
        private System.Windows.Forms.Label StarshipSpeedLabel;
        private System.Windows.Forms.Label StarshipLabel;
        private System.Windows.Forms.TextBox StarshipSpeed;
        private System.Windows.Forms.ComboBox StarshipCombo;
    }
}

