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
    public partial class StarshipClassForm : Form
    {
        public StarshipClassForm()
        {
            InitializeComponent();
        }

        private void StarshipClassForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ShipClassService.GetAll();
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
