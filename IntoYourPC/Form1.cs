using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntoYourPC
{
    public interface IMainForm
    {  
        string CurrentProcessorTemp { get; set; }
        string CurrentProcessorClockSpeed { get; set; }
        string MaxProcessorClockSpeed { get; set; }
        string ProcessorName { get; set; }
        ListView ProcessorProperitiesListView { get; set; }
        List<double> ProcessorTemperatureHistory { set; }
        void InvalidateProcessorTemperatureHistory();

        ListView PhysicalMemoryProperitiesListView { get; set; }

        ListView DiskDriveProperitiesListView { get; set; }

        event EventHandler ApplicationClose;
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
       
        #region ProcessorTab
        private List<double> _processorTemperatureHistory;

        public string CurrentProcessorClockSpeed
        {
            get
            {
                return currentProcessorClockSpeedLabel.Text;
            }

            set
            {
                currentProcessorClockSpeedLabel.Text = value;
                clockSpeedProgressBar.Value = Convert.ToInt32(value);
            }
        }
        public string CurrentProcessorTemp
        {
            get
            {
                return currentProcessorTempLabel.Text;
            }

            set
            {
                currentProcessorTempLabel.Text = Math.Round(Convert.ToDouble(value), 2).ToString();
                processorTempProgressBar.Value = (int)Convert.ToDouble(value);
            }
        }
        public string MaxProcessorClockSpeed
        {
            get
            {
                return maxProcessorClockSpeedLabel.Text;
            }

            set
            {
                maxProcessorClockSpeedLabel.Text = value;
                clockSpeedProgressBar.Maximum = Convert.ToInt32(value);
            }
        }
        public string ProcessorName
        {
            get
            {
                return processorNameLabel.Text;
            }

            set
            {
                processorNameLabel.Text = value;
            }
        }
        public List<double> ProcessorTemperatureHistory
        {
            set
            {
                _processorTemperatureHistory = value;
            }
        }
        public ListView ProcessorProperitiesListView
        {
            get
            {
                return processorProperitiesListView;
            }

            set
            {
                processorProperitiesListView = value;
            }
        }
        #endregion

        #region MemoryTab
        public ListView PhysicalMemoryProperitiesListView
        {
            get
            {
                return physicalMemoryProperitiesListView;
            }

            set
            {
                physicalMemoryProperitiesListView = value;
            }
        }

        public ListView DiskDriveProperitiesListView
        {
            get
            {
                return diskDriveProperitiesListView;
            }

            set
            {
                diskDriveProperitiesListView = value;
            }
        }
        #endregion

        public event EventHandler ApplicationClose;

        private void MainForm_Load(object sender, EventArgs e)
        {
            _processorTemperatureHistory = new List<double>();
        }
        private void hardvareInfoTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPage.Text)
            {
                case "Процесор":           
                    break;
                case "Пам'ять":         
                    break;
                default:
                    break;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationClose?.Invoke(this, EventArgs.Empty);
        }
        public void InvalidateProcessorTemperatureHistory()
        {
            tempGraphicsPanel.Invalidate();
        }
        private void tempGraphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Gray, 1),
                    0, (float)(tempGraphicsPanel.Height * 0.2 * (i + 1)),
                    tempGraphicsPanel.Width, (float)(tempGraphicsPanel.Height * 0.2 * (i + 1)));
                e.Graphics.DrawString(Convert.ToString(100 * 0.2 * (i + 1)), new Font("Arial", 8),
                    Brushes.Black, 0, (float)(tempGraphicsPanel.Height - tempGraphicsPanel.Height * 0.2 * (i + 1)));
            }
            for (int i = 0; i < 21; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Gray, 1),
                    20 + (25 * i), 0,
                    20 + (25 * i), tempGraphicsPanel.Height);
            }

            if (_processorTemperatureHistory.Count != 0)
            {
                for (int i = 0; i < _processorTemperatureHistory.Count - 1; i++)
                {
                    Pen pen;
                    if (_processorTemperatureHistory[i] > 50)
                    {
                        pen = new Pen(Color.Orange, 2);
                    }
                    else if (_processorTemperatureHistory[i] > 75)
                    {
                        pen = new Pen(Color.Red, 2);
                    }
                    else
                    {
                        pen = new Pen(Color.Green, 2);
                    }

                    e.Graphics.DrawLine(pen,
                        20 + ((tempGraphicsPanel.Width - 20) / 20 * i),
                        tempGraphicsPanel.Height - (float)(tempGraphicsPanel.Height * (_processorTemperatureHistory[i] / 100)),
                        20 + ((tempGraphicsPanel.Width - 20) / 20 * (i + 1)),
                        tempGraphicsPanel.Height - (float)(tempGraphicsPanel.Height * (_processorTemperatureHistory[i + 1] / 100)));

                    if (pen != null)
                    {
                        pen.Dispose();
                    }
                }
            }
        }
    }
}
