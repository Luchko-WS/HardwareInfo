using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    public enum DeviceType
    {
        Processor = 1,
        SoundDevice = 2,
        VideoController = 3,
        BIOS = 4,
        DiskDrive = 5,
        LogicalDisk = 6,
        PhysicalMemory = 7,
        NetworkAdapter = 8
    }

    public interface IDeviceObject
    {
        string Caption { get; set; }
        /// <summary> Опис пристрою. </summary>
        string Description { get; set; }
        /// <summary> Ідентифікатор присторою. </summary>
        string DeviceId { get; set; }
        /// <summary> Ім'я пристрою. </summary>
        string Name { get; set; }
        /// <summary> Статус роботи пристрою. </summary>
        string Status { get; set; }
        DeviceType DeviceType { get; }
    }
}
