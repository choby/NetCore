using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartCategoryAxis class
    /// </summary>
    public partial class ChartCategoryAxis<T> where T : class 
    {
        public ChartCategoryAxisAutoBaseUnitStepsSettings<T> AutoBaseUnitSteps { get; } = new ChartCategoryAxisAutoBaseUnitStepsSettings<T>();

        public object[] AxisCrossingValue { get; set; }

        public string Background { get; set; }

        public int? BaseUnitStep { get; set; }

        public object[] Categories { get; set; }

        public string Color { get; set; }

        public ChartCategoryAxisCrosshairSettings<T> Crosshair { get; } = new ChartCategoryAxisCrosshairSettings<T>();

        public string Field { get; set; }

        public bool? Justify { get; set; }

        public ChartCategoryAxisLabelsSettings<T> Labels { get; } = new ChartCategoryAxisLabelsSettings<T>();

        public ChartCategoryAxisLineSettings<T> Line { get; } = new ChartCategoryAxisLineSettings<T>();

        public ChartCategoryAxisMajorGridLinesSettings<T> MajorGridLines { get; } = new ChartCategoryAxisMajorGridLinesSettings<T>();

        public ChartCategoryAxisMajorTicksSettings<T> MajorTicks { get; } = new ChartCategoryAxisMajorTicksSettings<T>();

        public object Max { get; set; }

        public double? MaxDateGroups { get; set; }

        public object Min { get; set; }

        public ChartCategoryAxisMinorGridLinesSettings<T> MinorGridLines { get; } = new ChartCategoryAxisMinorGridLinesSettings<T>();

        public ChartCategoryAxisMinorTicksSettings<T> MinorTicks { get; } = new ChartCategoryAxisMinorTicksSettings<T>();

        public string Name { get; set; }

        public string Pane { get; set; }

        public List<ChartCategoryAxisPlotBand<T>> PlotBands { get; set; } = new List<ChartCategoryAxisPlotBand<T>>();

        public bool? Reverse { get; set; }

        public bool? RoundToBaseUnit { get; set; }

        public ChartCategoryAxisSelectSettings<T> Select { get; } = new ChartCategoryAxisSelectSettings<T>();

        public double? StartAngle { get; set; }

        public ChartCategoryAxisTitleSettings<T> Title { get; } = new ChartCategoryAxisTitleSettings<T>();

        public bool? Visible { get; set; }

        public double? WeekStartDay { get; set; }

        public ChartCategoryAxisNotesSettings<T> Notes { get; } = new ChartCategoryAxisNotesSettings<T>();

        public ChartAxisBaseUnit? BaseUnit { get; set; }

        public ChartCategoryAxisType? Type { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var autoBaseUnitSteps = AutoBaseUnitSteps.Serialize();
            if (autoBaseUnitSteps.Any())
            {
                settings["autoBaseUnitSteps"] = autoBaseUnitSteps;
            }

            if (AxisCrossingValue?.Any() == true)
            {
                settings["axisCrossingValue"] = AxisCrossingValue;
            }

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            if (BaseUnitStep.HasValue)
            {
                settings["baseUnitStep"] = BaseUnitStep;
            }

            if (Categories?.Any() == true)
            {
                settings["categories"] = Categories;
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

            if (Field?.HasValue() == true)
            {
                settings["field"] = Field;
            }

            if (Justify.HasValue)
            {
                settings["justified"] = Justify;
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

            if (Max != null)
            {
                settings["max"] = Max;
            }

            if (MaxDateGroups.HasValue)
            {
                settings["maxDateGroups"] = MaxDateGroups;
            }

            if (Min != null)
            {
                settings["min"] = Min;
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

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
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

            if (RoundToBaseUnit.HasValue)
            {
                settings["roundToBaseUnit"] = RoundToBaseUnit;
            }

            var select = Select.Serialize();
            if (select.Any())
            {
                settings["select"] = select;
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

            if (WeekStartDay.HasValue)
            {
                settings["weekStartDay"] = WeekStartDay;
            }

            var notes = Notes.Serialize();
            if (notes.Any())
            {
                settings["notes"] = notes;
            }

            if (BaseUnit.HasValue)
            {
                settings["baseUnit"] = BaseUnit?.Serialize();
            }

            if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }

            return settings;
        }
    }
}
