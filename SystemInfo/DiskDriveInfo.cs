using System;
using System.Management;
using SystemInfo.DeviceObject;

namespace SystemInfo
{
    public class DiskDriveInfo : DeviceInfo, IDeviceInfo<DiskDriveObject>
    {
        public DiskDriveInfo()
            : base("SELECT * FROM Win32_DiskDrive")
        {
            if (_devices.Count > 0)
            {
                _devicesInfo = new DiskDriveObject[_devices.Count];
                int i = 0;
                foreach (ManagementObject diskDriveDevice in _devices)
                {
                    DiskDriveObject diskDriveObject = new DiskDriveObject();
                    try
                    {
                        diskDriveObject.Caption = GetFormatValue(diskDriveDevice["Caption"]);
                        diskDriveObject.Description = GetFormatValue(diskDriveDevice["Description"]);
                        diskDriveObject.DeviceId = GetFormatValue(diskDriveDevice["DeviceId"]);
                        diskDriveObject.Name = GetFormatValue(diskDriveDevice["Name"]);
                        diskDriveObject.Status = GetFormatValue(diskDriveDevice["Status"]);

                        diskDriveObject.BytesPerSector = GetFormatValue(diskDriveDevice["BytesPerSector"]);
                        diskDriveObject.Capabilities = GetFormatValue(diskDriveDevice["Capabilities"]);
                        diskDriveObject.CapabilityDescriptions = GetFormatValue(diskDriveDevice["CapabilityDescriptions"]);
                        diskDriveObject.InterfaceType = GetFormatValue(diskDriveDevice["InterfaceType"]);
                        diskDriveObject.Manufacturer = GetFormatValue(diskDriveDevice["Manufacturer"]);
                        diskDriveObject.MediaLoaded = GetFormatValue(diskDriveDevice["MediaLoaded"]);
                        diskDriveObject.Model = GetFormatValue(diskDriveDevice["Model"]);
                        diskDriveObject.Partitions = GetFormatValue(diskDriveDevice["Partitions"]);
                        diskDriveObject.PNPDeviceID = GetFormatValue(diskDriveDevice["PNPDeviceID"]);
                        diskDriveObject.SectorsPerTrack = GetFormatValue(diskDriveDevice["SectorsPerTrack"]);
                        diskDriveObject.SerialNumber = GetFormatValue(diskDriveDevice["SerialNumber"]);
                        diskDriveObject.Size = GetFormatValue(diskDriveDevice["Size"]);
                        diskDriveObject.SystemName = GetFormatValue(diskDriveDevice["SystemName"]);
                        diskDriveObject.TotalCylinders = GetFormatValue(diskDriveDevice["TotalCylinders"]);
                        diskDriveObject.TotalHeads = GetFormatValue(diskDriveDevice["TotalHeads"]);
                        diskDriveObject.TotalSectors = GetFormatValue(diskDriveDevice["TotalSectors"]);
                        diskDriveObject.TotalTracks = GetFormatValue(diskDriveDevice["TotalTracks"]);
                        diskDriveObject.TracksPerCylinder = GetFormatValue(diskDriveDevice["TracksPerCylinder"]);

                        _devicesInfo[i++] = diskDriveObject;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(String.Format("Processor data can't load. {0}", ex.Message));
                    }
                }
            }
        }

        public new DiskDriveObject[] Instance
        {
            get
            {
                return _devicesInfo as DiskDriveObject[];
            }
        }
    }
}
