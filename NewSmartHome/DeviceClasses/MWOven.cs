using NewSmartHome.Enums;
using NewSmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    public class MWOven : Oven, IModeable
    {
        public MWOvenMode MWMode { set; get; }
        public string SetMode(string setting)
        {
            switch (setting)
            {
                case "defrost":
                    MWMode = MWOvenMode.Defrost;
                    return "mw-oven mode set: " + MWMode;
                case "easy":
                    MWMode = MWOvenMode.Easy;
                    return "mw-oven mode set: " + MWMode;
                case "grill":
                    MWMode = MWOvenMode.Grill;
                    return "mw-oven mode set: " + MWMode;
                case "normal":
                default:
                    MWMode = MWOvenMode.Normal;
                    return "mw-oven mode set: " + MWMode;
            }
        }
    }
}
