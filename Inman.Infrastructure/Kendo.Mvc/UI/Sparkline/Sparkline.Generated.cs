using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Sparkline component
    /// </summary>
    public partial class Sparkline<T> where T : class 
    {
        public double? PointWidth { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (PointWidth.HasValue)
            {
                settings["pointWidth"] = PointWidth;
            }

            return settings;
        }
    }
}
