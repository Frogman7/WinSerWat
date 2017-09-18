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

        private ServiceControllerStatus lastStatus;

        private bool started;

        private object serviceControllerLock;

        public ServiceWatcher(string serviceName, IconSettings iconSettings, bool autoStart = false)
        {
            this.iconSettings = iconSettings;

            var services = ServiceController.GetServices();

            this.serviceController = services.FirstOrDefault(service => service.ServiceName.Equals(serviceName));

            if (this.serviceController == null)
            {
                throw new ServiceNotFoundException(serviceName);
            }

            this.lastStatus = this.serviceController.Status;

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
                }, null, this.iconSettings.PollServiceStatusInterval, this.iconSettings.PollServiceStatusInterval);

                this.started = true;
            }     
        }

        public virtual void StopWatching()
        {
            if (this.started)
            {
                this.statusCheckTimer.Dispose();

                this.statusCheckTimer = null;
            }
        }

        protected virtual void InitializeContextMenuManager()
        {
            this.winSerWatContextMenuManager = new WinSerWatContextMenuManager();

            this.winSerWatContextMenuManager.AddWinSerWatMenuItem(new WinSerWatMenuItem("Start Service", () => this.StartService(), ServiceStatus.Stopped));

            if (this.serviceController.CanPauseAndContinue)
            {
                this.winSerWatContextMenuManager.AddWinSerWatMenuItem(new WinSerWatMenuItem("Pause Service", () => this.PauseService(), ServiceStatus.Running));
                this.winSerWatContextMenuManager.AddWinSerWatMenuItem(new WinSerWatMenuItem("Continue Service", () => this.ContinueService(), ServiceStatus.Paused));
            }

            this.winSerWatContextMenuManager.AddWinSerWatMenuItem(new WinSerWatMenuItem("Stop Service", () => this.StopService(), ServiceStatus.Running));
            this.winSerWatContextMenuManager.AddWinSerWatMenuItem(new WinSerWatMenuItem("Restart Service", () => this.RestartService(), ServiceStatus.Running));

            this.winSerWatContextMenuManager.AddWinSerWatMenuItem(new WinSerWatMenuItem("Exit", () => Application.Exit(), ServiceStatusHelper.GetAllServiceStatus()));

            this.winSerWatContextMenuManager.UpdateContextMenu(ServiceStatusHelper.ConvertFromServiceControllerStatus(this.lastStatus));
        }

        protected virtual void CheckForStatusChange()
        {
            ServiceControllerStatus currentStatus = 0;

            lock (this.serviceControllerLock)
            {
                this.serviceController.Refresh();
                currentStatus = this.serviceController.Status;
            }

            if (this.lastStatus != currentStatus)
            {
                // If the ICON is null, we'll just leave the last icon
                var newIcon = this.iconSettings.GetAppropriateIcon(currentStatus);

                if (newIcon != null)
                {
                    this.systemTrayIcon.Icon = newIcon;
                }

                this.winSerWatContextMenuManager.UpdateContextMenu(ServiceStatusHelper.ConvertFromServiceControllerStatus(currentStatus));

                this.lastStatus = currentStatus;
            }
        }

        private void RestartService()
        {
            lock (this.serviceControllerLock)
            {
                this.serviceController.Stop();

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
