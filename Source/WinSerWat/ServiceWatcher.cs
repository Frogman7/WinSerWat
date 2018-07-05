using System;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;

namespace WinSerWat
{
    public class ServiceWatcher : ApplicationContext
    {
        protected NotifyIcon systemTrayIcon;

        protected ServiceController serviceController;

        protected WinSerWatContextMenuManager winSerWatContextMenuManager;

        protected IconSettings iconSettings;

        private System.Threading.Timer statusCheckTimer;

        private TimeSpan pollServiceStatusInterval;

        private volatile ServiceStatus lastStatus;

        private bool started;

        private object serviceControllerLock;

        public TimeSpan WaitForStateChangeTimeout { get; set; }

        public TimeSpan PollServiceStatusInterval
        {
            get => this.pollServiceStatusInterval;
            set
            {
                if (this.pollServiceStatusInterval != value)
                {
                    this.pollServiceStatusInterval = value;

                    if (started)
                    {
                        this.statusCheckTimer.Change(this.pollServiceStatusInterval, this.pollServiceStatusInterval);
                    }
                }
            }
        }

        public ServiceWatcher(string serviceName,
            IconSettings iconSettings,
            WinSerWatContextMenuManager winSerWatContextMenuManager = null,
            bool autoStart = false)
        {
            this.iconSettings = iconSettings;

            this.winSerWatContextMenuManager = winSerWatContextMenuManager ?? new WinSerWatContextMenuManager();

            var services = ServiceController.GetServices();

            this.serviceController = services.FirstOrDefault(service => service.ServiceName.Equals(serviceName));

            if (this.serviceController == null)
            {
                throw new ServiceNotFoundException(serviceName);
            }

            this.lastStatus = ServiceStatusHelper.ConvertFromServiceControllerStatus(this.serviceController.Status);

            this.systemTrayIcon = new NotifyIcon();
            systemTrayIcon.Text = "Service Monitor";
            systemTrayIcon.Icon = this.iconSettings.GetAppropriateIcon(this.lastStatus);

            this.InitializeContextMenuManager();

            systemTrayIcon.ContextMenu = this.winSerWatContextMenuManager.ContextMenu;

            systemTrayIcon.Visible = true;

            this.serviceControllerLock = new object();

            this.started = false;

            if (autoStart)
            {
                this.StartWatching();
            }
        }

        public virtual void StartWatching()
        {
            if (!this.started)
            {
                this.statusCheckTimer = new System.Threading.Timer((state) =>
                {
                    this.CheckForStatusChange();
                }, null, this.pollServiceStatusInterval, this.pollServiceStatusInterval);

                this.started = true;
            }     
        }

        public virtual void StopWatching()
        {
            if (this.started)
            {
                this.statusCheckTimer.Dispose();

                this.statusCheckTimer = null;

                this.started = false;
            }
        }

        public virtual void ChangeService(string serviceName)
        {
            bool previouslyStarted = this.started;

            if (started)
            {
                this.StopWatching();
            }

            var services = ServiceController.GetServices();

            lock (this.serviceControllerLock)
            {
                this.serviceController = services.FirstOrDefault(service => service.ServiceName.Equals(serviceName));

                if (this.serviceController == null)
                {
                    throw new ServiceNotFoundException(serviceName);
                }
            }

            this.CheckForStatusChange();

            if (previouslyStarted)
            {
                this.StartWatching();
            }
        }

        protected virtual void InitializeContextMenuManager()
        {
            this.winSerWatContextMenuManager.AddWinSerWatMenuItem(
                new WinSerWatMenuItem("Start Service",
                () => this.StartService(),
                () => this.lastStatus == ServiceStatus.Stopped));

            if (this.serviceController.CanPauseAndContinue)
            {
                this.winSerWatContextMenuManager.AddWinSerWatMenuItem(
                    new WinSerWatMenuItem("Pause Service",
                    () => this.PauseService(),
                    () => ((this.lastStatus == ServiceStatus.Running) && (this.serviceController.CanPauseAndContinue))));
                this.winSerWatContextMenuManager.AddWinSerWatMenuItem(
                    new WinSerWatMenuItem("Continue Service",
                    () => this.ContinueService(),
                    () => ((this.lastStatus == ServiceStatus.Paused) && (this.serviceController.CanPauseAndContinue))));
            }

            this.winSerWatContextMenuManager.AddWinSerWatMenuItem(
                new WinSerWatMenuItem("Stop Service",
                () => this.StopService(),
                () => this.lastStatus == ServiceStatus.Running));

            this.winSerWatContextMenuManager.AddWinSerWatMenuItem(
                new WinSerWatMenuItem("Restart Service",
                () => this.RestartService(),
                () => this.lastStatus == ServiceStatus.Running));

            this.winSerWatContextMenuManager.AddWinSerWatMenuItem(
                new WinSerWatMenuItem("Exit", () => Application.Exit()));

            this.winSerWatContextMenuManager.UpdateContextMenu();
        }

        protected virtual void CheckForStatusChange()
        {
            ServiceStatus currentStatus = 0;

            lock (this.serviceControllerLock)
            {
                this.serviceController.Refresh();
                currentStatus = ServiceStatusHelper.ConvertFromServiceControllerStatus(this.serviceController.Status);
            }

            if (this.lastStatus != currentStatus)
            {
                // If the ICON is null, we'll just leave the last icon
                var newIcon = this.iconSettings.GetAppropriateIcon(currentStatus);

                if (newIcon != null)
                {
                    this.systemTrayIcon.Icon = newIcon;
                }

                this.lastStatus = currentStatus;

                this.winSerWatContextMenuManager.UpdateContextMenu();
            }
        }

        private void RestartService()
        {
            lock (this.serviceControllerLock)
            {
                this.serviceController.Stop();

                this.serviceController.WaitForStatus(ServiceControllerStatus.Stopped);

                this.serviceController.Start();
            }
        }

        private void StopService()
        {
            lock (this.serviceControllerLock)
            {
                this.serviceController.Stop();
            }
        }

        private void StartService()
        {
            lock (this.serviceControllerLock)
            {
                this.serviceController.Start();
            }
        }

        private void PauseService()
        {
            lock (this.serviceControllerLock)
            {
                this.serviceController.Pause();
            }
        }

        private void ContinueService()
        {
            lock (this.serviceControllerLock)
            {
                this.serviceController.Continue();
            }
        }
    }
}