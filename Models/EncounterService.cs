using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    public class EncounterService
    {
        public static string DataFile
        {
            get
            {
                return Path.Combine(Configuration.DataDirectory, "encounter-tables.json");
            }
        }

        public static IEnumerable<EncounterTable> GetTables()
        {
            var list = new List<EncounterTable>();

            if (File.Exists(DataFile))
            {
                var jsonData = File.ReadAllText(DataFile);
                if (jsonData != "")
                {
                    list = JsonSerializer.Deserialize<List<EncounterTable>>(jsonData);
                }
            }

            return list;
        }

        public static EncounterTable GetTable(string tableName)
        {
            return GetTables()
                .Where(t => t.Name == tableName)
                .FirstOrDefault();
        }

        public static string GetEncounter(string encounter = "", string suffix = "", string tableName = "Main")
        {
            var table = GetTable(tableName);
            if (table == null && suffix != "")
                table = GetTable(tableName + "." + suffix);
            if (table == null)
                return "";

            var roll = Utils.DiceRoller(table.Dice);
            var found = table.Results.FirstOrDefault(i => i.Value == roll.Sum);
            if (found != null)
            {
                encounter += found.Description;
                if (!string.IsNullOrEmpty(found.Table))
                    encounter = GetEncounter(encounter, suffix, found.Table);
            }

            return encounter;
        }

        public static List<Encounter> GetEncounters(TravelInfo travel)
        {
            var encounters = new List<Encounter>();

            var distance = StarCatalogService.Distance(travel);
            var flight = 0;

            var timestamp = 0;

            var jumps = 0;
            var milestones = 0;

            while (flight < distance)
            {
                timestamp++;
                flight += travel.Speed;

                var jump = Math.Floor((decimal)flight / 50);
                if (travel.UnknownRoute != 1 && jumps < jump)
                {
                    jumps = (int)jump;
                    encounters.Add(new Encounter()
                    {
                        TimeStamp = timestamp,
                        Distance = flight,
                        Event = "Point de Vérité"
                    });
                    continue;
                }

                var encounterAt = Math.Floor((decimal)flight / 100);
                if (milestones < encounterAt)
                {
                    milestones = (int)encounterAt;

                    var suffix = "0";
                    if (milestones == 1)
                        suffix = travel.Origin.TechLevel.ToString();
                    if (flight + travel.Speed > distance)
                        suffix = travel.Destination.TechLevel.ToString();

                    var encounterText = GetEncounter("",suffix);
                    if (!string.IsNullOrEmpty(encounterText))
                    {
                        encounters.Add(new Encounter()
                        {
                            TimeStamp = timestamp,
                            Distance = flight,
                            Event = encounterText
                        });
                    }
                }
            }

            return encounters;
        }
    }
}
