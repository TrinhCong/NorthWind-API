using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class Waypoint
    {
        public string hint { get; set; }
        public string name { get; set; }
        public List<double> location { get; set; }
    }
}
