using Astrogator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrogator.UIModels
{
    public class StarComboItem
    {
        public string DisplayName { get; set; }

        public StarSystem StarSystem { get; set; }
    }
}
