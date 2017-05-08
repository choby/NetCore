using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Defines the Chart series defaults settings
    /// </summary>
    public partial class ChartSeriesDefaultsSettings<T> where T : class
    {

        /// <summary>
        /// The Area series default settings.
        /// </summary>
        public ChartSeries<T> Area { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Bar series default settings.
        /// </summary>
        public ChartSeries<T> Bar { get; } = new ChartSeries<T>();

        /// <summary>
        /// The BoxPlot series default settings.
        /// </summary>
        public ChartSeries<T> BoxPlot { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Bubble series default settings.
        /// </summary>
        public ChartSeries<T> Bubble { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Bullet series default settings.
        /// </summary>
        public ChartSeries<T> Bullet { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Candlestick series default settings.
        /// </summary>
        public ChartSeries<T> Candlestick { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Column series default settings.
        /// </summary>
        public ChartSeries<T> Column { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Donut series default settings.
        /// </summary>
        public ChartSeries<T> Donut { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Funnel series default settings.
        /// </summary>
        public ChartSeries<T> Funnel { get; } = new ChartSeries<T>();

        /// <summary>
        /// The HorizontalWaterfall series default settings.
        /// </summary>
        public ChartSeries<T> HorizontalWaterfall { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Line series default settings.
        /// </summary>
        public ChartSeries<T> Line { get; } = new ChartSeries<T>();

        /// <summary>
        /// The OHLC series default settings.
        /// </summary>
        public ChartSeries<T> OHLC { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Pie series default settings.
        /// </summary>
        public ChartSeries<T> Pie { get; } = new ChartSeries<T>();

        /// <summary>
        /// The PolarArea series default settings.
        /// </summary>
        public ChartSeries<T> PolarArea { get; } = new ChartSeries<T>();

        /// <summary>
        /// The PolarLine series default settings.
        /// </summary>
        public ChartSeries<T> PolarLine { get; } = new ChartSeries<T>();

        /// <summary>
        /// The PolarScatter series default settings.
        /// </summary>
        public ChartSeries<T> PolarScatter { get; } = new ChartSeries<T>();

        /// <summary>
        /// The RadarArea series default settings.
        /// </summary>
        public ChartSeries<T> RadarArea { get; } = new ChartSeries<T>();

        /// <summary>
        /// The RadarColumn series default settings.
        /// </summary>
        public ChartSeries<T> RadarColumn { get; } = new ChartSeries<T>();

        /// <summary>
        /// The RadarLine series default settings.
        /// </summary>
        public ChartSeries<T> RadarLine { get; } = new ChartSeries<T>();

        /// <summary>
        /// The RangeBar series default settings.
        /// </summary>
        public ChartSeries<T> RangeBar { get; } = new ChartSeries<T>();

        /// <summary>
        /// The RangeColumn series default settings.
        /// </summary>
        public ChartSeries<T> RangeColumn { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Scatter series default settings.
        /// </summary>
        public ChartSeries<T> Scatter { get; } = new ChartSeries<T>();

        /// <summary>
        /// The ScatterLine series default settings.
        /// </summary>
        public ChartSeries<T> ScatterLine { get; } = new ChartSeries<T>();

        /// <summary>
        /// The VerticalArea series default settings.
        /// </summary>
        public ChartSeries<T> VerticalArea { get; } = new ChartSeries<T>();

        /// <summary>
        /// The VerticalBoxPlot series default settings.
        /// </summary>
        public ChartSeries<T> VerticalBoxPlot { get; } = new ChartSeries<T>();

        /// <summary>
        /// The VerticalBullet series default settings.
        /// </summary>
        public ChartSeries<T> VerticalBullet { get; } = new ChartSeries<T>();

        /// <summary>
        /// The VerticalLine series default settings.
        /// </summary>
        public ChartSeries<T> VerticalLine { get; } = new ChartSeries<T>();

        /// <summary>
        /// The Waterfall series default settings.
        /// </summary>
        public ChartSeries<T> Waterfall { get; } = new ChartSeries<T>();

        public IDictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            var area = Area.Serialize();
            if (area.Any())
            {
                settings["area"] = area;
            }

            var bar = Bar.Serialize();
            if (bar.Any())
            {
                settings["bar"] = bar;
            }

            var boxPlot = BoxPlot.Serialize();
            if (boxPlot.Any())
            {
                settings["boxPlot"] = boxPlot;
            }

            var bubble = Bubble.Serialize();
            if (bubble.Any())
            {
                settings["bubble"] = bubble;
            }

            var bullet = Bullet.Serialize();
            if (bullet.Any())
            {
                settings["bullet"] = bullet;
            }

            var candlestick = Candlestick.Serialize();
            if (candlestick.Any())
            {
                settings["candlestick"] = candlestick;
            }

            var column = Column.Serialize();
            if (column.Any())
            {
                settings["column"] = column;
            }

            var donut = Donut.Serialize();
            if (donut.Any())
            {
                settings["donut"] = donut;
            }

            var funnel = Funnel.Serialize();
            if (funnel.Any())
            {
                settings["funnel"] = funnel;
            }

            var horizontalWaterfall = HorizontalWaterfall.Serialize();
            if (horizontalWaterfall.Any())
            {
                settings["horizontalWaterfall"] = horizontalWaterfall;
            }

            var line = Line.Serialize();
            if (line.Any())
            {
                settings["line"] = line;
            }

            var ohlc = OHLC.Serialize();
            if (ohlc.Any())
            {
                settings["ohlc"] = ohlc;
            }

            var pie = Pie.Serialize();
            if (pie.Any())
            {
                settings["pie"] = pie;
            }

            var polarArea = PolarArea.Serialize();
            if (polarArea.Any())
            {
                settings["polarArea"] = polarArea;
            }

            var polarLine = PolarLine.Serialize();
            if (polarLine.Any())
            {
                settings["polarLine"] = polarLine;
            }

            var polarScatter = PolarScatter.Serialize();
            if (polarScatter.Any())
            {
                settings["polarScatter"] = polarScatter;
            }

            var radarArea = RadarArea.Serialize();
            if (radarArea.Any())
            {
                settings["radarArea"] = radarArea;
            }

            var radarColumn = RadarColumn.Serialize();
            if (radarColumn.Any())
            {
                settings["radarColumn"] = radarColumn;
            }

            var radarLine = RadarLine.Serialize();
            if (radarLine.Any())
            {
                settings["radarLine"] = radarLine;
            }

            var rangeBar = RangeBar.Serialize();
            if (rangeBar.Any())
            {
                settings["rangeBar"] = rangeBar;
            }

            var rangeColumn = RangeColumn.Serialize();
            if (rangeColumn.Any())
            {
                settings["rangeColumn"] = rangeColumn;
            }

            var scatter = Scatter.Serialize();
            if (scatter.Any())
            {
                settings["scatter"] = scatter;
            }

            var scatterLine = ScatterLine.Serialize();
            if (scatterLine.Any())
            {
                settings["scatterLine"] = scatterLine;
            }

            var verticalArea = VerticalArea.Serialize();
            if (verticalArea.Any())
            {
                settings["verticalArea"] = verticalArea;
            }

            var verticalBoxPlot = VerticalBoxPlot.Serialize();
            if (verticalBoxPlot.Any())
            {
                settings["verticalBoxPlot"] = verticalBoxPlot;
            }

            var verticalBullet = VerticalBullet.Serialize();
            if (verticalBullet.Any())
            {
                settings["verticalBullet"] = verticalBullet;
            }

            var verticalLine = VerticalLine.Serialize();
            if (verticalLine.Any())
            {
                settings["verticalLine"] = verticalLine;
            }

            var waterfall = Waterfall.Serialize();
            if (waterfall.Any())
            {
                settings["waterfall"] = waterfall;
            }

            return settings;
        }
    }
}
