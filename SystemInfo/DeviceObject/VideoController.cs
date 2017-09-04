using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    /// <summary> Структура, що містить певні характеристики процесора приведені до типу string. </summary>
    public class VideoControllerObject : DeviceObject
    {
        public string AdapterCompatibility { get; set; }
        /// <summary> DAC-тип відеоконтролера (інтегрований, дискретний). </summary>
        public string AdapterDACType { get; set; }
        /// <summary> Об'єм пам'ятті відеоконтролера. </summary>
        public string AdapterRAM { get; set; }
        public string Availability { get; set; }
        /// <summary> Версія драйвера. </summary>
        public string DriverVersion { get; set; }
        public string VideoArchitecture { get; set; }
        public string VideoMemoryType { get; set; }
        /// <summary> Процесор відеоконтролера. </summary>
        public string VideoProcessor { get; set; }

        public VideoControllerObject()
        {
            _deviceType = DeviceType.VideoController;
        }
    }
}