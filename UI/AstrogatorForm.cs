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
    public partial class AstrogatorForm : BaseForm
    {

        public AstrogatorForm()
        {
            InitializeComponent();
        }

        private void loadCombo(ComboBox combo, ComboBox sectorCombo)
        {
            var selected = (StarSector)sectorCombo.SelectedItem;

            var comboList = new List<StarComboItem>();
            foreach (var affiliation in StarCatalogService.GetAffiliations(selected.Name))
            {
                comboList.Add(new StarComboItem { DisplayName = $"<< {affiliation} >>" });

                foreach (var system in StarCatalogService.GetStarSystems(selected.Name, affiliation))
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
                shipCombo.Add(new ShipComboItem { Name = $"Classe : { shipClass.Name }", Speed = shipClass.BaseSpeed });
                var ships = StarshipService.GetAll()
                    .Where(s => s.Class == shipClass.Name)
                    .ToList();
                foreach (var ship in ships)
                {
                    shipCombo.Add(new ShipComboItem { Name = $"-- { ship.Name }", Speed = ship.Speed });
                }
            }

            Utils.BindCombo(StarshipCombo, shipCombo, "Name");
        }

        private void setupGridView()
        {
            var gridData = new string[]
            {
                "Distance",
                "Durée",
                "Antimatière",
                "- Poids consommé",
                "- Durée du plein"
            };
            foreach(var title in gridData)
            {
                var gRow = new DataGridViewRow();
                gRow.Cells.Add(new DataGridViewTextBoxCell() { Value = title });
                gRow.Cells.Add(new DataGridViewTextBoxCell() { Value = "" });
                DataGridView.Rows.Add(gRow);
            }
            
        }

        private TravelInfo travelInfo()
        {
            var ship = (ShipComboItem)StarshipCombo.SelectedValue;
            var unknown = UnknownRouteCheckbox.Checked ? (double)UnknownRoute.Value : 1;
            var detour = DetourCheckbox.Checked ? (double)Detour.Value : 1;
            return new TravelInfo
            {
                Origin = (StarSystem)DepSystemCombo.SelectedValue,
                Destination = (StarSystem)ArrSystemCombo.SelectedValue,
                Speed = ship.Speed,
                UnknownRoute = unknown,
                Detour = detour
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Utils.BindCombo(DepSectorCombo, StarCatalogService.GetSectors(), "Name");

            Utils.BindCombo(ArrSectorCombo, StarCatalogService.GetSectors(), "Name");

            loadShipCombo();

            setupGridView();

            UnknownRouteCheckbox_CheckedChanged(sender, e);
            DetourCheckbox_CheckedChanged(sender, e);
        }

        private void DisplayDistance()
        {
            var cell = DataGridView.Rows[0].Cells[1];
            var travel = travelInfo();
            cell.Value = $"{ StarCatalogService.Distance(travel) } AL";
            if (travel.Detour != 1)
            {
                cell.ToolTipText = $"{ StarCatalogService.Distance(travel, false) } AL x { travel.Detour } de détour";
            }
        }

        private void RefreshDistance()
        {
            var starSystem1 = (StarSystem)DepSystemCombo.SelectedValue;
            if (starSystem1 == null) return;

            var starSystem2 = (StarSystem)ArrSystemCombo.SelectedValue;
            if (starSystem2 == null) return;

            DisplayDistance();
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

        private void DisplayTime()
        {
            var cell = DataGridView.Rows[1].Cells[1];
            var travel = travelInfo();
            cell.Value = StarshipService.TravelTime(travel);
            var tipText = $"{ StarshipService.TravelHours(travel, false) } heures";
            if (travel.UnknownRoute != 1)
                tipText += $" x { travel.UnknownRoute } pour méconnaissance de la Route";
            cell.ToolTipText = tipText;
        }

        private void DisplayTravel()
        {
            var list = EncounterService.GetEncounters(travelInfo());
            TravelView.Items.Clear();
            foreach(var item in list)
            {
                TravelView.Items.Add(
                    new ListViewItem(
                        new string[]
                        {
                            item.TimeStamp.ToString(),
                            item.Distance.ToString(),
                            item.Event
                        })
                    );
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            RefreshDistance();
            DisplayTime();
            DisplayTravel();
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

        private void UnknownRouteCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UnknownRoute.Enabled = UnknownRouteCheckbox.Checked;
        }

        private void DetourCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Detour.Enabled = DetourCheckbox.Checked;
        }
    }
}
