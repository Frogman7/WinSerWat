using System;
using System.Windows.Forms;

namespace WinSerWat
{
    public class WinSerWatMenuItem
    {
        protected ServiceStatus enabledStatus;

        protected Func<bool> CheckEnabled;

        public MenuItem MenuItem { get; }

        public WinSerWatMenuItem(string menuItemText, Action action) :
            this(menuItemText, action, new Func<bool>(() => true))
        {
        }

        public WinSerWatMenuItem(string menuItemText, Action action, Func<bool> checkEnabled)
        {
            this.MenuItem = new MenuItem(menuItemText, (obj, args) => action());
            this.CheckEnabled = checkEnabled;
        }

        public void CheckForEnabledChange()
        {
            this.MenuItem.Visible = this.CheckEnabled();
        }
    }
}