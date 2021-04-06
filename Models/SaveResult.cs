using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrogator.Models
{
    public class SaveResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public SaveResult()
        {
            Success = true;
            Message = "";
        }
    }
}
