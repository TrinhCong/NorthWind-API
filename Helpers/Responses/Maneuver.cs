using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class Maneuver
    {

        public Maneuver()
        {
            location = new List<double>();
        }

        public int bearing_after { get; set; }
        public int bearing_before { get; set; }
        public List<double> location { get; set; }
        public string modifier { get; set; }
        public string type { get; set; }
        public int exit { get; set; }
    }
}
