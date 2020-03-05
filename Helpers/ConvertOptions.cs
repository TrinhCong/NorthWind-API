using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers
{
    public class ConvertOptions
    {
        public int CoinPerStartKm { get; set; }
        public int CoinPerNormalKm { get; set; }
        public int CoinPerLongKm { get; set; }
    }
}
