using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    /// <summary> Структура, що містить певні характеристики процесора приведені до типу string. </summary>
    public class PhysicalMemoryObject : DeviceObject
    {
        public string BankLabel { get; set; }
        public string Capacity { get; set; }
        public string ConfiguredClockSpeed { get; set; }
        public string ConfiguredVoltage { get; set; }
        public string DataWidth { get; set; }
        public string DeviceLocator { get; set; }
        public string Manufacturer { get; set; }
        public string PartNumber { get; set; }
        public string PositionInRow { get; set; }
        public string SMBIOSMemoryType { get; set; }
        public string Speed { get; set; }

        public PhysicalMemoryObject()
        {
            _deviceType = DeviceType.PhysicalMemory;
        }
    }
}