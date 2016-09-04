using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceInterfaces
{
   
    public interface IDoorable
    {
        bool Door { set; get; }
        string DoorManipulation();
    }
}
