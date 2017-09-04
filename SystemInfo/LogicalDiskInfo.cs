using System;
using System.Management;
using SystemInfo.DeviceObject;

namespace SystemInfo
{
    public class LogicalDiskInfo : DeviceInfo, IDeviceInfo<LogicalDiskObject>
    {
        public LogicalDiskInfo()
            : base("SELECT * FROM Win32_LogicalDisk")
        {
            if (_devices.Count > 0)
            {
                _devicesInfo = new LogicalDiskObject[_devices.Count];
                int i = 0;
                foreach (ManagementObject logicalDiskDevice in _devices)
                {
                    LogicalDiskObject logicalDiskObject = new LogicalDiskObject();
                    try
                    {
                        logicalDiskObject.Caption = GetFormatValue(logicalDiskDevice["Caption"]);
                        logicalDiskObject.Description = GetFormatValue(logicalDiskDevice["Description"]);
                        logicalDiskObject.DeviceId = GetFormatValue(logicalDiskDevice["DeviceId"]);
                        logicalDiskObject.Name = GetFormatValue(logicalDiskDevice["Name"]);
                        logicalDiskObject.Status = GetFormatValue(logicalDiskDevice["Status"]);
                        logicalDiskObject.Access = GetFormatValue(logicalDiskDevice["Access"]);
                        logicalDiskObject.BlockSize = GetFormatValue(logicalDiskDevice["BlockSize"]);
                        logicalDiskObject.Compressed = GetFormatValue(logicalDiskDevice["Compressed"]);
                        logicalDiskObject.DriveType = GetFormatValue(logicalDiskDevice["DriveType"]);
                        logicalDiskObject.FileSystem = GetFormatValue(logicalDiskDevice["FileSystem"]);
                        logicalDiskObject.FreeSpace = GetFormatValue(logicalDiskDevice["FreeSpace"]);
                        logicalDiskObject.MaximumComponentLength = GetFormatValue(logicalDiskDevice["MaximumComponentLength"]);
                        logicalDiskObject.MediaType = GetFormatValue(logicalDiskDevice["MediaType"]);
                        logicalDiskObject.PNPDeviceID = GetFormatValue(logicalDiskDevice["PNPDeviceID"]);
                        logicalDiskObject.Size = GetFormatValue(logicalDiskDevice["Size"]);
                        logicalDiskObject.SupportsDiskQuotas = GetFormatValue(logicalDiskDevice["SupportsDiskQuotas"]);
                        logicalDiskObject.SupportsFileBasedCompression = GetFormatValue(logicalDiskDevice["SupportsFileBasedCompression"]);
                        logicalDiskObject.VolumeName = GetFormatValue(logicalDiskDevice["VolumeName"]);
                        logicalDiskObject.VolumeSerialNumber = GetFormatValue(logicalDiskDevice["VolumeSerialNumber"]);

                        _devicesInfo[i++] = logicalDiskObject;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(String.Format("Processor data can't load. {0}", ex.Message));
                    }
                }
            }
        }

        public new LogicalDiskObject[] Instance
        {
            get
            {
                return _devicesInfo as LogicalDiskObject[];
            }
        }
    }
}
