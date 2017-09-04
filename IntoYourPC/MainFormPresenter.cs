using System;
using System.Collections.Generic;
using System.Management;
using System.Threading;
using SystemInfo;
using SystemInfo.DeviceObject;
using System.Windows.Forms;

namespace IntoYourPC
{
    public class MainFormPresenter
    {
        private IMainForm _form;
        private bool applicationIsVorking = true;

        private ProcessorInfo _processorInfo;
        private Thread _calcProcessorTempThread;
        private Thread _calcProcessorSpeedThread;
        private List<double> _temperatureLsit;

        private PhysicalMemoryInfo _physicalMemoryInfo;

        private DiskDriveInfo _diskDriveInfo;

        public MainFormPresenter(IMainForm form, ProcessorInfo processorInfo, PhysicalMemoryInfo physicalMemoryInfo, DiskDriveInfo diskDriveInfo)
        {
            _form = form;

            #region Get processor info
            _processorInfo = processorInfo;
            _form.ProcessorName = _processorInfo.Instance[0].Name;
            _temperatureLsit = new List<double>();    
            _form.MaxProcessorClockSpeed = _processorInfo.Instance[0].MaxClockSpeed;

            var processorsProperities = new Dictionary<string, string>();
            processorsProperities.Add("AddressWidth", _processorInfo.Instance[0].AddressWidth);
            processorsProperities.Add("Architecture", _processorInfo.Instance[0].Architecture);
            processorsProperities.Add("Caption", _processorInfo.Instance[0].Caption);
            processorsProperities.Add("DataWidth", _processorInfo.Instance[0].DataWidth);
            processorsProperities.Add("Description", _processorInfo.Instance[0].Description);
            processorsProperities.Add("DeviceId", _processorInfo.Instance[0].DeviceId);
            processorsProperities.Add("Family", _processorInfo.Instance[0].Family);
            processorsProperities.Add("Manufactured", _processorInfo.Instance[0].Manufactured);
            processorsProperities.Add("Name", _processorInfo.Instance[0].Name);
            processorsProperities.Add("NumberOfCores", _processorInfo.Instance[0].NumberOfCores);
            processorsProperities.Add("NumberOfEnabledCore", _processorInfo.Instance[0].NumberOfEnabledCore);
            processorsProperities.Add("NumberOfLogicalProcessors", _processorInfo.Instance[0].NumberOfLogicalProcessors);
            processorsProperities.Add("PartNumber", _processorInfo.Instance[0].PartNumber);
            processorsProperities.Add("ProcessorId", _processorInfo.Instance[0].ProcessorId);
            processorsProperities.Add("SerialNumber", _processorInfo.Instance[0].SerialNumber);
            processorsProperities.Add("Status", _processorInfo.Instance[0].Status);
            processorsProperities.Add("ThreadCount", _processorInfo.Instance[0].ThreadCount);

            foreach (var processorProperity in processorsProperities)
            {
                var item = new ListViewItem(processorProperity.Key, 0);
                item.SubItems.Add(processorProperity.Value);
                _form.ProcessorProperitiesListView.Items.Add(item);
            }

            _calcProcessorTempThread = new Thread(new ThreadStart(ReloadProcessorTemp));
            _calcProcessorSpeedThread = new Thread(new ThreadStart(ReloadProcessorSpeed));
            _calcProcessorTempThread.Start();
            _calcProcessorSpeedThread.Start();
            #endregion

            #region Get physical memory info
            _physicalMemoryInfo = physicalMemoryInfo;
            var physicalMemoryDevices = new Dictionary<string, string> [_physicalMemoryInfo.Instance.Length];

            for (int i = 0; i < _physicalMemoryInfo.Instance.Length; i++)
            {
                var physicalMemoryProperities = new Dictionary<string, string>();
                physicalMemoryProperities.Add("BankLabel", _physicalMemoryInfo.Instance[i].BankLabel);
                physicalMemoryProperities.Add("Capacity", _physicalMemoryInfo.Instance[i].Capacity);
                physicalMemoryProperities.Add("Caption", _physicalMemoryInfo.Instance[i].Caption);
                physicalMemoryProperities.Add("ConfiguredClockSpeed", _physicalMemoryInfo.Instance[i].ConfiguredClockSpeed);
                physicalMemoryProperities.Add("ConfiguredVoltage", _physicalMemoryInfo.Instance[i].ConfiguredVoltage);
                physicalMemoryProperities.Add("DataWidth", _physicalMemoryInfo.Instance[i].DataWidth);
                physicalMemoryProperities.Add("Description", _physicalMemoryInfo.Instance[i].Description);
                physicalMemoryProperities.Add("DeviceLocator", _physicalMemoryInfo.Instance[i].DeviceLocator);
                physicalMemoryProperities.Add("Manufacturer", _physicalMemoryInfo.Instance[i].Manufacturer);
                physicalMemoryProperities.Add("Name", _physicalMemoryInfo.Instance[i].Name);
                physicalMemoryProperities.Add("PartNumber", _physicalMemoryInfo.Instance[i].PartNumber);
                physicalMemoryProperities.Add("PositionInRow", _physicalMemoryInfo.Instance[i].PositionInRow);
                physicalMemoryProperities.Add("Speed", _physicalMemoryInfo.Instance[i].Speed);
                physicalMemoryDevices[i] = physicalMemoryProperities;
            }

            foreach (var device in physicalMemoryDevices)
            {
                foreach (var physicalMemoryProperity in device)
                {
                    var item = new ListViewItem(physicalMemoryProperity.Key, 0);
                    item.SubItems.Add(physicalMemoryProperity.Value);
                    _form.PhysicalMemoryProperitiesListView.Items.Add(item);
                }
            }
            #endregion

            #region Get disk drive info
            _diskDriveInfo = diskDriveInfo;
            var diskDriveDevices = new Dictionary<string, string>[_diskDriveInfo.Instance.Length];

            for (int i = 0; i < _diskDriveInfo.Instance.Length; i++)
            {
                var diskDriveProperities = new Dictionary<string, string>();
                diskDriveProperities.Add("BytesPerSector", _diskDriveInfo.Instance[i].BytesPerSector);
                diskDriveProperities.Add("Capabilities", _diskDriveInfo.Instance[i].Capabilities);
                diskDriveProperities.Add("CapabilityDescriptions", _diskDriveInfo.Instance[i].CapabilityDescriptions);
                diskDriveProperities.Add("Caption", _diskDriveInfo.Instance[i].Caption);
                diskDriveProperities.Add("Description", _diskDriveInfo.Instance[i].Description);
                diskDriveProperities.Add("DeviceId", _diskDriveInfo.Instance[i].DeviceId);
                diskDriveProperities.Add("InterfaceType", _diskDriveInfo.Instance[i].InterfaceType);
                diskDriveProperities.Add("Manufacturer", _diskDriveInfo.Instance[i].Manufacturer);
                diskDriveProperities.Add("Model", _diskDriveInfo.Instance[i].Model);
                diskDriveProperities.Add("Name", _diskDriveInfo.Instance[i].Name);
                diskDriveProperities.Add("Partitions", _diskDriveInfo.Instance[i].Partitions);
                diskDriveProperities.Add("PNPDeviceID", _diskDriveInfo.Instance[i].PNPDeviceID);
                diskDriveProperities.Add("SectorsPerTrack", _diskDriveInfo.Instance[i].SectorsPerTrack);
                diskDriveProperities.Add("SerialNumber", _diskDriveInfo.Instance[i].SerialNumber);
                diskDriveProperities.Add("Size", _diskDriveInfo.Instance[i].Size);
                diskDriveProperities.Add("Status", _diskDriveInfo.Instance[i].Status);
                diskDriveProperities.Add("SystemName", _diskDriveInfo.Instance[i].SystemName);
                diskDriveProperities.Add("TotalCylinders", _diskDriveInfo.Instance[i].TotalCylinders);
                diskDriveProperities.Add("TotalHeads", _diskDriveInfo.Instance[i].TotalHeads);
                diskDriveProperities.Add("TotalSectors", _diskDriveInfo.Instance[i].TotalSectors);
                diskDriveProperities.Add("TotalTracks", _diskDriveInfo.Instance[i].TotalTracks);
                diskDriveProperities.Add("TracksPerCylinder", _diskDriveInfo.Instance[i].TracksPerCylinder);
                diskDriveDevices[i] = diskDriveProperities;
            }

            foreach (var device in diskDriveDevices)
            {
                foreach (var diskDriveProperity in device)
                {
                    var item = new ListViewItem(diskDriveProperity.Key, 0);
                    item.SubItems.Add(diskDriveProperity.Value);
                    _form.DiskDriveProperitiesListView.Items.Add(item);
                }
            }
            #endregion

            _form.ApplicationClose += _form_ApplicationClose;
        }

