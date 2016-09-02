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
        public Lamp() { } //ctor for XML-serializable
        public Lamp(bool state, LampMode mode) //ctor for injection
        {
            State = state;
            Brightness = mode;
        }
        

        public LampMode Brightness { set; get; }
       

        public string SetBrightness(string setting)
        {
            if (State)
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
                        Brightness = LampMode.Bright;
                        return "lamp mode set BRIGHT";
                    case "dark":
                    default:
                        Brightness = LampMode.Dark;
                        return "lamp mode set DARK";
                }
            }
            else return "Can't change mode - lamp is POWER OFF";

        }
    }
}
