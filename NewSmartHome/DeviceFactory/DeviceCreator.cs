using NewSmartHome.DeviceClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.Factory
{
    abstract class DeviceCreator
    {
        public abstract Device CreateDevice();
       
    }
}
