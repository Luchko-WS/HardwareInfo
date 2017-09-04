using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    public class DeviceObject : IDeviceObject
    {
        protected DeviceType _deviceType;

        public string Caption { get; set; }
        /// <summary> Опис пристрою. </summary>
        public string Description { get; set; }
        /// <summary> Ідентифікатор присторою. </summary>
        public string DeviceId { get; set; }
        /// <summary> Ім'я пристрою. </summary>
        public string Name { get; set; }
        /// <summary> Статус роботи пристрою. </summary>
        public string Status { get; set; }
        public DeviceType DeviceType { get { return _deviceType; } }
    }
}