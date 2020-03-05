using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers
{
    public class CoordinateHelper
    {
        public static double ConvertDeg2Rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        public static double ConvertRad2Deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }
    }
}
