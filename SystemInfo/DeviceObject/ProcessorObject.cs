using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo.DeviceObject
{
    /// <summary> Структура, що містить певні характеристики процесора приведені до типу string. </summary>
    public class ProcessorObject : DeviceObject
    {
        public string AddressWidth { get; set; }
        /// <summary> Архітертура процесора. </summary>
        public string Architecture { get; set; }
        /// <summary> Поточна частота процесора. </summary>
        public string CurrentClockSpeed { get; set; }
        public string DataWidth { get; set; }
        public string Family { get; set; }
        public string Level { get; set; }
        public string Manufactured { get; set; }
        /// <summary> Максимальна частота процесора. </summary>
        public string MaxClockSpeed { get; set; }
        /// <summary> Кількість ядер процесора. </summary>
        public string NumberOfCores { get; set; }
        /// <summary> Кількість доступних ядер процесора. </summary>
        public string NumberOfEnabledCore { get; set; }
        /// <summary> Кількість логічних процесорів. </summary>
        public string NumberOfLogicalProcessors { get; set; }
        public string PartNumber { get; set; }
        /// <summary> Ідентифікатор процесора. </summary>
        public string ProcessorId { get; set; }
        /// <summary> Серійний номер процесора. </summary>
        public string SerialNumber { get; set; }
        public string Temperature { get; set; }
        /// <summary> Кількість потоків процесора. </summary>
        public string ThreadCount { get; set; }

        public ProcessorObject()
        {
            _deviceType = DeviceType.Processor;
        }
    }
}