using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceInterfaces
{
    public interface IChanneable
    {
        int Channel { set; get; }
        string SetChannel(int settingChannel);
        string AdjustChannel(bool increase);
}
}
