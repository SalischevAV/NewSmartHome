using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.DeviceClasses;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using NewSmartHome.ServiceClasses;

namespace NewSmartHome.FileOperations
{
    class BinaryOperations : IFileOperations
    {
       // public Dictionary<string, Device> SmartHouseDevices { set; get; }

        public XmlSerializableDictionary<string, Device> LoadFromFile(string fileName)
        {
            XmlSerializableDictionary<string, Device> smartHouseDevices;
            try
            {
                BinaryFormatter myBin = new BinaryFormatter();

                using (Stream myFStream = File.OpenRead(fileName))
                {
                    smartHouseDevices = (XmlSerializableDictionary<string, Device>)myBin.Deserialize(myFStream);
                }
            }

            catch
            {
                smartHouseDevices = new XmlSerializableDictionary<string, Device>();
            }

            return smartHouseDevices;


        }

        public string SaveToFile(XmlSerializableDictionary<string, Device> smartHouseDevices, string fileName)
        {
            try
            {
                BinaryFormatter myBin = new BinaryFormatter();
                using (Stream myFStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                {
                    myBin.Serialize(myFStream, smartHouseDevices);
                }
                return "Smart house save in binary format";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
