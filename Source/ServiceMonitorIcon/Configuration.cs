using System;
using System.Configuration;

using ApplicationConfiguration = System.Configuration.Configuration;

namespace ServiceMonitorIcon
{
    public class Configuration
    {
        protected ApplicationConfiguration applicationConfiguration;

        public Configuration()
        {
            this.applicationConfiguration =
                ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);

            this.RefreshFromAppConfig();
        }

        public string ServiceToMonitor { get; set; }

        public int WaitForStateTimeout { get; set; }

        public int PollRate { get; set; }

        public string RunningIconPath { get; set; }

        public string StoppedIconPath { get; set; }

        public string StartingIconPath { get; set; }

        public string StoppingIconPath { get; set; }

        public string PausedIconPath { get; set; }

        public string PausingIconPath { get; set; }

        public string UnpausingIconPath { get; set; }

        public void RefreshFromAppConfig()
        {
            string serviceName = this.ReadAppSetting(Constants.ServiceToWatchAppSettingsKey);

            this.ServiceToMonitor = serviceName;

            var pollRateString = this.ReadAppSetting(Constants.PollRateAppSettingsKey);

            if (int.TryParse(pollRateString, out var pollRateInteger))
            {
                this.PollRate = pollRateInteger;
            }
            else
            {
                throw new InvalidOperationException($"Could not convert set {nameof(this.PollRate)} of '{pollRateString}' to an integer");
            }

            var waitForStateTimeoutString = this.ReadAppSetting(Constants.WaitForStateTimeoutAppSettingsKey);

            if (int.TryParse(waitForStateTimeoutString, out var waitForStateTimeoutInteger))
            {
                this.WaitForStateTimeout = waitForStateTimeoutInteger;
            }
            else
            {
                throw new InvalidOperationException($"Could not convert set {nameof(this.WaitForStateTimeout)} of '{waitForStateTimeoutString}' to an integer");
            }

            this.RunningIconPath = this.ReadAppSetting(Constants.RunningIconAppSettingKey);

            this.StoppedIconPath = this.ReadAppSetting(Constants.StoppedIconAppSettingKey);

            this.PausedIconPath = this.ReadAppSetting(Constants.PausedIconAppSettingKey);

            this.StartingIconPath = this.ReadAppSetting(Constants.StartingIconAppSettingKey);

            this.StoppingIconPath = this.ReadAppSetting(Constants.StoppingIconAppSettingKey);

            this.PausingIconPath = this.ReadAppSetting(Constants.PausedIconAppSettingKey);

            this.UnpausingIconPath = this.ReadAppSetting(Constants.ResumingIconAppSettingKey);
        }

        public void SaveToAppConfig()
        {
            this.WriteAppSetting(Constants.ServiceToWatchAppSettingsKey, this.ServiceToMonitor);

            this.WriteAppSetting(Constants.WaitForStateTimeoutAppSettingsKey, this.WaitForStateTimeout.ToString());

            this.WriteAppSetting(Constants.PollRateAppSettingsKey, this.PollRate.ToString());

            this.WriteAppSetting(Constants.RunningIconAppSettingKey, this.RunningIconPath);

            this.WriteAppSetting(Constants.StoppedIconAppSettingKey, this.StoppedIconPath);

            this.WriteAppSetting(Constants.PausedIconAppSettingKey, this.PausedIconPath);

            this.WriteAppSetting(Constants.StartingIconAppSettingKey, this.StartingIconPath);

            this.WriteAppSetting(Constants.StoppingIconAppSettingKey, this.StoppingIconPath);

            this.WriteAppSetting(Constants.PausedIconAppSettingKey, this.PausingIconPath);

            this.WriteAppSetting(Constants.ResumingIconAppSettingKey, this.UnpausingIconPath);

            this.applicationConfiguration.Save();
        }

        private string ReadAppSetting(string appSettingKey)
        {
            return this.applicationConfiguration.AppSettings.Settings[appSettingKey].Value;
        }

        private void WriteAppSetting(string appSettingKey, string newAppSettingValue)
        {
            this.applicationConfiguration.AppSettings.Settings[appSettingKey].Value = newAppSettingValue;
        }
    }
}