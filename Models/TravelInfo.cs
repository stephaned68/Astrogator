using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    public class TravelInfo
    {
        public StarSystem Origin { get; set; }

        public StarSystem Destination { get; set; }

        public int Speed { get; set; }

        public double UnknownRoute { get; set; }

        public double Detour { get; set; }

        public TravelInfo()
        {
            UnknownRoute = 1;
            Detour = 1;
        }
    }
}
