using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using WinSerWat;

namespace ServiceMonitorIcon
{
    class Program
    {
        private const string ServiceToWatchAppSettingsKey = "ServiceToWatch";

        private const string RunningIconAppSettingKey = "RunningIcon";

        private const string StoppedIconAppSettingKey = "StoppedIcon";

        private const string PausedIconAppSettingKey = "PausedIcon";

        private const string StartingIconAppSettingKey = "StartingIcon";

        private const string StoppingIconAppSettingKey = "StoppingIcon";

        private const string PausingIconAppSettingKey = "PausingIcon";

        private const string ResumingIconAppSettingKey = "ResumingIcon";

        private const int DefaultPollIntervalSeconds = 1;

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                string serviceName = ConfigurationManager.AppSettings[ServiceToWatchAppSettingsKey];

                if (string.IsNullOrWhiteSpace(serviceName))
                {
                    throw new ConfigurationErrorsException("A valid service name must be provided!");
                }

                var iconSettings = new IconSettings()
                {
                    PollServiceStatusInterval = TimeSpan.FromSeconds(DefaultPollIntervalSeconds)
                };

                string runningIconUri = ConfigurationManager.AppSettings[RunningIconAppSettingKey];

                if (!string.IsNullOrWhiteSpace(runningIconUri))
                {
                    iconSettings.RunningIcon = new Icon(runningIconUri);
                }

                string stoppedIconUri = ConfigurationManager.AppSettings[StoppedIconAppSettingKey];

                if (!string.IsNullOrWhiteSpace(stoppedIconUri))
                {
                    iconSettings.StoppedIcon = new Icon(stoppedIconUri);
                }

                string pausedIconUri = ConfigurationManager.AppSettings[PausedIconAppSettingKey];

                if (!string.IsNullOrWhiteSpace(pausedIconUri))
                {
                    iconSettings.PausedIcon = new Icon(pausedIconUri);
                }

                string startingIconUri = ConfigurationManager.AppSettings[StartingIconAppSettingKey];

                if (!string.IsNullOrWhiteSpace(startingIconUri))
                {
                    iconSettings.StartingIcon = new Icon(startingIconUri);
                }

                string stoppingIconUri = ConfigurationManager.AppSettings[StoppedIconAppSettingKey];

                if (!string.IsNullOrWhiteSpace(stoppingIconUri))
                {
                    iconSettings.StoppingIcon = new Icon(stoppingIconUri);
                }

                string pausingIconUri = ConfigurationManager.AppSettings[PausedIconAppSettingKey];

                if (!string.IsNullOrWhiteSpace(pausingIconUri))
                {
                    iconSettings.PausingIcon = new Icon(pausingIconUri);
                }

                string resumingIconUri = ConfigurationManager.AppSettings[ResumingIconAppSettingKey];

                if (!string.IsNullOrWhiteSpace(resumingIconUri))
                {
                    iconSettings.UnpausingIcon = new Icon(resumingIconUri);
                }

                Application.Run(new ServiceWatcher("Spooler", iconSettings, true));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Service Monitor Icon Failed To Start with an exception: " + exception.Message);
            }
        }
    }
}
