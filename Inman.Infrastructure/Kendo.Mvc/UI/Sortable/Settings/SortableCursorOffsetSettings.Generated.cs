using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SortableCursorOffsetSettings class
    /// </summary>
    public partial class SortableCursorOffsetSettings 
    {
        public double? Left { get; set; }

        public double? Top { get; set; }


        public Sortable Sortable { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Left.HasValue)
            {
                settings["left"] = Left;
            }

            if (Top.HasValue)
            {
                settings["top"] = Top;
            }

            return settings;
        }
    }
}
