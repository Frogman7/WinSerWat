using System;
using System.Windows.Forms;

namespace WinSerWat
{
    public class WinSerWatMenuItem
    {
        public MenuItem MenuItem { get; }

        protected ServiceStatus enabledStatus;

        public WinSerWatMenuItem(string menuItemText, Action action, ServiceStatus enabledStatus)
        {
            this.MenuItem = new MenuItem(menuItemText, (obj, args) => action());
            this.enabledStatus = enabledStatus;
        }

        public WinSerWatMenuItem(MenuItem menuItem, ServiceStatus enabledStatus)
        {
            this.MenuItem = menuItem;
            this.enabledStatus = enabledStatus;
        }

        public void StateChanged(ServiceStatus serviceStatus)
        {
            if ((enabledStatus & serviceStatus) > 0)
            {
                this.MenuItem.Visible = true;
            }
            else
            {
                this.MenuItem.Visible = false;
            }
        }
    }
}
