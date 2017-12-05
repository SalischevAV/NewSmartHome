using NewSmartHome.DeviceClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.ServiceClasses;

namespace NewSmartHome.FileOperations
{
    interface IFileOperations
    {
         //Dictionary<string, Device> SmartHouseDevices { get; set; }

        string SaveToFile(XmlSerializableDictionary<string, Device> smartHome, string fileName);

        XmlSerializableDictionary<string, Device> LoadFromFile(string fileName);
    }
}
