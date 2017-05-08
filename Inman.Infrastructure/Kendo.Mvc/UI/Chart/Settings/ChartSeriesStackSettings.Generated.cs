using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesStackSettings class
    /// </summary>
    public partial class ChartSeriesStackSettings<T> where T : class 
    {
        public string Group { get; set; }

        public ChartStackType? Type { get; set; }

        public bool? Enabled { get; set; }

        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Group?.HasValue() == true)
            {
                settings["group"] = Group;
            }

            if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }

            return settings;
        }
    }
}
