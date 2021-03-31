using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrogator
{
    public class Utils
    {
        public static void BindCombo(ComboBox combo, IEnumerable<object> dataSource, string displayProperty = "", string valueProperty = "")
        {
            combo.DisplayMember = displayProperty;
            combo.ValueMember = valueProperty;
            combo.DataSource = dataSource;
        }
    }
}
