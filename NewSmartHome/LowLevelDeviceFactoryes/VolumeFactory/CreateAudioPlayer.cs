using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.LowLevelInterfaces;
using NewSmartHome.LowLevelClasses;

namespace NewSmartHome.LowLevelDeviceFactoryes.VolumeFactory
{
    class CreateAudioPlayer : CreateIVolumeable
    {
        public override ILowLevelVolumeable Create()
        {
            return new AudioPlayer();
        }
    }
}
