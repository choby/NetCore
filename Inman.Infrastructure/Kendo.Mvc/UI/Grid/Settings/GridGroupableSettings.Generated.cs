using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridGroupableSettings class
    /// </summary>
    public partial class GridGroupableSettings<T> where T : class 
    {
        public bool? Enabled { get; set; }

        public bool? ShowFooter { get; set; }


        public Grid<T> Grid { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Enabled.HasValue)
            {
                settings["enabled"] = Enabled;
            }

            if (ShowFooter.HasValue)
            {
                settings["showFooter"] = ShowFooter;
            }

            return settings;
        }
    }
}
