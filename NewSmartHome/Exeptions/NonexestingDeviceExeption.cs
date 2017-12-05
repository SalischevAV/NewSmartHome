using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.Exeption
{
    class NonexestingDeviceExeption:Exception
    {
        public NonexestingDeviceExeption(string message): base(message)
        {
                
        }
    }
}
