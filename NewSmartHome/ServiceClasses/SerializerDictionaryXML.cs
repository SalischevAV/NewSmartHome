using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NewSmartHome.DeviceClasses;
using System.Xml.Serialization;

namespace NewSmartHome.ServiceClasses
{
    public class SerializerDictionaryXML
    {

        private XmlSerializer keySerializer = new XmlSerializer(typeof(List<int>));
        private XmlSerializer deviceSerializer = new XmlSerializer(typeof(List<Device>));
        public Dictionary<int, Device> deserialazeDict { set; get; }
        public string PathKey { set; get; }
        public string PathDevice { set; get; }
        public SerializerDictionaryXML(string pathKey, string pathDevice)
        {
            PathDevice = pathDevice;
            PathKey = pathKey;
        }


        public string Serialaze(Dictionary<int, Device> dict)
        {
            List<int> listKeyDevice = new List<int>();
            List<Device> listDevice = new List<Device>();
            listKeyDevice.AddRange(dict.Keys);
            listDevice.AddRange(dict.Values);
            using (FileStream fs = new FileStream(PathKey, FileMode.OpenOrCreate))
            {
                keySerializer.Serialize(fs, listKeyDevice);
            }
            using (FileStream fs = new FileStream(PathDevice, FileMode.OpenOrCreate))
            {
                deviceSerializer.Serialize(fs, listDevice);
            }

            return "Dictionary Devices serialized to XML";

        }

        public string  Deserialaze ()
        {
            List<int> listKeyDevice = new List<int>();
            List<Device> listDevice = new List<Device>();

            using (FileStream fs = new FileStream(PathKey, FileMode.Open))
            {
                listKeyDevice = (List<int>)keySerializer.Deserialize(fs);
            }

            using (FileStream fs = new FileStream(PathDevice, FileMode.Open))
            {
                listDevice = (List<Device>)deviceSerializer.Deserialize(fs);
            }

            for (int i = 0; i <= listDevice.Capacity; i++)
            {
                deserialazeDict.Add(listKeyDevice[i], listDevice[i]);
            }


            return "Dictionary Devices deserialized from XML";
        }
    }
}
