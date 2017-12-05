using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.Interfaces;
using NewSmartHome.DeviceClasses;

namespace NewSmartHome.LowLevelDeviceFactoryes.TemperatureFactory
{
    class CreateColdGenerator : CreateITemperatureable
    {
        public override ITemperatureable Create()
        {
            return new ColdGenerator();
        }
    }
}
