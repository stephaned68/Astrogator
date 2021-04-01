﻿using System;
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
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Astrogator", "star-catalog.json");
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
            return GetSector(sector).Affiliations;
        }

        public static IEnumerable<StarSystem> GetStarSystems(string sector, string affiliation = "")
        {
            var list = GetSector(sector).Systems;
            if (affiliation != "")
                list = list.Where(s => s.Affiliation == affiliation).ToList();
            return list;
        }

        public static double Distance(Coordinates star1, Coordinates star2)
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