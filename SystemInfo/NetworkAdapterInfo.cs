using System;
using System.Management;
using SystemInfo.DeviceObject;

namespace SystemInfo
{
    public class NetworkAdapterInfo : DeviceInfo, IDeviceInfo<NetworkAdapterObject>
    {
        public NetworkAdapterInfo()
            : base("SELECT * FROM Win32_NetworkAdapter")
        {
            if (_devices.Count > 0)
            {
                _devicesInfo = new NetworkAdapterObject[_devices.Count];
                int i = 0;
                foreach (ManagementObject networkAdapterDevice in _devices)
                {
                    NetworkAdapterObject networkAdapterObject = new NetworkAdapterObject();
                    try
                    {
                        networkAdapterObject.Caption = GetFormatValue(networkAdapterDevice["Caption"]);
                        networkAdapterObject.Description = GetFormatValue(networkAdapterDevice["Description"]);
                        networkAdapterObject.DeviceId = GetFormatValue(networkAdapterDevice["DeviceId"]);
                        networkAdapterObject.Name = GetFormatValue(networkAdapterDevice["Name"]);
                        networkAdapterObject.Status = GetFormatValue(networkAdapterDevice["Status"]);

                        networkAdapterObject.GUID = GetFormatValue(networkAdapterDevice["GUID"]);
                        networkAdapterObject.MACAddress = GetFormatValue(networkAdapterDevice["MACAddress"]);
                        networkAdapterObject.Manufacturer = GetFormatValue(networkAdapterDevice["Manufacturer"]);
                        networkAdapterObject.NetConnectionID = GetFormatValue(networkAdapterDevice["NetConnectionID"]);
                        networkAdapterObject.NetConnectionStatus = GetFormatValue(networkAdapterDevice["NetConnectionStatus"]);
                        networkAdapterObject.NetEnabled = GetFormatValue(networkAdapterDevice["NetEnabled"]);
                        networkAdapterObject.NetworkAddress = GetFormatValue(networkAdapterDevice["NetworkAddresses"]);
                        networkAdapterObject.PermanentAddress = GetFormatValue(networkAdapterDevice["PermanentAddress"]);
                        networkAdapterObject.PhysicalAdapter = GetFormatValue(networkAdapterDevice["PhysicalAdapter"]);
                        networkAdapterObject.PNPDeviceID = GetFormatValue(networkAdapterDevice["PNPDeviceID"]);
                        networkAdapterObject.ProductName = GetFormatValue(networkAdapterDevice["ProductName"]);
                        networkAdapterObject.ServiceName = GetFormatValue(networkAdapterDevice["ServiceName"]);
                        networkAdapterObject.Speed = GetFormatValue(networkAdapterDevice["Speed"]);

                        _devicesInfo[i++] = networkAdapterObject;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace + '\n');
                        throw new Exception(String.Format("ERROR. {0}", ex.Message)); 
                    }
                }
            }
        }

        public new NetworkAdapterObject[] Instance
        {
            get
            {
                return _devicesInfo as NetworkAdapterObject[];
            }
        }
    }
}
