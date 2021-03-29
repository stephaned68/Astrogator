using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    class StarSystem
    {
        public string Name { get; set; }

        public string Affiliation { get; set; }

        public int Longitude { get; set; }

        public int Latitude { get; set; }

        public int Height { get; set; }

        public byte TechLevel { get; set; }
    }
}
