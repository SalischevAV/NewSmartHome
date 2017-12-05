using NewSmartHome.LowLevelInterfaces;
using NewSmartHome.LowLevelClasses;

namespace NewSmartHome.LowLevelDeviceFactoryes.FanFactory
{
    class CreateFan : CreateIFanable
    {
        public override IFanable Create()
        {
            return new Fan();
        }
    }
}
