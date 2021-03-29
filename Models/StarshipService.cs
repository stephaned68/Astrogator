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
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Astrogator", "starships.json");
            }
        }

        public static IEnumerable<Starship> GetAll()
        {
            var jsonData = File.ReadAllText(DataFile);
            var list = JsonSerializer.Deserialize<List<Starship>>(jsonData)
                .OrderBy(s => s.Class)
                .ToList();
            return list;
        }
    }
}
