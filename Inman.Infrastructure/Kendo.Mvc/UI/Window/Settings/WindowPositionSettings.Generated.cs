using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI WindowPositionSettings class
    /// </summary>
    public partial class WindowPositionSettings 
    {
        public double? Top { get; set; }

        public double? Left { get; set; }


        public Window Window { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Top.HasValue)
            {
                settings["top"] = Top;
            }

            if (Left.HasValue)
            {
                settings["left"] = Left;
            }

            return settings;
        }
    }
}
