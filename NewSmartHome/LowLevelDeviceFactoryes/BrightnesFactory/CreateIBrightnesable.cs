using NewSmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.LowLevelDeviceFactory.Brightnes
{
    abstract class CreateIBrightnesable
    {
        public abstract IBrightnesable Create();
    }
}
