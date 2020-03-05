using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class Source
    {
        public Source()
        {
            this.location = new List<double>();
        }
        public string hint { get; set; }
        public string name { get; set; }
        public List<double> location { get; set; }
    }
}
