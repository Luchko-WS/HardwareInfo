using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    /// <summary> Структура, що містить певні характеристики процесора приведені до типу string. </summary>
    public class LogicalDiskObject : DeviceObject
    {
        public string Access { get; set; }
        public string BlockSize { get; set; }
        public string Compressed { get; set; }
        public string DriveType { get; set; }
        public string FileSystem { get; set; }
        public string FreeSpace { get; set; }
        public string MaximumComponentLength { get; set; }
        public string MediaType { get; set; }
        public string PNPDeviceID { get; set; }
        public string Size { get; set; }
        public string SupportsDiskQuotas { get; set; }
        public string SupportsFileBasedCompression { get; set; }
        public string VolumeName { get; set; }
        public string VolumeSerialNumber { get; set; }

        public LogicalDiskObject()
        {
            _deviceType = DeviceType.LogicalDisk;
        }
    }
}