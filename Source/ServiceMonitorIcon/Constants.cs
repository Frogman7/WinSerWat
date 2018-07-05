using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceMonitorIcon
{
    internal class Constants
    {
        internal const string ServiceToWatchAppSettingsKey = "ServiceToWatch";

        internal const string PollRateAppSettingsKey = "PollRate";

        internal const string WaitForStateTimeoutAppSettingsKey = "WaitForStateTimeout";

        internal const string RunningIconAppSettingKey = "RunningIcon";

        internal const string StoppedIconAppSettingKey = "StoppedIcon";

        internal const string PausedIconAppSettingKey = "PausedIcon";

        internal const string StartingIconAppSettingKey = "StartingIcon";

        internal const string StoppingIconAppSettingKey = "StoppingIcon";

        internal const string PausingIconAppSettingKey = "PausingIcon";

        internal const string ResumingIconAppSettingKey = "ResumingIcon";

        internal const int DefaultPollRate = 1;

        internal const int DefaultWaitForStateTimeout = 15000;
    }
}