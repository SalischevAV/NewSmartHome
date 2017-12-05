using NewSmartHome.Enums;
using NewSmartHome.LowLevelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.LowLevelClasses
{
    [Serializable]
    [DataContract]
    public class Fan: IFanable
    {
        [DataMember]
        public FanMode SpeedFan { set; get; }
        public FanMode SetSpeedFan(string setting)
        {
            switch (setting)
            {
                case "slow":
                    SpeedFan = FanMode.slow;
                    return SpeedFan;
                case "medium":
                    SpeedFan = FanMode.medium;
                    return SpeedFan;
                case "hight":
                    SpeedFan = FanMode.hight;
                    return SpeedFan;
                default:
                    SpeedFan = FanMode.off;
                    return SpeedFan;
            }

        }

    }
}
