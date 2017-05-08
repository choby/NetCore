using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSettingsSeries class
    /// </summary>
    public partial class StockChartNavigatorSettingsSeries<T> where T : class 
    {
        public string Type { get; set; }

        public ChartDashType? DashType { get; set; }

        public string HighField { get; set; }

        public string Field { get; set; }

        public string CategoryField { get; set; }

        public string Name { get; set; }

        public StockChartNavigatorSeriesHighlightSettings<T> Highlight { get; } = new StockChartNavigatorSeriesHighlightSettings<T>();

        public string Aggregate { get; set; }
        public ClientHandlerDescriptor AggregateHandler { get; set; }

        public string Axis { get; set; }

        public StockChartNavigatorSeriesBorderSettings<T> Border { get; } = new StockChartNavigatorSeriesBorderSettings<T>();

        public string CloseField { get; set; }

        public string Color { get; set; }

        public string ColorField { get; set; }

        public string DownColor { get; set; }

        public string DownColorField { get; set; }

        public double? Gap { get; set; }

        public StockChartNavigatorSeriesLabelsSettings<T> Labels { get; } = new StockChartNavigatorSeriesLabelsSettings<T>();

        public StockChartNavigatorSeriesLineSettings<T> Line { get; } = new StockChartNavigatorSeriesLineSettings<T>();

        public string LowField { get; set; }

        public StockChartNavigatorSeriesMarkersSettings<T> Markers { get; } = new StockChartNavigatorSeriesMarkersSettings<T>();

        public string MissingValues { get; set; }

        public string Style { get; set; }

        public double? Opacity { get; set; }

        public string OpenField { get; set; }

        public StockChartNavigatorSeriesOverlaySettings<T> Overlay { get; } = new StockChartNavigatorSeriesOverlaySettings<T>();

        public double? Spacing { get; set; }

        public StockChartNavigatorSeriesStackSettings<T> Stack { get; } = new StockChartNavigatorSeriesStackSettings<T>();

        public StockChartNavigatorSeriesTooltipSettings<T> Tooltip { get; } = new StockChartNavigatorSeriesTooltipSettings<T>();

        public double? Width { get; set; }


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (DashType.HasValue)
            {
                settings["dashType"] = DashType?.Serialize();
            }

            if (HighField?.HasValue() == true)
            {
                settings["highField"] = HighField;
            }

            if (Field?.HasValue() == true)
            {
                settings["field"] = Field;
            }

            if (CategoryField?.HasValue() == true)
            {
                settings["categoryField"] = CategoryField;
            }

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            var highlight = Highlight.Serialize();
            if (highlight.Any())
            {
                settings["highlight"] = highlight;
            }

            if (AggregateHandler?.HasValue() == true)
            {
                settings["aggregate"] = AggregateHandler;
            }
            else if (Aggregate?.HasValue() == true)
            {
               settings["aggregate"] = Aggregate;
            }


            if (Axis?.HasValue() == true)
            {
                settings["axis"] = Axis;
            }

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (CloseField?.HasValue() == true)
            {
                settings["closeField"] = CloseField;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (ColorField?.HasValue() == true)
            {
                settings["colorField"] = ColorField;
            }

            if (DownColor?.HasValue() == true)
            {
                settings["downColor"] = DownColor;
            }

            if (DownColorField?.HasValue() == true)
            {
                settings["downColorField"] = DownColorField;
            }

            if (Gap.HasValue)
            {
                settings["gap"] = Gap;
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

            if (LowField?.HasValue() == true)
            {
                settings["lowField"] = LowField;
            }

            var markers = Markers.Serialize();
            if (markers.Any())
            {
                settings["markers"] = markers;
            }

            if (MissingValues?.HasValue() == true)
            {
                settings["missingValues"] = MissingValues;
            }

            if (Style?.HasValue() == true)
            {
                settings["style"] = Style;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (OpenField?.HasValue() == true)
            {
                settings["openField"] = OpenField;
            }

            var overlay = Overlay.Serialize();
            if (overlay.Any())
            {
                settings["overlay"] = overlay;
            }

            if (Spacing.HasValue)
            {
                settings["spacing"] = Spacing;
            }

            var stack = Stack.Serialize();
            if (stack.Any())
            {
                settings["stack"] = stack;
            }
            else if (Stack.Enabled.HasValue)
            {
                settings["stack"] = Stack.Enabled;
            }

            var tooltip = Tooltip.Serialize();
            if (tooltip.Any())
            {
                settings["tooltip"] = tooltip;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
