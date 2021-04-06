using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    public class StarSystem
    {
        public string Name { get; set; }

        public string Affiliation { get; set; }

        public Coordinates Location { get; set; }

        public int TechLevel { get; set; }
    }
}
