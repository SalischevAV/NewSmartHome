using NewSmartHome.Enums;
using NewSmartHome.LowLevelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.LowLevelClasses
{
    public class Fan: IFanable
    {
        public FanSpeed SpeedFan { set; get; }
        public FanSpeed SetSpeedFan(string setting)
        {
            switch (setting)
            {
                case "slow":
                    SpeedFan = FanSpeed.slow;
                    return SpeedFan;
                case "medium":
                    SpeedFan = FanSpeed.medium;
                    return SpeedFan;
                case "hight":
                default:
                    SpeedFan = FanSpeed.hight;
                    return SpeedFan;


            }

        }

    }
}
