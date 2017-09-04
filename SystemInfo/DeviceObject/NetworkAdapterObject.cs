using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    /// <summary> Структура, що містить певні характеристики процесора приведені до типу string. </summary>
    public class NetworkAdapterObject: DeviceObject
    {
        public string GUID { get; set; }
        public string Installed { get; set; }
        public string MACAddress { get; set; }
        public string Manufacturer { get; set; }
        public string NetConnectionID { get; set; }
        public string NetConnectionStatus { get; set; }
        public string NetEnabled { get; set; }
        public string NetworkAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string PhysicalAdapter { get; set; }
        public string PNPDeviceID { get; set; }
        public string ProductName { get; set; }
        public string ServiceName { get; set; }
        public string Speed { get; set; }
    }
}