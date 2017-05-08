using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TabStripScrollableSettings class
    /// </summary>
    public partial class TabStripScrollableSettings 
    {
        public int? Distance { get; set; }

        public bool? Enabled { get; set; }

        public TabStrip TabStrip { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Distance.HasValue)
            {
                settings["distance"] = Distance;
            }

            return settings;
        }
    }
}
