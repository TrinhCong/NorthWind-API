using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Enums
{
    public static class VehicleType
    {
        public const int Car = 1;
        public const int Taxi = 2;
        public const int Bike = 3;

        public static class Modes
        {
            public const int Fastest = 1;
            public const int Shortest = 2;

            public static class Car
            {
                public const int Fastest = 5000;
                public const int Shortest = 5001;
            }

            public static class Bike
            {
                public const int Fastest = 5300;
                public const int Shortest = 5400;
            }
        }
    }
}
