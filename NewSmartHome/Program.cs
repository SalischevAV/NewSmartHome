using NewSmartHome.DeviceClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge fr = new Fridge();
            //Console.WriteLine(fr.State);
            //fr.Power();
            //Console.WriteLine(fr.State);
            //List<Device> dv = new List<Device>();
            //dv.Add(fr);
            ////dv.Add(new Lamp());
            //foreach(Device dev in dv)
            //{
            //    dev.Power();
            //    Console.WriteLine(dev.State);
            //}

            Console.WriteLine(fr.ToString());



            Console.ReadLine();

        }

    }
}
