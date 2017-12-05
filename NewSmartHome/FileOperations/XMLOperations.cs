using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.DeviceClasses;
using NewSmartHome.ServiceClasses;
using System.Xml.Serialization;
using System.IO;

namespace NewSmartHome.FileOperations
{
    class XMLOperations : IFileOperations
    {
        public XmlSerializableDictionary<string, Device> LoadFromFile(string fileName)
        {
            XmlSerializableDictionary<string, Device> smartHouseDevices;
            try
            {
                XmlSerializer myXml = new XmlSerializer(typeof(XmlSerializableDictionary<string, Device>));

                using (Stream myFStream = File.OpenRead(fileName))
                {
                    smartHouseDevices = (XmlSerializableDictionary<string, Device>)myXml.Deserialize(myFStream);
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
                XmlSerializer xs = new XmlSerializer(typeof(XmlSerializableDictionary<string, Device>));
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    xs.Serialize(fs, smartHome);
                }

                return "Smart house save in XML format";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
