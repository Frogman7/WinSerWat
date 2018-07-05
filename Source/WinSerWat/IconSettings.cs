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

        public Icon GetAppropriateIcon(ServiceStatus serviceControllerStatus)
        {
            switch (serviceControllerStatus)
            {
                case ServiceStatus.Stopped:
                    return this.StoppedIcon;
                case ServiceStatus.StartPending:
                    return this.StartingIcon;
                case ServiceStatus.StopPending:
                    return this.StoppingIcon;
                case ServiceStatus.Running:
                    return this.RunningIcon;
                case ServiceStatus.ContinuePending:
                    return this.UnpausingIcon;
                case ServiceStatus.PausePending:
                    return this.PausingIcon;
                case ServiceStatus.Paused:
                    return this.PausedIcon;
                default:
                    throw new ArgumentOutOfRangeException(nameof(serviceControllerStatus));
            }
        }
    }
}