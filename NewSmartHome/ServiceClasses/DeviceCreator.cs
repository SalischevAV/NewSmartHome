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
        
        public Device NewDevice { set; get; }
        // public string[] deviceClasses = Directory.GetFiles(@"C:\Users\Lena\Source\Repos\NewSmartHome\NewSmartHome\DeviceClasses");
        public DirectoryInfo device = Directory.GetParent(@".");
        

        




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

