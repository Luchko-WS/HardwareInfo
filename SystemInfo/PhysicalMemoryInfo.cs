using System;
using System.Management;
using SystemInfo.DeviceObject;

namespace SystemInfo
{
    public class PhysicalMemoryInfo : DeviceInfo, IDeviceInfo<PhysicalMemoryObject>
    {
        public PhysicalMemoryInfo()
            : base("SELECT * FROM Win32_PhysicalMemory")
        {
            if (_devices.Count > 0)
            {
                _devicesInfo = new PhysicalMemoryObject[_devices.Count];
                int i = 0;
                foreach (ManagementObject physicalMemoryDevice in _devices)
                {
                    PhysicalMemoryObject physicalMemoryObject = new PhysicalMemoryObject();
                    try
                    {
                        physicalMemoryObject.Caption = GetFormatValue(physicalMemoryDevice["Caption"]);
                        physicalMemoryObject.Description = GetFormatValue(physicalMemoryDevice["Description"]);
                        physicalMemoryObject.Name = GetFormatValue(physicalMemoryDevice["Name"]);

                        physicalMemoryObject.BankLabel = GetFormatValue(physicalMemoryDevice["BankLabel"]);
                        physicalMemoryObject.Capacity = GetFormatValue(physicalMemoryDevice["Capacity"]);
                        physicalMemoryObject.ConfiguredClockSpeed = GetFormatValue(physicalMemoryDevice["ConfiguredClockSpeed"]);
                        physicalMemoryObject.ConfiguredVoltage = GetFormatValue(physicalMemoryDevice["ConfiguredVoltage"]);
                        physicalMemoryObject.DataWidth = GetFormatValue(physicalMemoryDevice["DataWidth"]);
                        physicalMemoryObject.DeviceLocator = GetFormatValue(physicalMemoryDevice["DeviceLocator"]);
                        physicalMemoryObject.Manufacturer = GetFormatValue(physicalMemoryDevice["Manufacturer"]);
                        physicalMemoryObject.PartNumber = GetFormatValue(physicalMemoryDevice["PartNumber"]);
                        physicalMemoryObject.PositionInRow = GetFormatValue(physicalMemoryDevice["PositionInRow"]);
                        physicalMemoryObject.SMBIOSMemoryType = GetFormatValue(physicalMemoryDevice["SMBIOSMemoryType"]);
                        physicalMemoryObject.Speed = physicalMemoryDevice["Speed"].ToString();

                        _devicesInfo[i++] = physicalMemoryObject;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(String.Format("Processor data can't load. {0}", ex.Message));
                    }
                }
            }
        }

        public new PhysicalMemoryObject[] Instance
        {
            get
            {
                return _devicesInfo as PhysicalMemoryObject[];
            }
        }
    }
}
