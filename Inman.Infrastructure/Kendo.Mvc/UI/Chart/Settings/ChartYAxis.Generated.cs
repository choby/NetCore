using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartYAxis class
    /// </summary>
    public partial class ChartYAxis<T> where T : class 
    {
        public object[] AxisCrossingValue { get; set; }

        public string Background { get; set; }

        public string BaseUnit { get; set; }

        public string Color { get; set; }

        public ChartYAxisCrosshairSettings<T> Crosshair { get; } = new ChartYAxisCrosshairSettings<T>();

        public ChartYAxisLabelsSettings<T> Labels { get; } = new ChartYAxisLabelsSettings<T>();

        public ChartYAxisLineSettings<T> Line { get; } = new ChartYAxisLineSettings<T>();

        public ChartYAxisMajorGridLinesSettings<T> MajorGridLines { get; } = new ChartYAxisMajorGridLinesSettings<T>();

        public ChartYAxisMinorGridLinesSettings<T> MinorGridLines { get; } = new ChartYAxisMinorGridLinesSettings<T>();

        public ChartYAxisMinorTicksSettings<T> MinorTicks { get; } = new ChartYAxisMinorTicksSettings<T>();

        public ChartYAxisMajorTicksSettings<T> MajorTicks { get; } = new ChartYAxisMajorTicksSettings<T>();

        public double? MajorUnit { get; set; }

        public object Max { get; set; }

        public object Min { get; set; }

        public double? MinorUnit { get; set; }

        public string Name { get; set; }

        public bool? NarrowRange { get; set; }

        public string Pane { get; set; }

        public List<ChartYAxisPlotBand<T>> PlotBands { get; set; } = new List<ChartYAxisPlotBand<T>>();

        public bool? Reverse { get; set; }

        public ChartYAxisTitleSettings<T> Title { get; } = new ChartYAxisTitleSettings<T>();

        public string Type { get; set; }

        public bool? Visible { get; set; }

        public ChartYAxisNotesSettings<T> Notes { get; } = new ChartYAxisNotesSettings<T>();


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

            if (BaseUnit?.HasValue() == true)
            {
                settings["baseUnit"] = BaseUnit;
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

            var majorTicks = MajorTicks.Serialize();
            if (majorTicks.Any())
            {
                settings["majorTicks"] = majorTicks;
            }

            if (MajorUnit.HasValue)
            {
                settings["majorUnit"] = MajorUnit;
            }

            if (Max != null)
            {
                settings["max"] = Max;
            }

            if (Min != null)
            {
                settings["min"] = Min;
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
