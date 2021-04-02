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

        public static Starship GetOne(string Name)
        {
            var ship = GetAll().SingleOrDefault(s => s.Name == Name);
            return ship;
        }

        private static bool WriteFile(List<Starship> list)
        {
            bool result = false;

            try
            {
                var jsonData = JsonSerializer.Serialize(list);
                File.WriteAllText(DataFile, jsonData);
                result = true;
            }
            catch (Exception) { }

            return result;
        }

        public static bool Insert(Starship ship)
        {
            // Add to list
            List<Starship> list = (List<Starship>)GetAll();
            list.Add(ship);

            return WriteFile(list);
        }

        public static bool Update(Starship ship)
        {
            // Update list
            List<Starship> list = (List<Starship>)GetAll();
            var ix = list.FindIndex(s => s.Name == ship.Name);
            list[ix] = ship;

            return WriteFile(list);
        }
    }
}
