using System;
using System.Management;
using SystemInfo.DeviceObject;

namespace SystemInfo
{
    /// <summary> Клас інформації про процесори. </summary>
    public class SoundDeviceInfo : DeviceInfo, IDeviceInfo<SoundDeviceObject>
    {
        public SoundDeviceInfo()
            : base("SELECT * FROM Win32_SoundDevice")
        {
            if (_devices.Count > 0)
            {
                _devicesInfo = new SoundDeviceObject[_devices.Count];
                int i = 0;
                foreach (ManagementObject soundDevice in _devices)
                {
                    SoundDeviceObject soundDeviceObject = new SoundDeviceObject();
                    try
                    {
                        soundDeviceObject.Caption = GetFormatValue(soundDevice["Caption"]);
                        soundDeviceObject.Description = GetFormatValue(soundDevice["Description"]);
                        soundDeviceObject.DeviceId = GetFormatValue(soundDevice["DeviceId"]);
                        soundDeviceObject.Name = GetFormatValue(soundDevice["Name"]);
                        soundDeviceObject.Status = GetFormatValue(soundDevice["Status"]);

                        _devicesInfo[i++] = soundDeviceObject;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(String.Format("Processor data can't load. {0}", ex.Message));
                    }
                }
            }
        }

        public new SoundDeviceObject[] Instance
        {
            get
            {
                return _devicesInfo as SoundDeviceObject[];
            }
        }
    }
}
