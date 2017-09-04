using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    /// <summary> Структура, що містить певні характеристики процесора приведені до типу string. </summary>
    public class DiskDriveObject : DeviceObject
    {
        public string BytesPerSector { get; set; }
        public string Capabilities { get; set; }
        public string CapabilityDescriptions { get; set; }
        public string InterfaceType { get; set; }
        public string Manufacturer { get; set; }
        public string MediaLoaded { get; set; }
        public string Model { get; set; }
        public string Partitions { get; set; }
        public string PNPDeviceID { get; set; }
        public string SectorsPerTrack { get; set; }
        public string SerialNumber { get; set; }
        public string Size { get; set; }
        public string SystemName { get; set; }
        public string TotalCylinders { get; set; }
        public string TotalHeads { get; set; }
        public string TotalSectors { get; set; }
        public string TotalTracks { get; set; }
        public string TracksPerCylinder { get; set; }

        public DiskDriveObject()
        {
            _deviceType = DeviceType.DiskDrive;
        }
    }
}