using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrogator
{
    public class Utils
    {
        public static object CreateInstance(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes()
                .First(t => t.Name == className);

            return Activator.CreateInstance(type);
        }

        public static Form GetForm(string formName)
        {
            Form form = null;
            if (formName != null)
            {
                form = (Form)CreateInstance(formName.ToString());
            }
            return form;
        }

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

        public static DialogResult Alert(string message, MessageBoxIcon icon = MessageBoxIcon.Warning)
        {
            return MessageBox.Show(
                message,
                Application.ProductName,
                MessageBoxButtons.OK,
                icon
                );
        }

        public static DialogResult Confirm(
            string message, 
            MessageBoxButtons buttons = MessageBoxButtons.YesNo, 
            MessageBoxIcon icon = MessageBoxIcon.Question
            )
        {
            return MessageBox.Show(
                message,
                Application.ProductName,
                buttons,
                icon
                );
        }
    }
}
