using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers
{
    public class DatabaseOptions
    {
        public string DefaultConnection { get; set; }
        public string FullTextConnection { get; set; }
    }
}
