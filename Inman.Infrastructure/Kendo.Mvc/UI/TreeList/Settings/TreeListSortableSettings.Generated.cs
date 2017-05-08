using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListSortableSettings class
    /// </summary>
    public partial class TreeListSortableSettings<T> where T : class 
    {
        public bool? AllowUnsort { get; set; }

        public TreeListSortMode? Mode { get; set; }

        public bool? Enabled { get; set; }

        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AllowUnsort.HasValue)
            {
                settings["allowUnsort"] = AllowUnsort;
            }

            if (Mode.HasValue)
            {
                settings["mode"] = Mode?.Serialize();
            }

            return settings;
        }
    }
}
