using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ContextMenuItem class
    /// </summary>
    public partial class ContextMenuItem : NavigationItem<ContextMenuItem>, INavigationItemContainer<ContextMenuItem>
    {
        public ContextMenuItem()
        {
            Items = new List<ContextMenuItem>();
        }

        public IList<ContextMenuItem> Items
        {
            get;
            private set;
        }

        public bool Separator { get; set; }

        public ContextMenu ContextMenu { get; set; }
    }
}
