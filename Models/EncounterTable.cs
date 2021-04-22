using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    public class EncounterTable
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Dice { get; set; }

        public List<EncounterItem> Results { get; set; }
    }
}
