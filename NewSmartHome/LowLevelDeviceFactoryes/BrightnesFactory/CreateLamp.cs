using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.Interfaces;
using NewSmartHome.DeviceClasses;

namespace NewSmartHome.LowLevelDeviceFactory.Brightnes
{
    class CreateLamp : CreateIBrightnesable
    {
        public override IBrightnesable Create()
        {
            return new Lamp();
        }
    }
}
