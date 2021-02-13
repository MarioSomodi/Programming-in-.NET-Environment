using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Configuration;

namespace WindowsLoggingService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Servis pokrenut: ");
            ScheduleService();
        }

        protected override void OnStop()
        {
            WriteToFile("Servis zaustavljen: ");
        }
        public static void ScheduleService()
        {
            Timer Schedular = new Timer(new TimerCallback(SchedularCallback));
            DateTime scheduledTime = DateTime.MinValue;
            /*int intervalSeconds = 5;
            scheduledTime = DateTime.Now.AddSeconds(intervalSeconds);
            if (DateTime.Now > scheduledTime)
            {
                scheduledTime = scheduledTime.AddSeconds(intervalSeconds);
            }*/
            TimeSpan timeSpan = scheduledTime.Subtract(DateTime.Now);
            int dueTime = Convert.ToInt32(timeSpan.TotalMilliseconds);
            Schedular.Change(dueTime, Timeout.Infinite);
        }
        private static void SchedularCallback(object e)
        {
            WriteToFile("Log: ");
            ScheduleService();
        }
        private static void WriteToFile(string text)
        {
            string path = "C:/Users/fpsdr/source/repos/WindowsLoggingService/WindowsLoggingService/ServiceLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("{0} - {1}",text, DateTime.Now.ToString("dd/MM/yyyy hh: mm:ss tt"));
                writer.Close();
            }
        }
    }
}
