using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartYAxisNotesIconSettings class
    /// </summary>
    public partial class ChartYAxisNotesIconSettings<T> where T : class 
    {
        public string Background { get; set; }

        public ChartYAxisNotesIconBorderSettings<T> Border { get; } = new ChartYAxisNotesIconBorderSettings<T>();

        public double? Size { get; set; }

        public string Type { get; set; }

        public bool? Visible { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            return settings;
        }
    }
}
