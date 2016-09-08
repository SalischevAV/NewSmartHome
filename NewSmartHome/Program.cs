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

            ConsoleUIDevice cui = new ConsoleUIDevice();
            cui.actWithDevice += WriteLogToFile.WriteLog;
            //cui.ControlWithIChannelable(r);
            //cui.ControlWithIDoorable(o);
            cond.State = true;
            cui.ControlWithModeable(cond);



            Console.WriteLine("press any key");
            Console.ReadLine();

        }

    }
}
