using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartXAxisNotesLabelBorderSettings class
    /// </summary>
    public partial class ChartXAxisNotesLabelBorderSettings<T> where T : class 
    {
        public string Color { get; set; }

        public ChartDashType? DashType { get; set; }

        public double? Width { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (DashType.HasValue)
            {
                settings["dashType"] = DashType?.Serialize();
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
