using NewSmartHome.DeviceClasses;
using NewSmartHome.DeviceFactory;
using NewSmartHome.DeviceInterfaces;
using NewSmartHome.Exeption;
using NewSmartHome.Factory;
using NewSmartHome.FileOperations;
using NewSmartHome.Interfaces;
using NewSmartHome.LowLevelDeviceFactory.Brightnes;
using NewSmartHome.LowLevelDeviceFactoryes.FanFactory;
using NewSmartHome.LowLevelDeviceFactoryes.TemperatureFactory;
using NewSmartHome.LowLevelDeviceFactoryes.VolumeFactory;
using NewSmartHome.ServiceClasses;
using NewSmartHome.UI;
using Refrigerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewSmartHome
{
    class Program
    {
        protected IFileOperations fOp = new BinaryOperations();


        static void Main(string[] args)
        {
            ConsoleUIDevice myUI = new ConsoleUIDevice();


            XmlSerializableDictionary<string, Device> smartHoseDevices = new XmlSerializableDictionary<string, Device>();

            new BinaryOperations().SaveToFile(smartHoseDevices, "sh.bin");

            //Dictionary<string, Device> smartHoseDevices = new Dictionary<string, Device>();

            //smartHoseDevices.Add("nord", myDCreator.CreateDevice("fridge"));

            //smartHoseDevices.Add("mitsubishi", myDCreator.CreateDevice("conditioner"));

            //smartHoseDevices.Add("spidola", myDCreator.CreateDevice("radio"));

            //smartHoseDevices.Add("indesit", myDCreator.CreateDevice("oven"));

            //smartHoseDevices.Add("siemens", myDCreator.CreateDevice("mwoven"));

            //smartHoseDevices.Add("seiko", myDCreator.CreateDevice("radiolamp"));

            while (true)
            {//while (true)
                Console.WriteLine("Манипуляции с выключенными устройствами НЕВОЗМОЖНЫ!\nПроверяйте статус устройства.");
                foreach (var s in smartHoseDevices)
                {
                    Console.WriteLine(s.Key + "-" + s.Value);

                }
                Console.WriteLine();
                Console.Write("Enter command: ");

                string[] commands = Console.ReadLine().ToLower().Split(' ');


                switch (commands[0])
                {

                    case "file":
                        SaveLoadMenu(smartHoseDevices);
                        break;

                    case "exit":

                        return;

                    case "add":
                        try
                        {
                            smartHoseDevices.Add(commands[1], AddDevice(commands[2]));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadKey();
                        }
                        break;
                    case "del":
                        smartHoseDevices.Remove(commands[1]);
                        break;

                    case "power":
                        var res = smartHoseDevices.Where(s => s.Key == commands[1]);
                        foreach (var device in res)
                        { device.Value.Power(); }
                        break;

                    case "modework":
                        var res1 = smartHoseDevices.Where(s => s.Key == commands[1] && s.Value is IModeable);
                        foreach (var device in res1)
                        {
                            myUI.ControlWithModeable((IModeable)device.Value);

                        }//тут неясно как сообщить о несуществующем интерфейсе
                        break;

                    case "controlvolume":
                        var res2 = smartHoseDevices.Where(s => s.Key == commands[1]);
                        foreach (var device in res2)
                        {
                            if (device.Value is IVolumeable)
                            {
                                myUI.ControlWithVolumeable((IVolumeable)device.Value);
                            }
                            else
                            {
                                Console.WriteLine("Device does not have such a function!\nPress any key");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case "controlchannel":
                        var res3 = smartHoseDevices.Where(s => s.Key == commands[1]);
                        foreach (var device in res3)
                        {
                            if (device.Value is IChannelable)
                            {
                                myUI.ControlWithIChannelable((IChannelable)device.Value);
                            }
                            else
                            {
                                Console.WriteLine("Device does not have such a function!\nPress any key");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case "controltemp":
                        var res4 = smartHoseDevices.Where(s => s.Key == commands[1]);
                        foreach (var device in res4)
                        {
                            if (device.Value is IFridgeable)
                            {
                                myUI.ControlWithFridgeable((IFridgeable)device.Value);
                            }
                            else
                            {
                                Console.WriteLine("Device does not have such a function!\nPress any key");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case "controlbrightness":
                        var res5 = smartHoseDevices.Where(s => s.Key == commands[1]);
                        foreach (var device in res5)
                        {
                            if (device.Value is ILightable)
                            {
                                myUI.ControlWithLightable((ILightable)device.Value);
                            }
                            else
                            {
                                Console.WriteLine("Device does not have such a function!\nPress any key");
                                Console.ReadKey();
                            }
                        }
                        break;


                    case "door":
                        var res6 = smartHoseDevices.Where(s => s.Key == commands[1]);
                        foreach (var device in res6)
                        {
                            if (device.Value is IDoorable)
                            {
                                myUI.ControlWithIDoorable((IDoorable)device.Value);
                            }
                            else
                            {
                                Console.WriteLine("Device does not have such a function!\nPress any key");
                                Console.ReadKey();
                            }
                        }
                        break;




                    default:
                        Help();
                        break;

                }


            }//while (true)
        }
        private static void Help()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Доступные типы устройств:");
            Console.WriteLine("fridge, conditioner, radio, radiolamp, oven, mwoven");
            Console.WriteLine("**********************");
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("\tAdd NameOfDevice TypeOfDevice");
            Console.WriteLine("\tDel NameOfDevice");
            Console.WriteLine("\tPower NameOfDevice");

            Console.WriteLine("\tModeWork NameOfDevice");
            Console.WriteLine("\tControlVolume NameOfDevice");
            Console.WriteLine("\tControlChannel NameOfDevice");
            Console.WriteLine("\tControlTemp NameOfDevice");
            Console.WriteLine("\tControlBrightness NameOfDevice");
            Console.WriteLine("\tDoor NameOfDevice");

            Console.WriteLine("\tFile(save or load)");
            Console.WriteLine("\tExit");
            Console.WriteLine("Press any key for continue");
            Console.ReadKey();
        }

        static void SaveLoadMenu(XmlSerializableDictionary<string, Device> myDict)
        {
            Console.Clear();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Enter command: ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "save":
                        new JSONOperations().SaveToFile(myDict, @"D:\SmartHouse.xml");                     
                        return;
                    case "load":
                        new XMLOperations().LoadFromFile("SmartHouse.xml");
                        foreach (var r in myDict)
                        {
                            Console.WriteLine(r);
                        }
                        return;
                    case "exit":
                        return;
                    default:
                        SaveLoadHelp();
                        break;
                }
            }

        }
        private static void SaveLoadHelp()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("\tSave Binary");
            Console.WriteLine("\tLoad Bimary");
            Console.WriteLine("\tJSON - в разработке");
            Console.WriteLine("\tXML - в разработке");
            Console.WriteLine("\texit");
            Console.WriteLine("Press any key for continue");
            Console.ReadKey();

        }

        private static Device AddDevice(string typeDevice)
        {
            DeviceCreator myDCreator;

            CreateIBrightnesable createLamp = new CreateLamp();
            CreateIFanable createFun = new CreateFan();
            CreateITemperatureable createCompressor = new CreateColdGenerator();
            CreateIVolumeable createPlayer = new CreateAudioPlayer();

            switch (typeDevice)
            {
                case "fridge":
                    myDCreator = new FridgeCreator(createCompressor, createLamp);
                    return (Fridge)myDCreator.CreateDevice();

                case "oven":
                    myDCreator = new OvenCreator(createLamp);
                    return (Oven)myDCreator.CreateDevice();

                case "mwoven":
                    myDCreator = new MWOvenCreator(createLamp);
                    return (MWOven)myDCreator.CreateDevice();

                case "conditioner":
                    myDCreator = new ConditionerCreator(createCompressor, createFun);
                    return (Conditioner)myDCreator.CreateDevice();

                case "radio":
                    myDCreator = new RadioCreator(createPlayer);
                    return (Radio)myDCreator.CreateDevice();

                case "radiolamp":
                    myDCreator = new RadioLampCreator(createPlayer, createLamp);
                    return (RadioLamp)myDCreator.CreateDevice();

                default:
                    throw new NonexestingDeviceExeption("Несуществующий тип устройств");

            }
        }


    }

}

