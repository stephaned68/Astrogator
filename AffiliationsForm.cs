using Astrogator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrogator
{
    public partial class AffiliationsForm : Form
    {
        private MainForm mainForm;

        public AffiliationsForm()
        {
            InitializeComponent();
        }

        private void AffiliationsForm_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)MdiParent;
            Utils.BindCombo(SectorCombo, Utils.DropList(StarCatalogService.GetSectors()), "Name");
        }

        private void SectorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (StarSector)SectorCombo.SelectedItem;
            if (selected != null)
            {
                Affiliations.Lines = StarCatalogService.GetAffiliations(selected.Name).ToArray();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var catalog = StarCatalogService.GetSectors().ToList();

            var selected = (StarSector)SectorCombo.SelectedItem;
            var sector = catalog.SingleOrDefault(s => s.Name == selected.Name);
            sector.Affiliations = Affiliations.Lines.ToList();

            var persisted = StarCatalogService.Persist(catalog);
            mainForm.Notify(
                persisted.Success ? $"Liste des affiliations sauvegardées avec succès" : persisted.Message,
                persisted.Success ? ToolTipIcon.Info : ToolTipIcon.Warning
                );
        }

        private void SectorCombo_Leave(object sender, EventArgs e)
        {
            var sectorName = SectorCombo.Text;
            var exists = SectorCombo.FindString(sectorName) >= 0;
            if (!exists)
            {
                var resp = MessageBox.Show(
                    $"Voulez-vous ajouter le secteur {sectorName} au catalogue ?",
                    Application.ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (resp == DialogResult.Yes)
                {
                    var sector = new StarSector
                    {
                        Name = sectorName,
                        Affiliations = new List<string>(),
                        Systems = new List<StarSystem>()
                    };

                    var catalog = StarCatalogService.GetSectors().ToList();
                    catalog.Add(sector);
                    var result = StarCatalogService.Persist(catalog);
                    if (result.Success)
                    {
                        AffiliationsForm_Load(sender, e);
                        SectorCombo.SelectedIndex = SectorCombo.FindString(sectorName);
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
