using NewSmartHome.Enums;
using NewSmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    public class Lamp : Device, IBrightnesable
    {
        public LampMode Brightness { set; get; }

        public string SetBrightness(string setting)
        {
            switch (setting)
            {
                case "dim":
                    Brightness = LampMode.Dim;
                    return "lamp mode set DIM";
                case "medium":
                        Brightness = LampMode.MediumBright;
                    return "lamp mode set MEDIUM";
                case "hight":
                default:
                    Brightness = LampMode.Bright;
                    return "lamp mode set BRIGHT";


            }

        }
    }
}
