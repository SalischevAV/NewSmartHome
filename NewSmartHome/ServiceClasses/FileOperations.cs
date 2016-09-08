using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;
using NewSmartHome.DeviceClasses;
using NewSmartHome.ServiceClasses;

namespace Refrigerator
{
    public class FileOperations
    {
        public static string SaveBinaryFormat(object smartHouse, string fileName)
        {
            BinaryFormatter myBin = new BinaryFormatter();
            using (Stream myFStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                myBin.Serialize(myFStream, smartHouse);
            }
            return "Smart house save in binary format";
            

        }

        public static string LoadFromBynaryFormat(string fileName)
        {
            BinaryFormatter myBin = new BinaryFormatter();
            using (Stream myFStream = File.OpenRead(fileName))
            {
                Device deviceFromBinaryFile = (Device)myBin.Deserialize(myFStream);
            }
            return "Smart house load from binary format";
        }

        //Начиная с .NET Framework 2.0, этот класс устарел.Взамен рекомендуется использовать BinaryFormatter.
        //public static string SaveSoapFormat(object smartHouse, string fileName)
        //{
        //    SoapFormatter myBin = new SoapFormatter();
        //    using (Stream myFStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
        //    {
        //        try
        //        {
        //            myBin.Serialize(myFStream, smartHouse);
        //            return "Smart house save in SOAP format";
        //        }
        //        catch (Exception ex)
        //        {
        //            return (ex.Message);
        //        }
        //    }


        //}

        //public static string LoadFromSOPAPFormat(string fileName)
        //{
        //    SoapFormatter myBin = new SoapFormatter();
        //    using (Stream myFStream = File.OpenRead(fileName))
        //    {
        //        Device deviceFromBinaryFile = (Device)myBin.Deserialize(myFStream);
        //    }
        //    return "Smart house load from SOAP format";
        //}

        public string SaveXMLFormat(string keysPath, string devicesPath, Dictionary<string, Device> dict)
        {
            SerializerDictionaryXML xml = new SerializerDictionaryXML(keysPath, devicesPath);
            xml.Serialaze(dict);
            return "Smart house save in XML format";

        }

        public string LoadFromXMLFormat (string keysPath, string devicesPath, Dictionary<string, Device> dict)

        {
            SerializerDictionaryXML xml = new SerializerDictionaryXML(keysPath, devicesPath);
            xml.Deserialaze();
            dict = xml.deserialazeDict;
            return "Smart house load from XML format";
        }
    }
}
