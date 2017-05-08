using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartAxisDefaultsSettings class
    /// </summary>
    public partial class ChartAxisDefaultsSettings<T> where T : class 
    {
        public string Background { get; set; }

        public string Color { get; set; }

        public ChartAxisDefaultsCrosshairSettings<T> Crosshair { get; } = new ChartAxisDefaultsCrosshairSettings<T>();

        public ChartAxisDefaultsLabelsSettings<T> Labels { get; } = new ChartAxisDefaultsLabelsSettings<T>();

        public ChartAxisDefaultsLineSettings<T> Line { get; } = new ChartAxisDefaultsLineSettings<T>();

        public ChartAxisDefaultsMajorGridLinesSettings<T> MajorGridLines { get; } = new ChartAxisDefaultsMajorGridLinesSettings<T>();

        public ChartAxisDefaultsMajorTicksSettings<T> MajorTicks { get; } = new ChartAxisDefaultsMajorTicksSettings<T>();

        public ChartAxisDefaultsMinorGridLinesSettings<T> MinorGridLines { get; } = new ChartAxisDefaultsMinorGridLinesSettings<T>();

        public ChartAxisDefaultsMinorTicksSettings<T> MinorTicks { get; } = new ChartAxisDefaultsMinorTicksSettings<T>();

        public bool? NarrowRange { get; set; }

        public string Pane { get; set; }

        public List<ChartAxisDefaultsSettingsPlotBand<T>> PlotBands { get; set; } = new List<ChartAxisDefaultsSettingsPlotBand<T>>();

        public bool? Reverse { get; set; }

        public double? StartAngle { get; set; }

        public ChartAxisDefaultsTitleSettings<T> Title { get; } = new ChartAxisDefaultsTitleSettings<T>();

        public bool? Visible { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            var crosshair = Crosshair.Serialize();
            if (crosshair.Any())
            {
                settings["crosshair"] = crosshair;
            }

            var labels = Labels.Serialize();
            if (labels.Any())
            {
                settings["labels"] = labels;
            }

            var line = Line.Serialize();
            if (line.Any())
            {
                settings["line"] = line;
            }

            var majorGridLines = MajorGridLines.Serialize();
            if (majorGridLines.Any())
            {
                settings["majorGridLines"] = majorGridLines;
            }

            var majorTicks = MajorTicks.Serialize();
            if (majorTicks.Any())
            {
                settings["majorTicks"] = majorTicks;
            }

            var minorGridLines = MinorGridLines.Serialize();
            if (minorGridLines.Any())
            {
                settings["minorGridLines"] = minorGridLines;
            }

            var minorTicks = MinorTicks.Serialize();
            if (minorTicks.Any())
            {
                settings["minorTicks"] = minorTicks;
            }

            if (NarrowRange.HasValue)
            {
                settings["narrowRange"] = NarrowRange;
            }

            if (Pane?.HasValue() == true)
            {
                settings["pane"] = Pane;
            }

            var plotBands = PlotBands.Select(i => i.Serialize());
            if (plotBands.Any())
            {
                settings["plotBands"] = plotBands;
            }

            if (Reverse.HasValue)
            {
                settings["reverse"] = Reverse;
            }

            if (StartAngle.HasValue)
            {
                settings["startAngle"] = StartAngle;
            }

            var title = Title.Serialize();
            if (title.Any())
            {
                settings["title"] = title;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            return settings;
        }
    }
}
