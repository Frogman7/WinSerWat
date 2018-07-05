using System;
using System.ServiceProcess;

namespace WinSerWat
{
    [Flags]
    public enum ServiceStatus
    {
        Stopped = 1,
        StartPending = 2,
        StopPending = 4,
        Running = 8,
        ContinuePending = 16,
        PausePending = 32,
        Paused = 64
    }

    public class ServiceStatusHelper
    {
        public static ServiceStatus ConvertFromServiceControllerStatus(ServiceControllerStatus serviceControllerStatus)
        {
            switch (serviceControllerStatus)
            {
                case ServiceControllerStatus.Stopped:
                    return ServiceStatus.Stopped;
                case ServiceControllerStatus.StartPending:
                    return ServiceStatus.StartPending;
                case ServiceControllerStatus.StopPending:
                    return ServiceStatus.StopPending;
                case ServiceControllerStatus.Running:
                    return ServiceStatus.Running;
                case ServiceControllerStatus.ContinuePending:
                    return ServiceStatus.ContinuePending;
                case ServiceControllerStatus.PausePending:
                    return ServiceStatus.PausePending;
                case ServiceControllerStatus.Paused:
                    return ServiceStatus.Paused;
                default:
                    throw new ArgumentOutOfRangeException(nameof(serviceControllerStatus));
            }
        }

        public static ServiceStatus GetAllServiceStatus()
        {
            return (ServiceStatus)127;
        }
    }
}