using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinSerWat;

namespace ServiceMonitorIcon
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Set the working directory to the directory of the executable
                string executableDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                Directory.SetCurrentDirectory(executableDirectory);

                var configuration = new Configuration();

                // If the service has never been setup open the configuration view
                if (string.IsNullOrEmpty(configuration.ServiceToMonitor))
                {
                    var configurationForm = new ConfigurationForm(configuration);
                    configurationForm.StartPosition = FormStartPosition.CenterScreen;
                    configurationForm.ShowDialog();
                }

                var iconSettings = new IconSettings();

                var assignIconsAction = new Action(() =>
                {
                    iconSettings.RunningIcon = AttemptToLoadIcon("Running", configuration.RunningIconPath, true);
                    iconSettings.StoppedIcon = AttemptToLoadIcon("Stopped", configuration.StoppedIconPath, true);
                    iconSettings.PausedIcon = AttemptToLoadIcon("Paused", configuration.PausedIconPath, true);
                    iconSettings.StartingIcon = AttemptToLoadIcon("Starting", configuration.StartingIconPath);
                    iconSettings.StoppingIcon = AttemptToLoadIcon("Stopping", configuration.StoppingIconPath);
                    iconSettings.PausingIcon = AttemptToLoadIcon("Pausing", configuration.PausingIconPath);
                    iconSettings.UnpausingIcon = AttemptToLoadIcon("Unpausing", configuration.UnpausingIconPath);
                });

                assignIconsAction();

                ServiceWatcher serviceWatcher = null;

                var winSerWatContextMenuManager = new WinSerWatContextMenuManager();
                winSerWatContextMenuManager.AddWinSerWatMenuItem(
                    new WinSerWatMenuItem("Configure", () =>
                    {
                        var configurationForm = new ConfigurationForm(configuration);
                        configurationForm.StartPosition = FormStartPosition.CenterScreen;
                        configurationForm.ShowDialog();
                        assignIconsAction();
                        serviceWatcher.PollServiceStatusInterval = TimeSpan.FromMilliseconds(configuration.PollRate);
                        serviceWatcher.WaitForStateChangeTimeout = TimeSpan.FromMilliseconds(configuration.WaitForStateTimeout);
                        serviceWatcher.ChangeService(configuration.ServiceToMonitor);
                    }));

                serviceWatcher = new ServiceWatcher(configuration.ServiceToMonitor, iconSettings, winSerWatContextMenuManager)
                {
                    PollServiceStatusInterval = TimeSpan.FromMilliseconds(configuration.PollRate),
                    WaitForStateChangeTimeout = TimeSpan.FromMilliseconds(configuration.WaitForStateTimeout)
                };

                serviceWatcher.StartWatching();

                Application.Run(serviceWatcher);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Service Monitor Icon Failed To Start with an exception: " + exception.Message);
            }
        }

        private static Icon AttemptToLoadIcon(string iconName, string iconPath, bool mandatory = false)
        {
            Icon icon = null;

            if (File.Exists(iconPath))
            {
                icon = new Icon(iconPath);
            }
            else
            {
                if (mandatory)
                {
                    throw new FileNotFoundException($"The path to the mandatory icon '{iconName}' could not be resolved with the path provided", iconPath);
                }
            }

            return icon;
        }
    }
}