using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    class StarSystemService
    {
        public static string DataFile 
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Astrogator", "star-catalog.json");
            }
        }
        public static IEnumerable<StarSystem> GetAll()
        {
            var list = new List<StarSystem>();

            if (File.Exists(DataFile))
            {
                var jsonData = File.ReadAllText(DataFile);
                if (jsonData != "")
                {
                    list = JsonSerializer.Deserialize<List<StarSystem>>(jsonData)
                        .OrderBy(s => s.Affiliation)
                        .ThenBy(s => s.Name)
                        .ToList();
                }
            }
            
            return list;
        }

        public static double Distance(StarSystem star1, StarSystem star2)
        {
            double result = 0;

            if (star1 != null && star2 != null)
            {
                result += Math.Pow((star1.Longitude - star2.Longitude), 2);
                result += Math.Pow((star1.Latitude - star2.Latitude), 2);
                result += Math.Pow((star1.Height - star2.Height), 2);
                result = Math.Sqrt(result);
            }

            return Math.Floor(result + 0.5);
        }
    }
}
