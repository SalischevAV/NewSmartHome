using NewSmartHome.Enums;

namespace NewSmartHome.LowLevelInterfaces
{
    public interface IFanable
    {
        FanMode SpeedFan { set; get; }
        FanMode SetSpeedFan(string setting);

    }
}
