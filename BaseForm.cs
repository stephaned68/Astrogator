using System;
using System.Drawing;
using System.Windows.Forms;

namespace Astrogator
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.Font = Configuration.BaseFont;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            // Common Pre-Display logic
        }

        private void BaseForm_Shown(object sender, EventArgs e)
        {
            // Common Post-Display logic
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Common Pre-Close logic
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Common Post-Close logic
        }
    }
}
