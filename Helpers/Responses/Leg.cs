using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class Leg
    {
        public Leg()
        {
            this.steps = new List<Step>();
        }
        public string summary { get; set; }
        public double weight { get; set; }
        public double duration { get; set; }
        public List<Step> steps { get; set; }
        public double distance { get; set; }
    }
}
