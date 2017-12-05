using NewSmartHome.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.DeviceClasses;
using NewSmartHome.DeviceInterfaces;
using NewSmartHome.LowLevelDeviceFactoryes.VolumeFactory;
using NewSmartHome.LowLevelInterfaces;

namespace NewSmartHome.DeviceFactory
{
    class RadioCreator : DeviceCreator
    {
        protected ILowLevelVolumeable audioController;

        public CreateIVolumeable CreateAudioPlayer { set; get; }

        public RadioCreator(CreateIVolumeable createAudioPlayer)
        {
            CreateAudioPlayer = createAudioPlayer;
            audioController = CreateAudioPlayer.Create();
        }

        public override Device CreateDevice()
        {
            return new Radio(audioController);
        }
    }
}
