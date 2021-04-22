using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    public class RollResult
    {
        public int Sum { get; set; }

        public int[] Rolls { get; set; }

        public RollResult() { }

        public RollResult(int numberOfDice)
        {
            Sum = 0;
            Rolls = new int[numberOfDice];
        }
    }
}
