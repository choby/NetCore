using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesNotesSettings class
    /// </summary>
    public partial class ChartSeriesNotesSettings<T> where T : class 
    {
        public ChartSeriesNotesIconSettings<T> Icon { get; } = new ChartSeriesNotesIconSettings<T>();

        public ChartSeriesNotesLabelSettings<T> Label { get; } = new ChartSeriesNotesLabelSettings<T>();

        public ChartSeriesNotesLineSettings<T> Line { get; } = new ChartSeriesNotesLineSettings<T>();

        public ClientHandlerDescriptor Visual { get; set; }

        public ChartNotePosition? Position { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

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

            if (Position.HasValue)
            {
                settings["position"] = Position?.Serialize();
            }

            return settings;
        }
    }
}
