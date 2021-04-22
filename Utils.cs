using Astrogator.Models;
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

        public static List<string> CopyData()
        {
            if (!Directory.Exists(Configuration.DataDirectory))
                Directory.CreateDirectory(Configuration.DataDirectory);

            var files = new List<string>();

            foreach (var source in Directory.GetFiles("Data"))
            {
                var sourceInfo = new FileInfo(source);
                var target = Path.Combine(Configuration.DataDirectory, Path.GetFileName(source));
                var targetInfo = new FileInfo(target);
                if (sourceInfo.LastWriteTime > targetInfo.LastWriteTime)
                {
                    File.Copy(source, target, true);
                    files.Add(target);
                }
            }

            return files;
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

        public static RollResult DiceRoller(int numberOfDice, int numberOfFaces = 6)
        {
            var result = new RollResult(numberOfDice);
            var rand = new Random();

            for(var die = 1; die <= numberOfDice; die++)
            {
                var roll = rand.Next(1, numberOfFaces);
                result.Rolls[die - 1] = roll;
                result.Sum += roll;
            }

            return result;
        }
    }
}
