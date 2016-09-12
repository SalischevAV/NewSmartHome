using NewSmartHome.DeviceClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.ServiceClasses
{
    public class DeviceCreator
    {
        public string Path { set; get; }

        public string[] deviceClasses { set; get; }
        public Device NewDevice { set; get; }
        public DeviceCreator(string path)
        {
            Path = path;
        }
        public void GetavAilableClasses()
        {

            deviceClasses = Directory.GetFiles(Path);
            for (int i = 0; i < deviceClasses.Length; i++)
            {
                deviceClasses[i] = deviceClasses[i].TrimStart(Path.ToCharArray());
                deviceClasses[i] = deviceClasses[i].TrimEnd(".cs".ToCharArray());
            }
            deviceClasses.OrderBy(dCl => dCl);
        }

        public Device CreateDevice(string name, string typeOfDevice)
        {
            string s = Console.ReadLine();
            Device sameDevice = new s ();
            return sameDevice;
        }








        //public Device CreateDevice(string TypeOfDevice)
        //{
        //    switch (TypeOfDevice)
        //    {
        //        case ("fridge"):
        //            NewDevice = new Fridge();
        //            //NewDevice.deviceNotificator += ServiceMessages.Message;
        //            return NewDevice;
        //        case ("conditioner"):
        //            NewDevice = new Conditioner();
        //            return NewDevice;
        //        case ("radio"):
        //        default:
        //            NewDevice = new Radio();
        //            return NewDevice;



        //    }
    }
}

