using NewSmartHome.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.DeviceClasses;
using NewSmartHome.Interfaces;
using NewSmartHome.LowLevelDeviceFactoryes.TemperatureFactory;
using NewSmartHome.LowLevelDeviceFactory.Brightnes;

namespace NewSmartHome.DeviceFactory
{
    class FridgeCreator : DeviceCreator
    {
        private ITemperatureable compressor;
        private IBrightnesable lamp;

       public CreateITemperatureable CreateCompressor { set; get; }
        public CreateIBrightnesable CreateLamp { set; get; }

        public FridgeCreator(CreateITemperatureable createCompressor, CreateIBrightnesable createLamp)
        {
            CreateCompressor = createCompressor;
            CreateLamp = createLamp;
            compressor = CreateCompressor.Create();
            lamp = CreateLamp.Create();
        }
        public override Device CreateDevice()
        {
            return new Fridge(lamp, compressor);
        }
    }
}
