using NewSmartHome.DeviceClasses;
using NewSmartHome.ServiceClasses;
using NewSmartHome.UI;
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
            Radio r = new Radio();
            Oven o = new Oven();
            Fridge fr = new Fridge();
            Conditioner cond = new Conditioner();
            MWOven mw = new MWOven();

            //ConsoleUIDevice cui = new ConsoleUIDevice();
            //cui.actWithDevice += WriteLogToFile.WriteLog;
            ////cui.ControlWithIChannelable(r);
            ////cui.ControlWithIDoorable(o);
            //cond.State = true;
            //cui.ControlWithModeable(cond);

            DeviceCreator dc = new DeviceCreator(@"D:\projects\Git\NewSmartHome\NewSmartHome\DeviceClasses\");
            dc.GetavAilableClasses();
            foreach (string s in dc.deviceClasses)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("--------------------");
            //Console.WriteLine(dc.device);
            Console.WriteLine(fr.GetType().Name);
            Console.WriteLine("press any key");
            Console.ReadLine();

        }

    }
}
