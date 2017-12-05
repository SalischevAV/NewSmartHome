using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.DeviceClasses;
using NewSmartHome.ServiceClasses;
using System.Runtime.Serialization.Json;
using System.IO;

namespace NewSmartHome.FileOperations
{
    class JSONOperations : IFileOperations
    {
        public XmlSerializableDictionary<string, Device> LoadFromFile(string fileName)
        {
            XmlSerializableDictionary<string, Device> smartHouseDevices;
            try
            {
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(XmlSerializableDictionary<string, Device>));
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    smartHouseDevices = (XmlSerializableDictionary<string, Device>)js.ReadObject(fs);
                }
            }

            catch
            {
                smartHouseDevices = new XmlSerializableDictionary<string, Device>();
            }

            return smartHouseDevices;
        }

        public string SaveToFile(XmlSerializableDictionary<string, Device> smartHome, string fileName)
        {

            try
            {
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(XmlSerializableDictionary<string, Device>));
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    js.WriteObject(fs, smartHome);
                }
                Console.WriteLine("Smart house save in JSON format");
                return "Smart house save in JSON format";
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}
