using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceInterfaces
{
    public interface IFridgeable
    {
        int Temp { set; get; }
        string SetTemp(int settingTemp);
        string IncrTemp();
        string DecrTemp();
    }
}
