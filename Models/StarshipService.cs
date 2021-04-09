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

        private static SaveResult WriteFile(List<Starship> list)
        {
            var result = new SaveResult();

            try
            {
                var jsonData = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(DataFile, jsonData);
            }
            catch (Exception ex) 
            {
                result.Success = false;
                result.Message = ex.Message;
            }

            return result;
        }

        public static SaveResult Insert(Starship ship)
        {
            // Add to list
            List<Starship> list = (List<Starship>)GetAll();
            list.Add(ship);

            return WriteFile(list);
        }

        public static SaveResult Update(Starship ship)
        {
            // Update list
            List<Starship> list = (List<Starship>)GetAll();
            var ix = list.FindIndex(s => s.Name == ship.Name);
            list[ix] = ship;

            return WriteFile(list);
        }
    }
}
