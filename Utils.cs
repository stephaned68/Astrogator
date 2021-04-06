using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrogator
{
    public class Utils
    {
        public static void CopyData()
        {
            if (!Directory.Exists(Configuration.DataDirectory))
            {
                Directory.CreateDirectory(Configuration.DataDirectory);
                foreach (var file in Directory.GetFiles("Data"))
                {
                    File.Copy(file, Path.Combine(Configuration.DataDirectory, Path.GetFileName(file)));
                }
            }
        }

        public static IEnumerable<T> DropList<T>(IEnumerable<T> list) where T : new()
        {
            var drop = list.ToList();
            drop.Insert(0, new T());
            return drop;
        }

        public static void BindCombo(ComboBox combo, IEnumerable<object> dataSource, string displayProperty = "", string valueProperty = "")
        {
            combo.DisplayMember = displayProperty;
            combo.ValueMember = valueProperty;
            combo.DataSource = dataSource;
        }

    }
}
