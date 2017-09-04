using System;
using System.Management;
using SystemInfo.DeviceObject;

namespace SystemInfo
{
    /// <summary> Клас інформації про процесори. </summary>
    public class VideoControllerInfo : DeviceInfo, IDeviceInfo<VideoControllerObject>
    {
        public VideoControllerInfo()
            :base("SELECT * FROM Win32_VideoController")
        {
            if (_devices.Count > 0)
            {
                _devicesInfo = new VideoControllerObject[_devices.Count];
                int i = 0;

                foreach (ManagementObject videoController in _devices)
                {
                    VideoControllerObject videoControllerObject = new VideoControllerObject();
                    try
                    {
                        videoControllerObject.Caption = GetFormatValue(videoController["Caption"]);
                        videoControllerObject.Description = GetFormatValue(videoController["Description"]);
                        videoControllerObject.DeviceId = GetFormatValue(videoController["DeviceId"]);
                        videoControllerObject.Name = GetFormatValue(videoController["Name"]);
                        videoControllerObject.Status = GetFormatValue(videoController["Status"]);

                        videoControllerObject.AdapterCompatibility = GetFormatValue(videoController["AdapterCompatibility"]);
                        videoControllerObject.AdapterDACType = GetFormatValue(videoController["AdapterDACType"]);
                        videoControllerObject.AdapterRAM = GetFormatValue(videoController["AdapterRAM"]);
                        videoControllerObject.Availability = GetFormatValue(videoController["Availability"]);
                        videoControllerObject.DriverVersion = GetFormatValue(videoController["DriverVersion"]);
                        videoControllerObject.VideoArchitecture = GetFormatValue(videoController["VideoArchitecture"]);
                        videoControllerObject.VideoMemoryType = GetFormatValue(videoController["VideoMemoryType"]);
                        videoControllerObject.VideoProcessor = GetFormatValue(videoController["VideoProcessor"]);

                        _devicesInfo[i++] = videoControllerObject;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(String.Format("VideoController data can't load. {0}", ex.Message));
                    }
                }
            }
        }

        public new VideoControllerObject[] Instance
        {
            get
            {
                return _devicesInfo as VideoControllerObject[];
            }
        }
    }
}
