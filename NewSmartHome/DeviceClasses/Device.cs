using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    public abstract class Device
    {
       
        public virtual bool State { set; get; }
        
        public virtual string Power()
        {
            State = !State;
            return this.GetType() + "POWER" + State;
        }

        public override string ToString()
        {
            return Convert.ToString(this.GetType())+ ", power: " + State;
        }
    }
}
