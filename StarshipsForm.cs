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
    public partial class StarshipsForm : Form
    {
        private bool editMode;

        public StarshipsForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            StarshipList.Items.Clear();

            foreach (var ship in StarshipService.GetAll())
            {
                StarshipList.Items.Add(
                    new ListViewItem (
                        new string[]
                        {
                            ship.Name,
                            ship.Class,
                            ship.Speed.ToString()
                        }
                    )
                    );
            }
        }

        private void ChangeControlsColor()
        {
            ShipName.BackColor = editMode ? Color.LightSteelBlue : Color.White;
            ShipClassCombo.BackColor = editMode ? Color.LightSteelBlue : Color.White;
            ShipSpeed.BackColor = editMode ? Color.LightSteelBlue : Color.White;
        }

        private void StarshipsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            Utils.BindCombo(ShipClassCombo, Utils.DropList(ShipClassService.GetAll()),"Name", "Name");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var ship = new Starship
            {
                Name = ShipName.Text,
                Class = (string)ShipClassCombo.SelectedValue,
                Speed = (int)ShipSpeed.Value
            };

            if (editMode)
            {
                StarshipService.Update(ship);
            } 
            else
            {
                StarshipService.Insert(ship);
            }
            LoadData();
            ResetButton_Click(sender, e);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            editMode = false;
            ChangeControlsColor();
            ShipName.Text = "";
            ShipClassCombo.SelectedItem = null;
            ShipSpeed.Value = 0;
        }

        private void ShipClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (ShipClass)ShipClassCombo.SelectedItem;
            if (selected != null) 
                ShipSpeed.Value = selected.BaseSpeed;
        }

        private void StarshipList_DoubleClick(object sender, EventArgs e)
        {
            var selected = StarshipList.SelectedItems;
            if (selected.Count == 1)
            {
                ShipName.Text = selected[0].SubItems[0].Text;
                ShipClassCombo.SelectedValue = selected[0].SubItems[1].Text;
                ShipSpeed.Value = int.Parse(selected[0].SubItems[2].Text);
                editMode = true;
                ChangeControlsColor();
            }
        }
    }
}
