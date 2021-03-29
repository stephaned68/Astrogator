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
    public partial class MainForm : Form
    {
        //private IEnumerable<StarSystem> starCatalog;

        public MainForm()
        {
            InitializeComponent();
            //starCatalog = StarSystemService.GetAll();            
        }

        private void loadCombo(ComboBox combo)
        {
            var list = StarSystemService.GetAll();

            var comboList = new List<StarSystem>();
            string affiliation = "";

            foreach(var item in list)
            {
                if (item.Affiliation != affiliation)
                {
                    affiliation = item.Affiliation;
                    comboList.Add(new StarSystem { Name = $"<< {affiliation} >>", Affiliation = "" });
                }
                comboList.Add(item);
            }
            combo.DataSource = comboList;
            combo.DisplayMember = "Name";
        }

        private void loadShipCombo()
        {
            var shipCombo = new List<ShipComboItem>();
            shipCombo.Add(new ShipComboItem { Name = "", Speed = 0 });

            foreach (var shipClass in ShipClassService.GetAll())
            {
                shipCombo.Add(new ShipComboItem { Name = $"<< Classe : {shipClass.Name} >>", Speed = shipClass.BaseSpeed });
                var ships = StarshipService.GetAll()
                    .Where(s => s.Class == shipClass.Name)
                    .ToList();
                foreach (var ship in ships)
                {
                    shipCombo.Add(new ShipComboItem { Name = ship.Name, Speed = ship.FTLSpeed });
                }
            }
            StarshipCombo.DataSource = shipCombo;
            StarshipCombo.DisplayMember = "Name";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadCombo(DepartureCombo);
            loadCombo(ArrivalCombo);

            loadShipCombo();
        }

        private void RefreshDistance()
        {
            var starSystem1 = (StarSystem)DepartureCombo.SelectedItem;
            if (starSystem1.Affiliation == "") return;

            var starSystem2 = (StarSystem)ArrivalCombo.SelectedItem;
            if (starSystem2.Affiliation == "") return;

            var distance = StarSystemService.Distance(starSystem1, starSystem2);
            DistanceLabel.Text = distance.ToString();
        }

        private void DepartureCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (StarSystem)DepartureCombo.SelectedItem;
            if (selected.Affiliation == "") return;

            depLongitude.Text = selected.Longitude.ToString();
            depLatitude.Text = selected.Latitude.ToString();
            depHeight.Text = selected.Height.ToString();
            RefreshDistance();
        }

        private void ArrivalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (StarSystem)ArrivalCombo.SelectedItem;
            if (selected.Affiliation == "") return;

            arrLongitude.Text = selected.Longitude.ToString();
            arrLatitude.Text = selected.Latitude.ToString();
            arrHeight.Text = selected.Height.ToString();
            RefreshDistance();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            RefreshDistance();
        }

        private void StarshipCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
