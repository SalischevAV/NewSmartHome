using System;
using NewSmartHome.DeviceClasses;
using NewSmartHome.Factory;
using NewSmartHome.Interfaces;
using NewSmartHome.LowLevelDeviceFactory.Brightnes;

namespace NewSmartHome.DeviceFactory
{
    class OvenCreator: DeviceCreator
    {
        protected IBrightnesable lamp;

        public CreateIBrightnesable LampCreate { set; get; }

        public OvenCreator(CreateIBrightnesable lampCreate)
        {
            LampCreate = lampCreate;
            lamp = LampCreate.Create();
        }

        public override Device CreateDevice()
        {
            return new Oven(lamp);
        }
    }
}
