using NewSmartHome.Interfaces;
using NewSmartHome.LowLevelDeviceFactory.Brightnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSmartHome.DeviceClasses;
using NewSmartHome.LowLevelDeviceFactoryes.VolumeFactory;

namespace NewSmartHome.DeviceFactory
{
    class RadioLampCreator: RadioCreator    
    {
        protected IBrightnesable rlamp;

        public CreateIBrightnesable RlampCreator { set; get; }
        public RadioLampCreator(CreateIVolumeable createAudioPlayer, CreateIBrightnesable rlampCreator):base(createAudioPlayer)
        {
            RlampCreator = rlampCreator;
            rlamp = RlampCreator.Create();
        }

        public override Device CreateDevice()
        {
            return new RadioLamp(audioController, rlamp);
        }
    }
}
