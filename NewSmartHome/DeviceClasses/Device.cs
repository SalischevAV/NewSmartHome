using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    [Serializable]
    [DataContract]
    public abstract class Device
    {
        [DataMember]//???
        public virtual bool State { set; get; }
        
        public virtual string Power()
        {
            State = !State;
            return this.GetType() + "POWER" + State;
        }

        public override string ToString()
        {
            return this.GetType().Name + ". State device: " + State+ ".";
        }

    }
}
