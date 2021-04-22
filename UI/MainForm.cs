using System;
using System.Drawing;
using System.Windows.Forms;

namespace Astrogator
{
    public partial class MainForm : BaseForm
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
            var files = Utils.CopyData();
            if (files.Count > 0)
            {
                var message = "Fichiers copiés :\n" + string.Join('\n', files);
                Notify(message, ToolTipIcon.Info);
            }
            AstrogatorMenuItem_Click(sender, e);
        }

        private void MenuItemForm(ToolStripItem menuItem)
        {
            var form = Utils.GetForm((string)menuItem.Tag);
            if (form != null)
                SpawnForm(form);
        }

        private void AstrogatorMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemForm(AstrogatorMenuItem);
        }

        private void StarshipsMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemForm(StarshipsMenuItem);
        }

        private void AffiliationsMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemForm(AffiliationsMenuItem);
        }

        private void CatalogMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemForm(CatalogMenuItem);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                TabbedForms.Visible = false;
                var resp = Utils.Confirm(
                    $"Voulez-vous quitter { Application.ProductName } ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                    );
                if (resp == DialogResult.Yes)
                    Application.Exit();
                return;
            }

            ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (ActiveMdiChild.Tag == null)
            {
                var newTab = new TabPage(ActiveMdiChild.Text);
                newTab.Tag = ActiveMdiChild;
                newTab.Parent = TabbedForms;
                TabbedForms.SelectedTab = newTab;

                ActiveMdiChild.Tag = newTab;
                ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
            }
            if (!TabbedForms.Visible)
                TabbedForms.Visible = true;
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void TabbedForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TabbedForms.SelectedTab != null) && (TabbedForms.SelectedTab.Tag != null))
                (TabbedForms.SelectedTab.Tag as Form).Select();
        }

        private void CloseContextMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"{ Application.ProductName } v{ Application.ProductVersion }"
                + $"\n\nDonnées :\n{ Configuration.DataDirectory }"
                + $"\n\nProgramme :\n{ Application.ExecutablePath }",
                "A propos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        public void Notify(string text, ToolTipIcon icon = ToolTipIcon.None, int seconds = 5, string title = "")
        {
            FlashMessages.BalloonTipText = text;
            FlashMessages.BalloonTipTitle = title != "" ? title : Application.ProductName;
            if (icon != ToolTipIcon.None)
                FlashMessages.BalloonTipIcon = icon;
            FlashMessages.ShowBalloonTip(seconds * 1000);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var forms = MdiChildren.Length;
            if (forms < 2)
                return;

            var resp = Utils.Confirm($"Vous allez fermer { forms } onglets.\n\nConfirmez-vous la fermeture du programme ?");
            if (resp == DialogResult.No)
                e.Cancel = true;
        }
    }
}
