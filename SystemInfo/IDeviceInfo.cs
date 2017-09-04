using System;
using System.Management;

namespace SystemInfo
{
    public interface IDeviceInfo<T>
        where T : DeviceObject.DeviceObject
    {
        /// <summary> З'єднання з базою даних з інформацією про пристрій. </summary>
        ManagementObjectSearcher Connect { get; }
        /// <summary> Список об'єктів, що характеризують пристрої типу Т. </summary>
        T[] Instance { get; }
    }

    public interface IDeviceInfo : IDeviceInfo<DeviceObject.DeviceObject>
    {

    }
}
