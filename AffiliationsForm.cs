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
        public AffiliationsForm()
        {
            InitializeComponent();
        }

        private void AffiliationsForm_Load(object sender, EventArgs e)
        {
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

            StarCatalogService.Persist(catalog);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
