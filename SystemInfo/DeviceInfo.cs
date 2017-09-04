using System;
using System.Management;
using SystemInfo.DeviceObject;

namespace SystemInfo
{
    public class DeviceInfo : IDeviceInfo
    {
        /// <summary> З'єднання з базою даних з інформацією про пристрій. </summary>
        protected ManagementObjectSearcher _connection;
        /// <summary> Колекція пристроїв отриманих по з'єднанні _connection. </summary>
        protected ManagementObjectCollection _devices;
        /// <summary> Список пристроїв певного типу. </summary>
        protected object[] _devicesInfo;

        protected DeviceInfo(string connect)
        {
            _connection = new ManagementObjectSearcher(connect);
            try
            {
                _devices = _connection.Get();
            }
            catch (Exception ex)
            {
                throw new Exception("Can't get data!\n" + ex.Message);
            }
        }

        public DeviceInfo(DeviceType type)
        {
            IDeviceInfo instance;
            switch (type)
            {
                case DeviceType.Processor:
                    instance = new ProcessorInfo();
                    break;
                case DeviceType.SoundDevice:
                    instance = new SoundDeviceInfo();
                    break;
                case DeviceType.VideoController:
                    instance = new VideoControllerInfo();
                    break;
                case DeviceType.PhysicalMemory:
                    instance = new PhysicalMemoryInfo();
                    break;
                case DeviceType.DiskDrive:
                    instance = new DiskDriveInfo();
                    break;
                case DeviceType.BIOS:
                    throw new ArgumentException();
                case DeviceType.LogicalDisk:
                    instance = new LogicalDiskInfo();
                    break;
                case DeviceType.NetworkAdapter:
                    instance = new NetworkAdapterInfo();
                    break;
                default:
                    throw new ArgumentException();
            }
            _connection = instance.Connect;
            _devicesInfo = instance.Instance;
        }

        public ManagementObjectSearcher Connect
        {
            get
            {
                return _connection;
            }
        }

        public DeviceObject.DeviceObject[] Instance
        {
            get
            {
                return _devicesInfo as DeviceObject.DeviceObject[];
            }
        }

        protected virtual string GetFormatValue(object properity)
        {
            try
            {
                if (properity != null)
                {
                    return properity.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(String.Format("Error in get properity value: {0}", ex.Message));
            }
        }
    }
}
