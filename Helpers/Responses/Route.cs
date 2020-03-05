using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class Route
    {
        public string geometry { get; set; }
        public List<Leg> legs { get; set; }
        public string weight_name { get; set; }
        public double weight { get; set; }
        public double duration { get; set; }
        public double distance { get; set; }
    }
}
