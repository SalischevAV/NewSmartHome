using NewSmartHome.Enums;
using NewSmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    public class Fridge : Device, IModeable
    {
        public IBrightnesable FridgeLamp { set; get; }
        public FridgeMode Mode { set; get; }
        public ColdGenerator Compressor { set; get; }
        public int Temp
        {
            set
            {
                if ((Mode == FridgeMode.extraCold) && (value <= -10 && value > -20))
                { Temp = value; }
                else if ((Mode == FridgeMode.cold) && (value <= -5 && value >= -9))
                { Temp = value; }
                else if ((Mode == FridgeMode.defrost) && (value > -5 && value <= 0))
                { Temp = value; }
            }
        }


        public string SetMode(string setting)
        {
            switch (setting)
            {
                case "extra":
                    Mode = FridgeMode.extraCold;
                    return "fridge mode set EXTRACOLD";
                case "cold":
                    Mode = FridgeMode.cold;
                    return "fridge mode set COLD";
                case "hot":
                default:
                    Mode = FridgeMode.defrost;
                    return "fridge mode set DEFROST";
            }
        }

        public void SetTemp(int settingTemp)
        {
            Temp = Compressor.SetTemp(settingTemp); 
        }

        public void IncrTemp()
        {
            Temp = Compressor.IncrTemp();
        }

        public void DecrTemp()
        {
            Temp = Compressor.DecrTemp();
        }
    }
}
