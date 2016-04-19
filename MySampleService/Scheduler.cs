using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySampleService
{
    class Scheduler
    {
        System.Timers.Timer oTimer = null;
        double interval = 20000;

        public void Start()
        {
            oTimer = new System.Timers.Timer(interval);
            oTimer.AutoReset = true;
            oTimer.Enabled = true;
            oTimer.Start();

            oTimer.Elapsed += new System.Timers.ElapsedEventHandler(oTimer_Elapsed);

        }

        private void oTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            FileCreation();
        }

        void FileCreation()
        {
            string sFilePath = @"C:\Users\andrei.coman\Documents\testService\SampleFile.txt";
            string sDateTime = DateTime.Now.ToString();

            System.IO.StreamWriter oFileWriter = new System.IO.StreamWriter(sFilePath, true);
            oFileWriter.WriteLine("\n" + sDateTime);

            oFileWriter.Close();
        }
    }
}
