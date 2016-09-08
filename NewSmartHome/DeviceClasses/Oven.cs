using NewSmartHome.DeviceInterfaces;
using NewSmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    [Serializable]
    public class Oven : Device, IDoorable, IFridgeable
    {
        public IBrightnesable OvenLamp { set; get; }
        public bool Door { set; get; }
        public int Temp
        {
            set  {  if (value <= 400 && value >= 180) { Temp = value; } }
            get { return Temp; }
        }

        public string DecrTemp()
        {
            Temp--;
            return "oven temperature set: " + Temp;
        }

        public string IncrTemp()
        {
            Temp++;
            return "oven temperature set: " + Temp;
        }

        public string SetTemp(int settingTemp)
        {
            Temp = settingTemp;
            return "oven temperature set: " + Temp;
        }

        public string DoorManipulation()
        {
            Door = !Door;
            if (State)
            {
                if (Door) { OvenLamp.SetBrightness("medium"); }
                else { OvenLamp.SetBrightness("off"); }
            }
            return "Door: " + Door;
        }

    }
}
