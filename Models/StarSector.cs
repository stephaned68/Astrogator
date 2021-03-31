using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    public class StarSector
    {
        public string Name { get; set; }

        public List<string> Affiliations { get; set; }

        public List<StarSystem> Systems { get; set; }
    }
}
