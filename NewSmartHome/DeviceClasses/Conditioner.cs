using NewSmartHome.DeviceInterfaces;
using NewSmartHome.Enums;
using NewSmartHome.Interfaces;
using NewSmartHome.LowLevelClasses;
using NewSmartHome.LowLevelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    public class Conditioner : Device, IFridgeable, IModeable
    {
        public ITemperatureable Compressor { set; get; }
        public IFanable ColdFan { set; get; }

        public int Temp
        {
            set
            {
                if (value <= 30 && value >= 16) { Temp = value; }
            }
            get { return Temp; }
        }
        public FanSpeed FanMode { set; get; }

        public string SetMode (string setting)
        {
            if (State)
            {
                switch (setting)
                {
                    case "slow":
                        FanMode = ColdFan.SetSpeedFan("slow");
                        return "conditioner fan speed set: " + FanMode;
                    case "medium":
                        FanMode = ColdFan.SetSpeedFan("medium");
                        return "conditioner fan speed set: " + FanMode;
                    case "hight":
                        FanMode = ColdFan.SetSpeedFan("hight");
                        return "conditioner fan speed set: " + FanMode;
                }
            }
            FanMode = ColdFan.SetSpeedFan("off");
            return "conditioner fan speed set: " + FanMode;
        }

        public string SetTemp(int settingTemp)
        {
            Temp = Compressor.SetTemp(settingTemp);
            return "conditioner temperature set: " + Temp;
        }

        public string IncrTemp()
        {
            Temp++;
            return "conditioner temperature set: " + Temp;

        }

        public string DecrTemp()
        {
            Temp--;
            return "conditioner temperature set: " + Temp;
        }
    }
}
