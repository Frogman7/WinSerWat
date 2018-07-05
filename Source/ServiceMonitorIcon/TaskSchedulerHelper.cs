using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceMonitorIcon
{
    internal class TaskSchedulerHelper
    {
        private const string TaskName = "Windows Service Monitor Icon Autostart";

        public static bool CheckIfTaskExists()
        {
            var querySchtasksResult = RunTerminalCommand($"schtasks /Query /TN \"{TaskName}\"");

            return querySchtasksResult.Contains("ERROR") ? false : true;
        }

        public static void AddTask()
        {
            var pathToExecutable = Assembly.GetExecutingAssembly().Location;

            var taskAddResult = RunTerminalCommand($"schtasks /Create /TN \"{TaskName}\" /TR \"{pathToExecutable}\" /SC ONLOGON /RL HIGHEST");
        }

        public static void RemoveTask()
        {
            var removeTaskResult = RunTerminalCommand($"schtasks /Delete /TN \"{TaskName}\" /f");
        }

        private static string RunTerminalCommand(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "cmd.exe";
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine(command);
            process.StandardInput.Flush();
            process.StandardInput.Close();

            process.WaitForExit();

            string response = string.Empty;

            if (process.StandardError.EndOfStream)
            {
                response = process.StandardOutput.ReadToEnd();
            }
            else
            {
                response = process.StandardError.ReadToEnd();
            }

            return response;
        }
    }
}