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
    public partial class StarCatalogForm : BaseForm
    {
        private DataTable stars;

        private string selectedSector;

        public StarCatalogForm()
        {
            InitializeComponent();

            stars = new DataTable();
            stars.Columns.Add("Name", typeof(string));
            stars.Columns.Add("Longitude", typeof(int));
            stars.Columns.Add("Latitude", typeof(int));
            stars.Columns.Add("Height", typeof(int));
            stars.Columns.Add("Affiliation", typeof(string));
            stars.Columns.Add("TechLevel", typeof(int));
        }

        private void StarCatalogForm_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)MdiParent;

            SectorGrid.AutoGenerateColumns = false;

            foreach (var sector in StarCatalogService.GetSectors())
            {
                SectorsToolstripDropList.DropDownItems.Add(sector.Name);
            }

            SectorGridSystemNameCol.DataPropertyName = "Name";
            SectorGridLongitudeCol.DataPropertyName = "Longitude";
            SectorGridLatitudeCol.DataPropertyName = "Latitude";
            SectorGridHeightCol.DataPropertyName = "Height";
            SectorGridAffiliationCol.DataPropertyName = "Affiliation";

            DataTable tlCombo = new DataTable();
            tlCombo.Columns.Add("tlValue", typeof(int));
            tlCombo.Columns.Add("tlName", typeof(string));
            tlCombo.Rows.Add(0, "-");
            tlCombo.Rows.Add(1, "NT1");
            tlCombo.Rows.Add(2, "NT2");
            tlCombo.Rows.Add(3, "NT3");
            tlCombo.Rows.Add(4, "NT4");
            tlCombo.Rows.Add(5, "NT5");
            tlCombo.Rows.Add(6, "NT6");
            SectorGridTLCol.DataPropertyName = "TechLevel";
            SectorGridTLCol.DataSource = tlCombo;
            SectorGridTLCol.DisplayMember = "tlName";
            SectorGridTLCol.ValueMember = "tlValue";

            SectorGrid.DataSource = stars;
        }

        private void SectorsToolstripDropList_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SectorGridAffiliationCol.Items.Clear();
            selectedSector = e.ClickedItem.Text;
            SectorGridAffiliationCol.Items.AddRange(StarCatalogService.GetAffiliations(selectedSector).ToArray());

            stars.Rows.Clear();
            foreach(var star in StarCatalogService.GetStarSystems(selectedSector))
            {
                DataRow dataRow = stars.NewRow();
                dataRow["Name"] = star.Name;
                dataRow["Longitude"] = star.Location.Longitude;
                dataRow["Latitude"] = star.Location.Latitude;
                dataRow["Height"] = star.Location.Height;
                dataRow["Affiliation"] = star.Affiliation;
                dataRow["TechLevel"] = star.TechLevel;
                stars.Rows.Add(dataRow);
            }
        }

        private void SectorGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var sb = new StringBuilder($"Ligne : {e.RowIndex}, Colonne : {e.ColumnIndex}\n{e.Exception.Message}");
            foreach (KeyValuePair<string, string> kv in e.Exception.Data)
            {
                sb.Append($"\n{kv.Key} = {kv.Value}");
            }
            MessageBox.Show(sb.ToString());
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (SectorGrid.IsCurrentRowDirty)
                this.Validate();

            var catalog = StarCatalogService.GetSectors().ToList();

            var sector = catalog.SingleOrDefault(s => s.Name == selectedSector);
            
            sector.Systems.Clear();
            foreach(DataRow star in stars.Rows)
            {
                sector.Systems.Add(new StarSystem
                {
                    Name = (string)star["Name"],
                    Location = new Coordinates 
                    { 
                        Longitude = (int)star["Longitude"], 
                        Latitude = (int)star["Latitude"], 
                        Height = (int)star["Height"] 
                    },
                    Affiliation = (string)star["Affiliation"],
                    TechLevel = (int)star["TechLevel"]
                });
            }

            var result = StarCatalogService.Persist(catalog);

            mainForm.Notify(
                result.Success ? "Catalogue enregistré avec succès" : result.Message, 
                result.Success ? ToolTipIcon.Info : ToolTipIcon.Warning
                );
        }
    }
}
