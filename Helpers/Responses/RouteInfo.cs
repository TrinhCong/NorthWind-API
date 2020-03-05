using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers.Responses
{
    public class RouteInfo
    {
        private readonly ConvertOptions _convertOptions;
        private readonly LevelOptions _levelOptions;
        private double _distance = 0;

        public RouteInfo(ConvertOptions convertOptions, LevelOptions levelOptions)
        {
            instructions = new List<InstructionInfo>();
            this._convertOptions = convertOptions;
            this._levelOptions = levelOptions;
        }
        public string geometry { get; set; }
        public double distance
        {
            get
            {
                return this._distance;
            }
            set
            {
                this._distance = value;
                //if (_distance < 1000)
                //{
                //    mcoin = _convertOptions.CoinPerStartKm;
                //}
                //else
                //{

                //}
                double totalKm = this._distance / 1000;
                if (totalKm <= 2)
                    mcoin = 30;
                else if (totalKm >= 2 && totalKm <= 3)
                    mcoin = 12 * Math.Round(totalKm);
                else if (totalKm >= 3 && totalKm <= 5)
                    mcoin = 11 * Math.Round(totalKm);
                else if (totalKm >= 5 && totalKm <= 7)
                    mcoin = 10 * Math.Round(totalKm);
                else if (totalKm >= 7 && totalKm <= 10)
                    mcoin = 9 * Math.Round(totalKm);
                else if (totalKm >= 10 && totalKm <= 15)
                    mcoin = 8 * Math.Round(totalKm);
                else if (totalKm >= 15 && totalKm <= 20)
                    mcoin = 7 * Math.Round(totalKm);
                else if (totalKm >= 20 && totalKm <= 50)
                    mcoin = 6 * Math.Round(totalKm);
                else if (totalKm >= 50 && totalKm <= 100)
                    mcoin = 5 * Math.Round(totalKm);
                else if (totalKm >= 100)
                    mcoin = 4 * Math.Round(totalKm);
            }
        }
        public double mcoin { get; set; }
        public string distance_text { get; set; }
        public double duration { get; set; }
        public string duration_text { get; set; }
        public string description { get; set; }
        public List<InstructionInfo> instructions { get; set; }
    }
}
