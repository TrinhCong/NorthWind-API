using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class RouteResponse
    {
        public RouteResponse()
        {
            waypoints = new List<Waypoint>();
            routes = new List<Route>();
        }

        public string code { get; set; }
        public List<Route> routes { get; set; }
        public List<Waypoint> waypoints { get; set; }
    }
}
