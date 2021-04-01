using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    class StarshipService
    {
        public static string DataFile
        {
            get
            {
                return Path.Combine(Configuration.DataDirectory, "starships.json");
            }
        }

        public static IEnumerable<Starship> GetAll()
        {
            var list = new List<Starship>();

            if (File.Exists(DataFile))
            {
                var jsonData = File.ReadAllText(DataFile);
                if (jsonData != "")
                {
                    list = JsonSerializer.Deserialize<List<Starship>>(jsonData)
                        .OrderBy(s => s.Class)
                        .ThenBy(s => s.Name)
                        .ToList();
                }
            }

            return list;
        }
    }
}
