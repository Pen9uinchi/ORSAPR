using System;
using System.Management.Instrumentation;
using System.Windows.Forms;
using PotBuilder;
using System.Diagnostics;
using System.IO;
using PotParameters;
using KompasConnector;
using Microsoft.VisualBasic.Devices;

namespace FlowerPot
{
    static class MainClass
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
                //StressTesting();
        }

        public static void StressTesting()
        {
            var builder = new Builder();
            var connector = new Konnector();
            connector.OpenKompas();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var parameters = new Parameters();
            parameters.SetDefaultParameters();
            var streamWriter = new StreamWriter($"log.txt", true);
            var currentProcess = Process.GetCurrentProcess();
            var count = 0;

            while (true)
            {
                builder.BuildPot(connector, parameters);
                var computerInfo = new ComputerInfo();
                var usedMemory = (computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory) *
                                 0.000000000931322574615478515625;
                streamWriter.WriteLine(
                    $"{++count}\t{stopWatch.Elapsed:hh\\:mm\\:ss\\.fff}\t{usedMemory}");
                streamWriter.Flush();
            }
        }
    }
}
