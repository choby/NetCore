using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartYAxisNotesSettings class
    /// </summary>
    public partial class ChartYAxisNotesSettings<T> where T : class 
    {
        public ChartNotePosition? Position { get; set; }

        public ChartYAxisNotesIconSettings<T> Icon { get; } = new ChartYAxisNotesIconSettings<T>();

        public ChartYAxisNotesLabelSettings<T> Label { get; } = new ChartYAxisNotesLabelSettings<T>();

        public ChartYAxisNotesLineSettings<T> Line { get; } = new ChartYAxisNotesLineSettings<T>();

        public ClientHandlerDescriptor Visual { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Position.HasValue)
            {
                settings["position"] = Position?.Serialize();
            }

            var icon = Icon.Serialize();
            if (icon.Any())
            {
                settings["icon"] = icon;
            }

            var label = Label.Serialize();
            if (label.Any())
            {
                settings["label"] = label;
            }

            var line = Line.Serialize();
            if (line.Any())
            {
                settings["line"] = line;
            }

            if (Visual?.HasValue() == true)
            {
                settings["visual"] = Visual;
            }

            return settings;
        }
    }
}
