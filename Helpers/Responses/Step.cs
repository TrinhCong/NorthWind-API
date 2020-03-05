using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{

    public class Step
    {
        public Step()
        {
            intersections = new List<Intersection>();
        }

        public List<Intersection> intersections { get; set; }
        public string geometry { get; set; }
        public string mode { get; set; }
        public Maneuver maneuver { get; set; }
        public double weight { get; set; }
        public double duration { get; set; }
        public string name { get; set; }
        public double distance { get; set; }
    }

}
