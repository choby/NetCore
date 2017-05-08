using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartValueAxis class
    /// </summary>
    public partial class ChartValueAxis<T> where T : class 
    {
        public object[] AxisCrossingValue { get; set; }

        public string Background { get; set; }

        public string Color { get; set; }

        public ChartValueAxisCrosshairSettings<T> Crosshair { get; } = new ChartValueAxisCrosshairSettings<T>();

        public ChartValueAxisLabelsSettings<T> Labels { get; } = new ChartValueAxisLabelsSettings<T>();

        public ChartValueAxisLineSettings<T> Line { get; } = new ChartValueAxisLineSettings<T>();

        public ChartValueAxisMajorGridLinesSettings<T> MajorGridLines { get; } = new ChartValueAxisMajorGridLinesSettings<T>();

        public double? MajorUnit { get; set; }

        public double? Max { get; set; }

        public double? Min { get; set; }

        public ChartValueAxisMinorGridLinesSettings<T> MinorGridLines { get; } = new ChartValueAxisMinorGridLinesSettings<T>();

        public ChartValueAxisMajorTicksSettings<T> MajorTicks { get; } = new ChartValueAxisMajorTicksSettings<T>();

        public ChartValueAxisMinorTicksSettings<T> MinorTicks { get; } = new ChartValueAxisMinorTicksSettings<T>();

        public double? MinorUnit { get; set; }

        public string Name { get; set; }

        public bool? NarrowRange { get; set; }

        public string Pane { get; set; }

        public List<ChartValueAxisPlotBand<T>> PlotBands { get; set; } = new List<ChartValueAxisPlotBand<T>>();

        public bool? Reverse { get; set; }

        public ChartValueAxisTitleSettings<T> Title { get; } = new ChartValueAxisTitleSettings<T>();

        public string Type { get; set; }

        public bool? Visible { get; set; }

        public ChartValueAxisNotesSettings<T> Notes { get; } = new ChartValueAxisNotesSettings<T>();


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AxisCrossingValue?.Any() == true)
            {
                settings["axisCrossingValue"] = AxisCrossingValue;
            }

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

            if (MajorUnit.HasValue)
            {
                settings["majorUnit"] = MajorUnit;
            }

            if (Max.HasValue)
            {
                settings["max"] = Max;
            }

            if (Min.HasValue)
            {
                settings["min"] = Min;
            }

            var minorGridLines = MinorGridLines.Serialize();
            if (minorGridLines.Any())
            {
                settings["minorGridLines"] = minorGridLines;
            }

            var majorTicks = MajorTicks.Serialize();
            if (majorTicks.Any())
            {
                settings["majorTicks"] = majorTicks;
            }

            var minorTicks = MinorTicks.Serialize();
            if (minorTicks.Any())
            {
                settings["minorTicks"] = minorTicks;
            }

            if (MinorUnit.HasValue)
            {
                settings["minorUnit"] = MinorUnit;
            }

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
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

            var title = Title.Serialize();
            if (title.Any())
            {
                settings["title"] = title;
            }

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            var notes = Notes.Serialize();
            if (notes.Any())
            {
                settings["notes"] = notes;
            }

            return settings;
        }
    }
}
