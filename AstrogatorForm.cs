using Astrogator.Models;
using Astrogator.UIModels;
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
    public partial class AstrogatorForm : Form
    {
        
        public AstrogatorForm()
        {
            InitializeComponent();            
        }

        private void loadCombo(ComboBox combo, ComboBox sectorCombo)
        {
            var selected = (StarSector)sectorCombo.SelectedItem;
            
            var comboList = new List<StarComboItem>();            
            foreach(var affiliation in StarCatalogService.GetAffiliations(selected.Name))
            {
                comboList.Add(new StarComboItem { DisplayName = $"<< {affiliation} >>" });

                foreach(var system in StarCatalogService.GetStarSystems(selected.Name, affiliation))
                {
                    comboList.Add(new StarComboItem { DisplayName = $"-- {system.Name}", StarSystem = system });
                }
            }

            Utils.BindCombo(combo, comboList, "DisplayName", "StarSystem");
        }

        private void loadShipCombo()
        {
            var shipCombo = new List<ShipComboItem>();
            shipCombo.Add(new ShipComboItem { Name = "", Speed = 0 });

            foreach (var shipClass in ShipClassService.GetAll())
            {
                shipCombo.Add(new ShipComboItem { Name = $"Classe : {shipClass.Name}", Speed = shipClass.BaseSpeed });
                var ships = StarshipService.GetAll()
                    .Where(s => s.Class == shipClass.Name)
                    .ToList();
                foreach (var ship in ships)
                {
                    shipCombo.Add(new ShipComboItem { Name = ship.Name, Speed = ship.Speed });
                }
            }

            Utils.BindCombo(StarshipCombo, shipCombo, "Name");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Utils.BindCombo(DepSectorCombo, StarCatalogService.GetSectors(), "Name");

            Utils.BindCombo(ArrSectorCombo, StarCatalogService.GetSectors(), "Name");

            loadShipCombo();
        }

        private void RefreshDistance()
        {
            var starSystem1 = (StarSystem)DepSystemCombo.SelectedValue;
            if (starSystem1 == null) return;

            var starSystem2 = (StarSystem)ArrSystemCombo.SelectedValue;
            if (starSystem2 == null) return;

            var distance = StarCatalogService.Distance(starSystem1.Location, starSystem2.Location);
            DistanceLabel.Text = distance.ToString();
        }

        private void DepartureCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (StarSystem)DepSystemCombo.SelectedValue;
            if (selected == null) return;

            DepLongitude.Text = selected.Location.Longitude.ToString();
            DepLatitude.Text = selected.Location.Latitude.ToString();
            DepHeight.Text = selected.Location.Height.ToString();
            RefreshDistance();
        }

        private void ArrivalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (StarSystem)ArrSystemCombo.SelectedValue;
            if (selected == null) return;

            ArrLongitude.Text = selected.Location.Longitude.ToString();
            ArrLatitude.Text = selected.Location.Latitude.ToString();
            ArrHeight.Text = selected.Location.Height.ToString();
            RefreshDistance();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            RefreshDistance();
        }

        private void StarshipCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (ShipComboItem)StarshipCombo.SelectedItem;
            StarshipSpeed.Text = selected.Speed.ToString();
        }

        private void DepSectorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCombo(DepSystemCombo, DepSectorCombo);
        }

        private void ArrSectorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCombo(ArrSystemCombo, ArrSectorCombo);
        }
    }
}
