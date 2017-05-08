using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeries class
    /// </summary>
    public partial class ChartSeries<T> where T : class 
    {
        public string Axis { get; set; }

        public ChartSeriesBorderSettings<T> Border { get; } = new ChartSeriesBorderSettings<T>();

        public string CategoryAxis { get; set; }

        public string CategoryField { get; set; }

        public string CloseField { get; set; }

        public string Color { get; set; }
        public ClientHandlerDescriptor ColorHandler { get; set; }

        public string ColorField { get; set; }

        public ChartSeriesConnectorsSettings<T> Connectors { get; } = new ChartSeriesConnectorsSettings<T>();

        public string CurrentField { get; set; }

        public ChartDashType? DashType { get; set; }

        public string DownColor { get; set; }
        public ClientHandlerDescriptor DownColorHandler { get; set; }

        public string DownColorField { get; set; }

        public double? SegmentSpacing { get; set; }

        public string SummaryField { get; set; }

        public double? NeckRatio { get; set; }

        public bool? DynamicSlope { get; set; }

        public bool? DynamicHeight { get; set; }

        public ChartSeriesErrorBarsSettings<T> ErrorBars { get; } = new ChartSeriesErrorBarsSettings<T>();

        public string ErrorLowField { get; set; }

        public string ErrorHighField { get; set; }

        public string XErrorLowField { get; set; }

        public string XErrorHighField { get; set; }

        public string YErrorLowField { get; set; }

        public string YErrorHighField { get; set; }

        public string ExplodeField { get; set; }

        public string Field { get; set; }

        public string FromField { get; set; }

        public string ToField { get; set; }

        public string NoteTextField { get; set; }

        public string LowerField { get; set; }

        public string Q1Field { get; set; }

        public string MedianField { get; set; }

        public string Q3Field { get; set; }

        public string UpperField { get; set; }

        public string MeanField { get; set; }

        public string OutliersField { get; set; }

        public double? Gap { get; set; }

        public string HighField { get; set; }

        public ChartSeriesHighlightSettings<T> Highlight { get; } = new ChartSeriesHighlightSettings<T>();

        public double? HoleSize { get; set; }

        public ChartSeriesLabelsSettings<T> Labels { get; } = new ChartSeriesLabelsSettings<T>();

        public ChartSeriesLineSettings<T> Line { get; } = new ChartSeriesLineSettings<T>();

        public string LowField { get; set; }

        public ChartSeriesMarginSettings<T> Margin { get; } = new ChartSeriesMarginSettings<T>();

        public ChartSeriesMarkersSettings<T> Markers { get; } = new ChartSeriesMarkersSettings<T>();

        public ChartSeriesOutliersSettings<T> Outliers { get; } = new ChartSeriesOutliersSettings<T>();

        public ChartSeriesExtremesSettings<T> Extremes { get; } = new ChartSeriesExtremesSettings<T>();

        public double? MaxSize { get; set; }

        public double? MinSize { get; set; }

        public string Name { get; set; }

        public string NegativeColor { get; set; }

        public ChartSeriesNegativeValuesSettings<T> NegativeValues { get; } = new ChartSeriesNegativeValuesSettings<T>();

        public double? Opacity { get; set; }

        public string OpenField { get; set; }

        public ChartSeriesOverlaySettings<T> Overlay { get; } = new ChartSeriesOverlaySettings<T>();

        public double? Padding { get; set; }

        public double? Size { get; set; }

        public string SizeField { get; set; }

        public double? Spacing { get; set; }

        public ChartSeriesStackSettings<T> Stack { get; } = new ChartSeriesStackSettings<T>();

        public double? StartAngle { get; set; }

        public ChartSeriesTargetSettings<T> Target { get; } = new ChartSeriesTargetSettings<T>();

        public string TargetField { get; set; }

        public ChartSeriesTooltipSettings<T> Tooltip { get; } = new ChartSeriesTooltipSettings<T>();

        public string Type { get; set; }

        public bool? Visible { get; set; }

        public bool? VisibleInLegend { get; set; }

        public string VisibleInLegendField { get; set; }

        public ClientHandlerDescriptor Visual { get; set; }

        public double? Width { get; set; }

        public string XAxis { get; set; }

        public string XField { get; set; }

        public string YAxis { get; set; }

        public string YField { get; set; }

        public ChartSeriesNotesSettings<T> Notes { get; } = new ChartSeriesNotesSettings<T>();

        public double? ZIndex { get; set; }

        public ChartSeriesAggregate? Aggregate { get; set; }
        public ClientHandlerDescriptor AggregateHandler { get; set; }

        public ChartSeriesMissingValues? MissingValues { get; set; }

        public ChartSeriesStyle? Style { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Axis?.HasValue() == true)
            {
                settings["axis"] = Axis;
            }

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (CategoryAxis?.HasValue() == true)
            {
                settings["categoryAxis"] = CategoryAxis;
            }

            if (CategoryField?.HasValue() == true)
            {
                settings["categoryField"] = CategoryField;
            }

            if (CloseField?.HasValue() == true)
            {
                settings["closeField"] = CloseField;
            }

            if (ColorHandler?.HasValue() == true)
            {
                settings["color"] = ColorHandler;
            }
            else if (Color?.HasValue() == true)
            {
               settings["color"] = Color;
            }


            if (ColorField?.HasValue() == true)
            {
                settings["colorField"] = ColorField;
            }

            var connectors = Connectors.Serialize();
            if (connectors.Any())
            {
                settings["connectors"] = connectors;
            }

            if (CurrentField?.HasValue() == true)
            {
                settings["currentField"] = CurrentField;
            }

            if (DashType.HasValue)
            {
                settings["dashType"] = DashType?.Serialize();
            }

            if (DownColorHandler?.HasValue() == true)
            {
                settings["downColor"] = DownColorHandler;
            }
            else if (DownColor?.HasValue() == true)
            {
               settings["downColor"] = DownColor;
            }


            if (DownColorField?.HasValue() == true)
            {
                settings["downColorField"] = DownColorField;
            }

            if (SegmentSpacing.HasValue)
            {
                settings["segmentSpacing"] = SegmentSpacing;
            }

            if (SummaryField?.HasValue() == true)
            {
                settings["summaryField"] = SummaryField;
            }

            if (NeckRatio.HasValue)
            {
                settings["neckRatio"] = NeckRatio;
            }

            if (DynamicSlope.HasValue)
            {
                settings["dynamicSlope"] = DynamicSlope;
            }

            if (DynamicHeight.HasValue)
            {
                settings["dynamicHeight"] = DynamicHeight;
            }

            var errorBars = ErrorBars.Serialize();
            if (errorBars.Any())
            {
                settings["errorBars"] = errorBars;
            }

            if (ErrorLowField?.HasValue() == true)
            {
                settings["errorLowField"] = ErrorLowField;
            }

            if (ErrorHighField?.HasValue() == true)
            {
                settings["errorHighField"] = ErrorHighField;
            }

            if (XErrorLowField?.HasValue() == true)
            {
                settings["xErrorLowField"] = XErrorLowField;
            }

            if (XErrorHighField?.HasValue() == true)
            {
                settings["xErrorHighField"] = XErrorHighField;
            }

            if (YErrorLowField?.HasValue() == true)
            {
                settings["yErrorLowField"] = YErrorLowField;
            }

            if (YErrorHighField?.HasValue() == true)
            {
                settings["yErrorHighField"] = YErrorHighField;
            }

            if (ExplodeField?.HasValue() == true)
            {
                settings["explodeField"] = ExplodeField;
            }

            if (Field?.HasValue() == true)
            {
                settings["field"] = Field;
            }

            if (FromField?.HasValue() == true)
            {
                settings["fromField"] = FromField;
            }

            if (ToField?.HasValue() == true)
            {
                settings["toField"] = ToField;
            }

            if (NoteTextField?.HasValue() == true)
            {
                settings["noteTextField"] = NoteTextField;
            }

            if (LowerField?.HasValue() == true)
            {
                settings["lowerField"] = LowerField;
            }

            if (Q1Field?.HasValue() == true)
            {
                settings["q1Field"] = Q1Field;
            }

            if (MedianField?.HasValue() == true)
            {
                settings["medianField"] = MedianField;
            }

            if (Q3Field?.HasValue() == true)
            {
                settings["q3Field"] = Q3Field;
            }

            if (UpperField?.HasValue() == true)
            {
                settings["upperField"] = UpperField;
            }

            if (MeanField?.HasValue() == true)
            {
                settings["meanField"] = MeanField;
            }

            if (OutliersField?.HasValue() == true)
            {
                settings["outliersField"] = OutliersField;
            }

            if (Gap.HasValue)
            {
                settings["gap"] = Gap;
            }

            if (HighField?.HasValue() == true)
            {
                settings["highField"] = HighField;
            }

            var highlight = Highlight.Serialize();
            if (highlight.Any())
            {
                settings["highlight"] = highlight;
            }

            if (HoleSize.HasValue)
            {
                settings["holeSize"] = HoleSize;
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

            var margin = Margin.Serialize();
            if (margin.Any())
            {
                settings["margin"] = margin;
            }

            var markers = Markers.Serialize();
            if (markers.Any())
            {
                settings["markers"] = markers;
            }

            var outliers = Outliers.Serialize();
            if (outliers.Any())
            {
                settings["outliers"] = outliers;
            }

            var extremes = Extremes.Serialize();
            if (extremes.Any())
            {
                settings["extremes"] = extremes;
            }

            if (MaxSize.HasValue)
            {
                settings["maxSize"] = MaxSize;
            }

            if (MinSize.HasValue)
            {
                settings["minSize"] = MinSize;
            }

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            if (NegativeColor?.HasValue() == true)
            {
                settings["negativeColor"] = NegativeColor;
            }

            var negativeValues = NegativeValues.Serialize();
            if (negativeValues.Any())
            {
                settings["negativeValues"] = negativeValues;
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

            if (Padding.HasValue)
            {
                settings["padding"] = Padding;
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            if (SizeField?.HasValue() == true)
            {
                settings["sizeField"] = SizeField;
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

            if (StartAngle.HasValue)
            {
                settings["startAngle"] = StartAngle;
            }

            var target = Target.Serialize();
            if (target.Any())
            {
                settings["target"] = target;
            }

            if (TargetField?.HasValue() == true)
            {
                settings["targetField"] = TargetField;
            }

            var tooltip = Tooltip.Serialize();
            if (tooltip.Any())
            {
                settings["tooltip"] = tooltip;
            }

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            if (VisibleInLegend.HasValue)
            {
                settings["visibleInLegend"] = VisibleInLegend;
            }

            if (VisibleInLegendField?.HasValue() == true)
            {
                settings["visibleInLegendField"] = VisibleInLegendField;
            }

            if (Visual?.HasValue() == true)
            {
                settings["visual"] = Visual;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            if (XAxis?.HasValue() == true)
            {
                settings["xAxis"] = XAxis;
            }

            if (XField?.HasValue() == true)
            {
                settings["xField"] = XField;
            }

            if (YAxis?.HasValue() == true)
            {
                settings["yAxis"] = YAxis;
            }

            if (YField?.HasValue() == true)
            {
                settings["yField"] = YField;
            }

            var notes = Notes.Serialize();
            if (notes.Any())
            {
                settings["notes"] = notes;
            }

            if (ZIndex.HasValue)
            {
                settings["zIndex"] = ZIndex;
            }

            if (AggregateHandler?.HasValue() == true)
            {
                settings["aggregate"] = AggregateHandler;
            }
            else if (Aggregate.HasValue)
            {
                settings["aggregate"] = Aggregate?.Serialize();
            }


            if (MissingValues.HasValue)
            {
                settings["missingValues"] = MissingValues?.Serialize();
            }

            if (Style.HasValue)
            {
                settings["style"] = Style?.Serialize();
            }

            return settings;
        }
    }
}
