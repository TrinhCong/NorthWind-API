using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers
{
    public class ServiceOptions
    {
        public string IdentityServiceUrl { get; set; }
        public string RouteServiceUrl { get; set; }
        public string TableServiceUrl { get; set; }
    }
}
