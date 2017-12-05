using NewSmartHome.LowLevelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.LowLevelDeviceFactoryes.VolumeFactory
{
    abstract class CreateIVolumeable
    {
        public abstract ILowLevelVolumeable Create();
    }
}
