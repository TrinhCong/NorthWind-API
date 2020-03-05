using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class Intersection
    {
        public Intersection()
        {
            location = new List<double>();
            bearings = new List<int>();
            entry = new List<bool>();
        }

        public int @out { get; set; }
        public List<bool> entry { get; set; }
        public List<int> bearings { get; set; }
        public List<double> location { get; set; }
        public int? @in { get; set; }
    }
}
