using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    public class SoundDeviceObject : DeviceObject
    {
        public SoundDeviceObject()
        {
            _deviceType = DeviceType.SoundDevice;
        }
    }
}
