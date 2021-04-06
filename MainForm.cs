﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrogator
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void SpawnForm(Form newForm)
        {
            newForm.StartPosition = FormStartPosition.Manual;
            foreach (var form in MdiChildren)
            {
                newForm.Location = new Point(0, 0);
                if (form.Name == newForm.Name)
                {   
                    newForm.Location = new Point(form.Location.X + 30, form.Location.Y + 30);
                }
            }
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Utils.CopyData();
            AstrogatorMenuItem_Click(sender, e);
        }

        private void AstrogatorMenuItem_Click(object sender, EventArgs e)
        {
            SpawnForm(new AstrogatorForm());
        }

        private void StarshipsMenuItem_Click(object sender, EventArgs e)
        {
            SpawnForm(new StarshipsForm());
        }

        private void AffiliationsMenuItem_Click(object sender, EventArgs e)
        {
            SpawnForm(new AffiliationsForm());
        }

        private void SectorsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CatalogMenuItem_Click(object sender, EventArgs e)
        {
            SpawnForm(new StarCatalogForm());
        }

        public void Notify(string text, ToolTipIcon icon = ToolTipIcon.None, int seconds = 5, string title = "")
        {
            FlashMessages.BalloonTipText = text;
            FlashMessages.BalloonTipTitle = title != "" ? title : Application.ProductName;
            if (icon != ToolTipIcon.None)
                FlashMessages.BalloonTipIcon = icon;
            FlashMessages.ShowBalloonTip(seconds * 1000);
        }

    }
}
