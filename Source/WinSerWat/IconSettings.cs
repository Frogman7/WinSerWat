using System;
using System.Drawing;
using System.ServiceProcess;

namespace WinSerWat
{
    public class IconSettings
    {
        public Icon RunningIcon { get; set; }

        public Icon StoppedIcon { get; set; }

        public Icon StartingIcon { get; set; }

        public Icon StoppingIcon { get; set; }

        public Icon PausedIcon { get; set; }

        public Icon PausingIcon { get; set; }

        public Icon UnpausingIcon { get; set; }

        public TimeSpan PollServiceStatusInterval { get; set; }

        public Icon GetAppropriateIcon(ServiceControllerStatus serviceControllerStatus)
        {
            switch (serviceControllerStatus)
            {
                case ServiceControllerStatus.Stopped:
                    return this.StoppedIcon;
                case ServiceControllerStatus.StartPending:
                    return this.StartingIcon;
                case ServiceControllerStatus.StopPending:
                    return this.StoppingIcon;
                case ServiceControllerStatus.Running:
                    return this.RunningIcon;
                case ServiceControllerStatus.ContinuePending:
                    return this.UnpausingIcon;
                case ServiceControllerStatus.PausePending:
                    return this.PausingIcon;
                case ServiceControllerStatus.Paused:
                    return this.PausedIcon;
                default:
                    throw new ArgumentOutOfRangeException(nameof(serviceControllerStatus));
            }
        }
    }
}
