using NewSmartHome.Enums;
using NewSmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    public class Lamp : IBrightnesable
    {
        public Lamp() { } //ctor for XML-serializable
        public Lamp(bool state, LampMode mode) //ctor for injection
        {
            Brightness = mode;
        }


        public LampMode Brightness { set; get; }


        public LampMode SetBrightness(string setting)
        {

            switch (setting)
            {
                case "dim":
                    Brightness = LampMode.Dim;
                    return Brightness;
                case "medium":
                    Brightness = LampMode.MediumBright;
                    return Brightness;
                case "hight":
                    Brightness = LampMode.Bright;
                    return Brightness;
                case "off":
                default:
                    Brightness = LampMode.Off;
                    return Brightness;
            }


        }
    }
}
