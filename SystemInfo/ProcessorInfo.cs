using System;
using System.Management;
using SystemInfo.DeviceObject;

namespace SystemInfo
{
    /// <summary> Клас інформації про процесори. </summary>
    public class ProcessorInfo : DeviceInfo, IDeviceInfo<ProcessorObject>
    {
        public ProcessorInfo()
            :base("SELECT * FROM Win32_Processor")
        { 
            if (_devices.Count > 0)
            {
                _devicesInfo = new ProcessorObject[_devices.Count];
                int i = 0;

                foreach (ManagementObject processor in _devices)
                {
                    ProcessorObject processorObject = new ProcessorObject();
                    try
                    {
                        processorObject.Caption = GetFormatValue(processor["Caption"]);
                        processorObject.Description = GetFormatValue(processor["Description"]);
                        processorObject.DeviceId = GetFormatValue(processor["DeviceId"]);
                        processorObject.Name = GetFormatValue(processor["Name"]);
                        processorObject.Status = GetFormatValue(processor["Status"]);

                        processorObject.AddressWidth = GetFormatValue(processor["AddressWidth"]);
                        processorObject.Architecture = GetFormatValue(processor["Architecture"]);
                        processorObject.CurrentClockSpeed = GetFormatValue(processor["CurrentClockSpeed"]);
                        processorObject.DataWidth = GetFormatValue(processor["DataWidth"]);
                        processorObject.Family = GetFormatValue(processor["Family"]);
                        processorObject.Level = GetFormatValue(processor["Level"]);
                        processorObject.Manufactured = GetFormatValue(processor["Manufacturer"]);
                        processorObject.MaxClockSpeed = GetFormatValue(processor["MaxClockSpeed"]);
                        processorObject.NumberOfCores = GetFormatValue(processor["NumberOfCores"]);
                        processorObject.NumberOfEnabledCore = GetFormatValue(processor["NumberOfEnabledCore"]);
                        processorObject.NumberOfLogicalProcessors = GetFormatValue(processor["NumberOfLogicalProcessors"]);
                        processorObject.PartNumber = GetFormatValue(processor["PartNumber"]);
                        processorObject.ProcessorId = GetFormatValue(processor["ProcessorId"]);
                        processorObject.SerialNumber = GetFormatValue(processor["SerialNumber"]);
                        processorObject.ThreadCount = GetFormatValue(processor["ThreadCount"]);

                       _devicesInfo[i++] = processorObject;
                    }
                    catch(Exception ex)
                    {
                        throw new Exception(String.Format("Processor data can't load. {0}", ex.Message));
                    }        
                }
            }
        }

        public new ProcessorObject[] Instance
        {
            get
            {
                return _devicesInfo as ProcessorObject[];
            }
        }

        public void UpdateCurrentClockSpeed()
        {
            try
            {
                _devices = _connection.Get();
                int i = 0;
                foreach (ManagementObject processor in _devices)
                {
                    (_devicesInfo[i++] as ProcessorObject).CurrentClockSpeed = GetFormatValue(processor["CurrentClockSpeed"]); ;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCurrentTemperature()
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature"))
                {
                    int i = 0;
                    foreach (var processor in searcher.Get())
                    {
                        (_devicesInfo[i++] as ProcessorObject).Temperature = GetFormatValue(Convert.ToString((uint)processor["CurrentTemperature"] * 0.1 - 273.15));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
