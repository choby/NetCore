using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorCategoryAxisSettings class
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisSettings<T> where T : class 
    {
        public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettings<T> AutoBaseUnitSteps { get; } = new StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettings<T>();

        public object[] AxisCrossingValue { get; set; }

        public string Background { get; set; }

        public int? BaseUnitStep { get; set; }

        public object[] Categories { get; set; }

        public string Color { get; set; }

        public StockChartNavigatorCategoryAxisCrosshairSettings<T> Crosshair { get; } = new StockChartNavigatorCategoryAxisCrosshairSettings<T>();

        public string Field { get; set; }

        public bool? Justified { get; set; }

        public StockChartNavigatorCategoryAxisLabelsSettings<T> Labels { get; } = new StockChartNavigatorCategoryAxisLabelsSettings<T>();

        public StockChartNavigatorCategoryAxisLineSettings<T> Line { get; } = new StockChartNavigatorCategoryAxisLineSettings<T>();

        public StockChartNavigatorCategoryAxisMajorGridLinesSettings<T> MajorGridLines { get; } = new StockChartNavigatorCategoryAxisMajorGridLinesSettings<T>();

        public StockChartNavigatorCategoryAxisMajorTicksSettings<T> MajorTicks { get; } = new StockChartNavigatorCategoryAxisMajorTicksSettings<T>();

        public object Max { get; set; }

        public double? MaxDateGroups { get; set; }

        public object Min { get; set; }

        public StockChartNavigatorCategoryAxisMinorGridLinesSettings<T> MinorGridLines { get; } = new StockChartNavigatorCategoryAxisMinorGridLinesSettings<T>();

        public StockChartNavigatorCategoryAxisMinorTicksSettings<T> MinorTicks { get; } = new StockChartNavigatorCategoryAxisMinorTicksSettings<T>();

        public List<StockChartNavigatorCategoryAxisSettingsPlotBand<T>> PlotBands { get; set; } = new List<StockChartNavigatorCategoryAxisSettingsPlotBand<T>>();

        public bool? Reverse { get; set; }

        public bool? RoundToBaseUnit { get; set; }

        public StockChartNavigatorCategoryAxisTitleSettings<T> Title { get; } = new StockChartNavigatorCategoryAxisTitleSettings<T>();

        public bool? Visible { get; set; }

        public double? WeekStartDay { get; set; }

        public StockChartNavigatorCategoryAxisNotesSettings<T> Notes { get; } = new StockChartNavigatorCategoryAxisNotesSettings<T>();

        public ChartAxisBaseUnit? BaseUnit { get; set; }

        public ChartCategoryAxisType? Type { get; set; }


        public StockChart<T> StockChart { get; set; }

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

            if (Justified.HasValue)
            {
                settings["justified"] = Justified;
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
