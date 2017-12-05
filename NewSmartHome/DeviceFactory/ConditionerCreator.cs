using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.DeviceClasses;
using NewSmartHome.Interfaces;
using NewSmartHome.LowLevelInterfaces;
using NewSmartHome.LowLevelDeviceFactoryes.TemperatureFactory;
using NewSmartHome.LowLevelDeviceFactoryes.FanFactory;

namespace NewSmartHome.Factory
{
    class ConditionerCreator : DeviceCreator
    {
        private ITemperatureable compressor;
        private IFanable coldFan;

        public CreateITemperatureable TempCreate { set; get; }
        public CreateIFanable FanCreate { set; get; }


        public ConditionerCreator(CreateITemperatureable tempCreate, CreateIFanable fanCreate)
        {
            TempCreate = tempCreate;
            FanCreate = fanCreate;
            compressor = TempCreate.Create();
            coldFan = FanCreate.Create();
        }
        public override Device CreateDevice()
        {
            return new Conditioner(compressor, coldFan);
        }

       
    }
}
