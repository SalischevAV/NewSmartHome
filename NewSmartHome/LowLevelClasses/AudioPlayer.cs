using NewSmartHome.LowLevelInterfaces;
using System;
using System.Runtime.Serialization;

namespace NewSmartHome.LowLevelClasses
{
    [Serializable]
    [DataContract]
    class AudioPlayer: ILowLevelVolumeable
    {
        private int volLevel;
        [DataMember]
         public int VolLevel
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volLevel = value;
                }

            }
            get
            {
                return volLevel;
            }
        }
  
        public int AdjustVolume(bool increase)
        {
            if (increase == true)
            {
                ++VolLevel;
                return VolLevel;
            }
            else
            {
                --VolLevel;
                return VolLevel;
            }
        }

       
    }
}
