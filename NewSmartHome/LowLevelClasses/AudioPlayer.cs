using NewSmartHome.LowLevelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSmartHome.LowLevelClasses
{
    class AudioPlayer: ILowLevelVolumeable
    {
         public int VolLevel
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    VolLevel = value;
                }

            }
            get
            {
                return VolLevel;
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
