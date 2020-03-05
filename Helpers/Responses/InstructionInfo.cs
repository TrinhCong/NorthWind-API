using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class InstructionInfo
    {
        public string geometry { get; set; }
        public double distance { get; set; }
        public string distance_text { get; set; }
        public double duration { get; set; }
        public string duration_text { get; set; }
        public string road { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public string description { get; set; }
        public int turn_type { get; set; }
        public int bearing_after { get; set; }
        public int bearing_before { get; set; }
    }
}