        private void ReloadProcessorTemp()
        {
            while (applicationIsVorking)
            {
                try
                {
                    _processorInfo.UpdateCurrentTemperature();
                    _form.CurrentProcessorTemp = _processorInfo.Instance[0].Temperature;
                    if (_temperatureLsit.Count >= 21)
                    {
                        _temperatureLsit.RemoveAt(0);
                    }
                    _temperatureLsit.Add(Convert.ToDouble(_processorInfo.Instance[0].Temperature));
                    _form.ProcessorTemperatureHistory = _temperatureLsit;
                    _form.InvalidateProcessorTemperatureHistory();
                    Thread.Sleep(3000);
                }
                catch(Exception ex)
                {
                    _calcProcessorTempThread.Abort();
                    throw new Exception(ex.Message);
                }
            }
        }

        private void ReloadProcessorSpeed()
        {
            try
            {
                while (applicationIsVorking)
                {
                    _processorInfo.UpdateCurrentClockSpeed();
                    _form.CurrentProcessorClockSpeed = _processorInfo.Instance[0].CurrentClockSpeed;
                    Thread.Sleep(2000);
                }
            }
            catch(Exception ex)
            {
                _calcProcessorSpeedThread.Abort();
                throw new Exception(ex.Message);
            }
        }

        private void _form_ApplicationClose(object sender, EventArgs e)
        {
            applicationIsVorking = false;
        }
    }
}
