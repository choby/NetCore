using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Chart component
    /// </summary>
    public partial class Chart<T> where T : class 
    {
        public bool? AutoBind { get; set; }

        public ChartAxisDefaultsSettings<T> AxisDefaults { get; } = new ChartAxisDefaultsSettings<T>();

        public List<ChartCategoryAxis<T>> CategoryAxis { get; set; } = new List<ChartCategoryAxis<T>>();

        public ChartChartAreaSettings<T> ChartArea { get; } = new ChartChartAreaSettings<T>();

        public ChartLegendSettings<T> Legend { get; } = new ChartLegendSettings<T>();

        public List<ChartPane<T>> Panes { get; set; } = new List<ChartPane<T>>();

        public ChartPannableSettings<T> Pannable { get; } = new ChartPannableSettings<T>();

        public ChartPdfSettings<T> Pdf { get; } = new ChartPdfSettings<T>();

        public ChartPlotAreaSettings<T> PlotArea { get; } = new ChartPlotAreaSettings<T>();

        public List<ChartSeries<T>> Series { get; set; } = new List<ChartSeries<T>>();

        public String[] SeriesColors { get; set; }

        public string Theme { get; set; }

        public ChartTitleSettings<T> Title { get; } = new ChartTitleSettings<T>();

        public ChartTooltipSettings<T> Tooltip { get; } = new ChartTooltipSettings<T>();

        public bool? Transitions { get; set; }

        public List<ChartValueAxis<T>> ValueAxis { get; set; } = new List<ChartValueAxis<T>>();

        public List<ChartXAxis<T>> XAxis { get; set; } = new List<ChartXAxis<T>>();

        public List<ChartYAxis<T>> YAxis { get; set; } = new List<ChartYAxis<T>>();

        public ChartZoomableSettings<T> Zoomable { get; } = new ChartZoomableSettings<T>();

        public RenderingMode? RenderAs { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            var axisDefaults = AxisDefaults.Serialize();
            if (axisDefaults.Any())
            {
                settings["axisDefaults"] = axisDefaults;
            }

            var categoryAxis = CategoryAxis.Select(i => i.Serialize());
            if (categoryAxis.Any())
            {
                settings["categoryAxis"] = categoryAxis;
            }

            var chartArea = ChartArea.Serialize();
            if (chartArea.Any())
            {
                settings["chartArea"] = chartArea;
            }

            var legend = Legend.Serialize();
            if (legend.Any())
            {
                settings["legend"] = legend;
            }

            var panes = Panes.Select(i => i.Serialize());
            if (panes.Any())
            {
                settings["panes"] = panes;
            }

            var pannable = Pannable.Serialize();
            if (pannable.Any())
            {
                settings["pannable"] = pannable;
            }
            else if (Pannable.Enabled.HasValue)
            {
                settings["pannable"] = Pannable.Enabled;
            }

            var pdf = Pdf.Serialize();
            if (pdf.Any())
            {
                settings["pdf"] = pdf;
            }

            var plotArea = PlotArea.Serialize();
            if (plotArea.Any())
            {
                settings["plotArea"] = plotArea;
            }

            var series = Series.Select(i => i.Serialize());
            if (series.Any())
            {
                settings["series"] = series;
            }

            if (SeriesColors?.Any() == true)
            {
                settings["seriesColors"] = SeriesColors;
            }

            if (Theme?.HasValue() == true)
            {
                settings["theme"] = Theme;
            }

            var title = Title.Serialize();
            if (title.Any())
            {
                settings["title"] = title;
            }

            var tooltip = Tooltip.Serialize();
            if (tooltip.Any())
            {
                settings["tooltip"] = tooltip;
            }

            if (Transitions.HasValue)
            {
                settings["transitions"] = Transitions;
            }

            var valueAxis = ValueAxis.Select(i => i.Serialize());
            if (valueAxis.Any())
            {
                settings["valueAxis"] = valueAxis;
            }

            var xAxis = XAxis.Select(i => i.Serialize());
            if (xAxis.Any())
            {
                settings["xAxis"] = xAxis;
            }

            var yAxis = YAxis.Select(i => i.Serialize());
            if (yAxis.Any())
            {
                settings["yAxis"] = yAxis;
            }

            var zoomable = Zoomable.Serialize();
            if (zoomable.Any())
            {
                settings["zoomable"] = zoomable;
            }
            else if (Zoomable.Enabled.HasValue)
            {
                settings["zoomable"] = Zoomable.Enabled;
            }

            if (RenderAs.HasValue)
            {
                settings["renderAs"] = RenderAs?.Serialize();
            }

            return settings;
        }
    }
}
