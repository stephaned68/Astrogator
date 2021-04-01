using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    class ShipClassService
    {
        public static string DataFile
        {
            get
            {
                return Path.Combine(Configuration.DataDirectory, "ship-classes.json");
            }
        }

        public static IEnumerable<ShipClass> GetAll()
        {
            var list = new List<ShipClass>();

            if (File.Exists(DataFile))
            {
                var jsonData = File.ReadAllText(DataFile);
                if (jsonData != "")
                {
                    list = JsonSerializer.Deserialize<List<ShipClass>>(jsonData)
                        .OrderBy(c => c.Name)
                        .ToList();
                }
            }
            
            return list;
        }
    }
}
