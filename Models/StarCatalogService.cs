using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    class StarCatalogService
    {
        public static string DataFile 
        {
            get
            {
                return Path.Combine(Configuration.DataDirectory, "star-catalog.json");
            }
        }

        public static IEnumerable<StarSector> GetSectors()
        {
            var list = new List<StarSector>();

            if (File.Exists(DataFile))
            {
                var jsonData = File.ReadAllText(DataFile);
                if (jsonData != "")
                {
                    list = JsonSerializer.Deserialize<List<StarSector>>(jsonData);
                }
            }

            return list;
        }

        public static StarSector GetSector(string sector)
        {
            return GetSectors()
                .Where(s => s.Name == sector)
                .FirstOrDefault();
        }

        public static IEnumerable<string> GetAffiliations(string sector)
        {
            var list = new List<string>();
            if (sector != null)
                list = GetSector(sector).Affiliations;
            return list;
        }

        public static IEnumerable<StarSystem> GetStarSystems(string sector, string affiliation = "")
        {
            var list = GetSector(sector).Systems;
            if (affiliation != "")
                list = list.Where(s => s.Affiliation == affiliation).ToList();
            return list;
        }

        public static SaveResult Persist(List<StarSector> catalog)
        {
            var persisted = new SaveResult();

            try
            {
                var jsonData = JsonSerializer.Serialize(catalog, new JsonSerializerOptions { WriteIndented = true } );
                File.WriteAllText(DataFile, jsonData);
            } catch (Exception ex) 
            {
                persisted.Success = false;
                persisted.Message = ex.Message;
            }

            return persisted;
        }

        public static int Distance(TravelInfo travel, bool useDetour = true)
        {
            double result = 0;

            if (travel.Origin != null && travel.Destination != null)
            {
                result += Math.Pow((travel.Origin.Location.Longitude - travel.Destination.Location.Longitude), 2);
                result += Math.Pow((travel.Origin.Location.Latitude - travel.Destination.Location.Latitude), 2);
                result += Math.Pow((travel.Origin.Location.Height - travel.Destination.Location.Height), 2);
                result = Math.Sqrt(result);
            }
            if (useDetour && travel.Detour != 1)
                result *= travel.Detour;

            return (int)Math.Floor(result + 0.5);
        }
    }
}
