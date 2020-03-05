using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers
{
    public class Localization
    {
        public static string GetDirection(string direction)
        {
            switch (direction)
            {
                case "N":
                    return "bắc";
                case "E":
                    return "đông";
                case "S":
                    return "nam";
                case "W":
                    return "tây";
                case "NE":
                    return "đông bắc";
                case "SE":
                    return "đông nam";
                case "SW":
                    return "tây nam";
                case "NW":
                    return "tây bắc";
            }
            return string.Empty;
        }

        public static string GetInstruction(string instruction, string exitStr, string dir, string road, string lang)
        {
            if (lang == "vi")
            {
                switch (instruction)
                {
                    case "Straight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Thẳng hướng {0}", dir);
                        }
                        return string.Format("Thẳng hướng {0} trên {1}", dir, road);

                    case "SlightRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Hướng sang phải");
                        }
                        return string.Format("Hướng sang phải để vào {0}", road);
                    case "Right":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Rẽ phải");
                        }
                        return string.Format("Rẽ phải để vào {0}", road);
                    case "SharpRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Ngoặt sang phải");
                        }
                        return string.Format("Ngoặt sang phải để vào {0}", road);

                    case "SharpLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Ngoặt trái");
                        }
                        return string.Format("Ngoặt trái để vào {0}", road);
                    case "Left":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Rẽ trái");
                        }
                        return string.Format("Rẽ trái để vào {0}", road);
                    case "SlightLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Hướng sang trái");
                        }
                        return string.Format("Hướng sang trái để vào {0}", road);
                    case "C_Straight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục thẳng hướng {0}", dir);
                        }
                        return string.Format("Tiếp tục thẳng hướng {0} trên {1}", dir, road);

                    case "C_SlightRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục hướng sang phải");
                        }
                        return string.Format("Tiếp tục hướng sang phải {0}", road);
                    case "C_Right":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục rẽ phải");
                        }
                        return string.Format("Tiếp tục rẽ phải {0}", road);
                    case "C_SharpRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục ngoặt sang phải");
                        }
                        return string.Format("Tiếp tục ngoặt sang phải {0}", road);

                    case "C_SharpLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục ngoặt trái");
                        }
                        return string.Format("Tiếp tục ngoặt trái {0}", road);
                    case "C_Left":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục rẽ trái");
                        }
                        return string.Format("Tiếp tục rẽ trái {0}", road);
                    case "C_SlightLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục hướng sang trái");
                        }
                        return string.Format("Tiếp tục hướng sang trái {0}", road);
                    case "Continue":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục hướng {0}", dir);
                        }
                        return string.Format("Tiếp tục hướng {0} trên {1}", dir, road);
                    case "TurnAround":
                        return "Quay đầu";
                    case "WaypointReached":
                        return "Hoàn thành lộ trình";
                    case "Roundabout":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Ra ở lối ra thứ {0} trên bùng binh", exitStr);
                        }
                        return string.Format("Ra ở lối ra thứ {0} trên bùng binh để vào {1}", exitStr, road);
                    case "DestinationReached":
                        return "Đến điểm đích";
                }
            }
            else if (lang == "en")
            {
                switch (instruction)
                {
                    case "Straight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Head {0}", dir);
                        }
                        return string.Format("Head {0} on {1}", dir, road);

                    case "SlightRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Slight right");
                        }
                        return string.Format("Slight right onto {0}", road);
                    case "Right":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Right");
                        }
                        return string.Format("Right onto {0}", road);
                    case "SharpRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Sharp right");
                        }
                        return string.Format("Sharp right onto {0}", road);

                    case "SharpLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Sharp left");
                        }
                        return string.Format("Sharp left onto {0}", road);
                    case "Left":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Left");
                        }
                        return string.Format("Left onto {0}", road);
                    case "SlightLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Slight left");
                        }
                        return string.Format("Slight left onto {0}", road);
                    case "C_Straight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue {0}", dir);
                        }
                        return string.Format("Continue {0} on {1}", dir, road);

                    case "C_SlightRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue slight right");
                        }
                        return string.Format("Continue slight right {0}", road);
                    case "C_Right":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue right");
                        }
                        return string.Format("Continue right {0}", road);
                    case "C_SharpRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue sharp right");
                        }
                        return string.Format("Continue sharp right {0}", road);

                    case "C_SharpLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue sharp left");
                        }
                        return string.Format("Continue sharp left {0}", road);
                    case "C_Left":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue left");
                        }
                        return string.Format("Continue left {0}", road);
                    case "C_SlightLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue slight left");
                        }
                        return string.Format("Continue slight left {0}", road);
                    case "Continue":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue {0}", dir);
                        }
                        return string.Format("Continue {0} on {1}", dir, road);
                    case "TurnAround":
                        return "Turn around";
                    case "WaypointReached":
                        return "Waypoint reached";
                    case "Roundabout":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Take the {0} exit in the roundabout", exitStr);
                        }
                        return string.Format("Take the {0} exit in the roundabout onto {1}", exitStr, road);
                    case "DestinationReached":
                        return "Destination reached";
                }
            }

            return string.Empty;
        }

        public static string GetInstruction2(string instruction, string exitStr, string dir, string road, string lang)
        {
            if (lang == "vi")
            {
                switch (instruction)
                {
                    case "Straight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return "Đi thẳng";
                        }
                        return string.Format("Đi thẳng {0}", road);

                    case "SlightRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Hướng sang phải");
                        }
                        return string.Format("Hướng sang phải để vào {0}", road);
                    case "Right":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Rẽ phải");
                        }
                        return string.Format("Rẽ phải để vào {0}", road);
                    case "SharpRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Ngoặt sang phải");
                        }
                        return string.Format("Ngoặt sang phải để vào {0}", road);

                    case "SharpLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Ngoặt trái");
                        }
                        return string.Format("Ngoặt trái để vào {0}", road);
                    case "Left":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Rẽ trái");
                        }
                        return string.Format("Rẽ trái để vào {0}", road);
                    case "SlightLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Hướng sang trái");
                        }
                        return string.Format("Hướng sang trái để vào {0}", road);
                    case "C_Straight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục đi thẳng");
                        }
                        return string.Format("Tiếp tục đi thẳng {0}", road);

                    case "C_SlightRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục hướng sang phải");
                        }
                        return string.Format("Tiếp tục hướng sang phải {0}", road);
                    case "C_Right":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục rẽ phải");
                        }
                        return string.Format("Tiếp tục rẽ phải {0}", road);
                    case "C_SharpRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục ngoặt sang phải");
                        }
                        return string.Format("Tiếp tục ngoặt sang phải {0}", road);

                    case "C_SharpLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục ngoặt trái");
                        }
                        return string.Format("Tiếp tục ngoặt trái {0}", road);
                    case "C_Left":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục rẽ trái");
                        }
                        return string.Format("Tiếp tục rẽ trái {0}", road);
                    case "C_SlightLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục hướng sang trái");
                        }
                        return string.Format("Tiếp tục hướng sang trái {0}", road);
                    case "Continue":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Tiếp tục đi thẳng");
                        }
                        return string.Format("Tiếp tục đi thẳng {0}", road);
                    case "TurnAround":
                        return "Quay đầu";
                    case "WaypointReached":
                        return "Hoàn thành lộ trình";
                    case "Roundabout":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Ra ở lối ra thứ {0} trên bùng binh", exitStr);
                        }
                        return string.Format("Ra ở lối ra thứ {0} trên bùng binh để vào {1}", exitStr, road);
                    case "DestinationReached":
                        return "Đến điểm đích";
                }
            }
            else if (lang == "en")
            {
                switch (instruction)
                {
                    case "Straight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return "Head";
                        }
                        return string.Format("Head {0}", road);

                    case "SlightRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Slight right");
                        }
                        return string.Format("Slight right onto {0}", road);
                    case "Right":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Right");
                        }
                        return string.Format("Right onto {0}", road);
                    case "SharpRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Sharp right");
                        }
                        return string.Format("Sharp right onto {0}", road);

                    case "SharpLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Sharp left");
                        }
                        return string.Format("Sharp left onto {0}", road);
                    case "Left":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Left");
                        }
                        return string.Format("Left onto {0}", road);
                    case "SlightLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Slight left");
                        }
                        return string.Format("Slight left onto {0}", road);
                    case "C_Straight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue head");
                        }
                        return string.Format("Continue head {0}", road);

                    case "C_SlightRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue slight right");
                        }
                        return string.Format("Continue slight right {0}", road);
                    case "C_Right":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue right");
                        }
                        return string.Format("Continue right {0}", road);
                    case "C_SharpRight":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue sharp right");
                        }
                        return string.Format("Continue sharp right {0}", road);

                    case "C_SharpLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue sharp left");
                        }
                        return string.Format("Continue sharp left {0}", road);
                    case "C_Left":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue left");
                        }
                        return string.Format("Continue left {0}", road);
                    case "C_SlightLeft":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue slight left");
                        }
                        return string.Format("Continue slight left {0}", road);
                    case "Continue":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Continue head");
                        }
                        return string.Format("Continue head {0}", road);
                    case "TurnAround":
                        return "Turn around";
                    case "WaypointReached":
                        return " Waypoint reached";
                    case "Roundabout":
                        if (string.IsNullOrEmpty(road))
                        {
                            return string.Format("Take the {0} exit in the roundabout", exitStr);
                        }
                        return string.Format("Take the {0} exit in the roundabout onto {1}", exitStr, road);
                    case "DestinationReached":
                        return "Destination reached";
                }
            }

            return string.Empty;
        }

        public static string FomatOrder(int n)
        {
            if (n == 0) return string.Empty;
            int i = n % 10 - 1;
            string[] suffix = new string[] { "st", "nd", "rd" };
            return (i <= suffix.Length - 1) ? n + suffix[i] : n + "th";
        }
    }
}
