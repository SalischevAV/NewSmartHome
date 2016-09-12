using NewSmartHome.DeviceClasses;
using NewSmartHome.ServiceClasses;
using NewSmartHome.UI;
using Refrigerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Device> dict = new Dictionary<string, Device>();
            List<Device> smartHomeDevices = new List<Device>();
            Device newDevice = new Fridge();
            smartHomeDevices.Add(newDevice);
            dict.Add("name", newDevice);

            
            Console.WriteLine(newDevice.ToString());
            FileOperations fo = new FileOperations();
            fo.SaveXMLFormat("key.xml", "dev.xml", dict);



            Console.WriteLine("---------------");
            Console.WriteLine("press Enter");
            Console.ReadLine();

        }

    }
}
