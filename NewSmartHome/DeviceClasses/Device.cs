using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    public abstract class Device
    {
       
        public bool State { set; get; }
        
        public void Power()
        {
            State = !State;
        }

        public override string ToString()
        {
            return Convert.ToString(this.GetType())+ ", power: " + State;
        }
    }
}
