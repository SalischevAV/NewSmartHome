using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Type t = this.GetType();
            string info = Convert.ToString(t) + ". ";
            PropertyInfo[] propertyArr = t.GetProperties();

            foreach (PropertyInfo pInf in propertyArr)
            {
                info += pInf.Name + " - ";
                info += pInf.PropertyType + "; ";
            }
            return info;
        }
    }
}
