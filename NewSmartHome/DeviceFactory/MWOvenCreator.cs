using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.DeviceClasses;
using NewSmartHome.LowLevelDeviceFactory.Brightnes;

namespace NewSmartHome.DeviceFactory
{
    class MWOvenCreator:OvenCreator
    {
        public MWOvenCreator(CreateIBrightnesable lampCreate):base(lampCreate)
        {

        }
        public override Device CreateDevice()
        {
            return new MWOven(lamp);
        }
    }
}
