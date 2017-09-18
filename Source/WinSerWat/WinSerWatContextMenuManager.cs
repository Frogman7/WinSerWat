using System.Collections.Generic;
using System.Windows.Forms;

namespace WinSerWat
{
    public class WinSerWatContextMenuManager
    {
        protected IList<WinSerWatMenuItem> winSerWatMenuItems;

        protected ContextMenu contextMenu;

        protected object locker;

        public ContextMenu ContextMenu
        {
            get
            {
                return this.contextMenu;
            }
        }

        public WinSerWatContextMenuManager()
        {
            this.contextMenu = new ContextMenu();

            this.winSerWatMenuItems = new List<WinSerWatMenuItem>();

            this.locker = new object();
        }

        public void AddWinSerWatMenuItem(WinSerWatMenuItem winSerWatMenuItem)
        {
            lock (this.locker)
            {
                this.winSerWatMenuItems.Add(winSerWatMenuItem);
            }

            this.contextMenu.MenuItems.Add(winSerWatMenuItem.MenuItem);
        }

        public void UpdateContextMenu(ServiceStatus newServiceStatus)
        {
            lock (this.locker)
            {
                for (int index = 0; index < winSerWatMenuItems.Count; index++)
                {
                    winSerWatMenuItems[index].StateChanged(newServiceStatus);
                }
            }
        }
    }
}
