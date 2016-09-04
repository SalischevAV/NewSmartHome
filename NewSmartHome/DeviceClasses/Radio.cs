﻿using NewSmartHome.DeviceInterfaces;
using NewSmartHome.LowLevelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.DeviceClasses
{
    public class Radio : Device, IVolumeable, IChannelable
    {
        public ILowLevelVolumeable SoundController { set; get; }
        public int Volume { set; get; }
        private int channel;
        public int Channel
        {
            set
            {
                if (value <= 100 && value > 0)
                {
                    channel = value;
                }

            }
            get { return channel; }
        }

        public string SetChannel(int settingChannel)
        {
            Channel = settingChannel;
            return "channel set:" + Channel;
        }
        public string AdjustChannel(bool increase)
        {
            if (increase == true)
            {
                ++Channel;
                return "channel set: " + Channel;
            }
            else
            {
                --Channel;
                return "channel set: " + Channel;
            }
        }

        public string SetVolume(bool increase)
        {
            Volume = SoundController.AdjustVolume(increase);
            return "volume level set: " + Volume;
        }
    }
}
