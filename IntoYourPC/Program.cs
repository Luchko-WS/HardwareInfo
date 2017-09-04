using System;
using System.Collections.Generic;
using SystemInfo;
using SystemInfo.DeviceObject;
using System.Windows.Forms;

namespace IntoYourPC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            try
            {
                ProcessorInfo processorInfo = new ProcessorInfo();
                PhysicalMemoryInfo physicalMemoryInfo = new PhysicalMemoryInfo();
                DiskDriveInfo diskDriveInfo = new DiskDriveInfo();
                MainFormPresenter presenter = new MainFormPresenter(form, processorInfo, physicalMemoryInfo, diskDriveInfo);
                Application.Run(form);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            } 
        }
    }
}
