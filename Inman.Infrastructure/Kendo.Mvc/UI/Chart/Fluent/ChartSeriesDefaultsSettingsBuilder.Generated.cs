using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring Chart series defaults settings
    /// </summary>
    public partial class ChartSeriesDefaultsSettingsBuilder<T> where T : class
    {
        public ChartSeriesDefaultsSettingsBuilder(ChartSeriesDefaultsSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesDefaultsSettings<T> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The area series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the area series settings.</param>
        public ChartSeriesBuilder<T> Area()
        {
            return new ChartSeriesBuilder<T>(Container.Area);
        }

        /// <summary>
        /// The bar series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the bar series settings.</param>
        public ChartSeriesBuilder<T> Bar()
        {
            return new ChartSeriesBuilder<T>(Container.Bar);
        }

        /// <summary>
        /// The boxPlot series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the boxPlot series settings.</param>
        public ChartSeriesBuilder<T> BoxPlot()
        {
            return new ChartSeriesBuilder<T>(Container.BoxPlot);
        }

        /// <summary>
        /// The bubble series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the bubble series settings.</param>
        public ChartSeriesBuilder<T> Bubble()
        {
            return new ChartSeriesBuilder<T>(Container.Bubble);
        }

        /// <summary>
        /// The bullet series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the bullet series settings.</param>
        public ChartSeriesBuilder<T> Bullet()
        {
            return new ChartSeriesBuilder<T>(Container.Bullet);
        }

        /// <summary>
        /// The candlestick series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the candlestick series settings.</param>
        public ChartSeriesBuilder<T> Candlestick()
        {
            return new ChartSeriesBuilder<T>(Container.Candlestick);
        }

        /// <summary>
        /// The column series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the column series settings.</param>
        public ChartSeriesBuilder<T> Column()
        {
            return new ChartSeriesBuilder<T>(Container.Column);
        }

        /// <summary>
        /// The donut series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the donut series settings.</param>
        public ChartSeriesBuilder<T> Donut()
        {
            return new ChartSeriesBuilder<T>(Container.Donut);
        }

        /// <summary>
        /// The funnel series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the funnel series settings.</param>
        public ChartSeriesBuilder<T> Funnel()
        {
            return new ChartSeriesBuilder<T>(Container.Funnel);
        }

        /// <summary>
        /// The horizontalWaterfall series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the horizontalWaterfall series settings.</param>
        public ChartSeriesBuilder<T> HorizontalWaterfall()
        {
            return new ChartSeriesBuilder<T>(Container.HorizontalWaterfall);
        }

        /// <summary>
        /// The line series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the line series settings.</param>
        public ChartSeriesBuilder<T> Line()
        {
            return new ChartSeriesBuilder<T>(Container.Line);
        }

        /// <summary>
        /// The ohlc series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the ohlc series settings.</param>
        public ChartSeriesBuilder<T> OHLC()
        {
            return new ChartSeriesBuilder<T>(Container.OHLC);
        }

        /// <summary>
        /// The pie series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the pie series settings.</param>
        public ChartSeriesBuilder<T> Pie()
        {
            return new ChartSeriesBuilder<T>(Container.Pie);
        }

        /// <summary>
        /// The polarArea series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the polarArea series settings.</param>
        public ChartSeriesBuilder<T> PolarArea()
        {
            return new ChartSeriesBuilder<T>(Container.PolarArea);
        }

        /// <summary>
        /// The polarLine series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the polarLine series settings.</param>
        public ChartSeriesBuilder<T> PolarLine()
        {
            return new ChartSeriesBuilder<T>(Container.PolarLine);
        }

        /// <summary>
        /// The polarScatter series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the polarScatter series settings.</param>
        public ChartSeriesBuilder<T> PolarScatter()
        {
            return new ChartSeriesBuilder<T>(Container.PolarScatter);
        }

        /// <summary>
        /// The radarArea series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the radarArea series settings.</param>
        public ChartSeriesBuilder<T> RadarArea()
        {
            return new ChartSeriesBuilder<T>(Container.RadarArea);
        }

        /// <summary>
        /// The radarColumn series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the radarColumn series settings.</param>
        public ChartSeriesBuilder<T> RadarColumn()
        {
            return new ChartSeriesBuilder<T>(Container.RadarColumn);
        }

        /// <summary>
        /// The radarLine series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the radarLine series settings.</param>
        public ChartSeriesBuilder<T> RadarLine()
        {
            return new ChartSeriesBuilder<T>(Container.RadarLine);
        }

        /// <summary>
        /// The rangeBar series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the rangeBar series settings.</param>
        public ChartSeriesBuilder<T> RangeBar()
        {
            return new ChartSeriesBuilder<T>(Container.RangeBar);
        }

        /// <summary>
        /// The rangeColumn series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the rangeColumn series settings.</param>
        public ChartSeriesBuilder<T> RangeColumn()
        {
            return new ChartSeriesBuilder<T>(Container.RangeColumn);
        }

        /// <summary>
        /// The scatter series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the scatter series settings.</param>
        public ChartSeriesBuilder<T> Scatter()
        {
            return new ChartSeriesBuilder<T>(Container.Scatter);
        }

        /// <summary>
        /// The scatterLine series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the scatterLine series settings.</param>
        public ChartSeriesBuilder<T> ScatterLine()
        {
            return new ChartSeriesBuilder<T>(Container.ScatterLine);
        }

        /// <summary>
        /// The verticalArea series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the verticalArea series settings.</param>
        public ChartSeriesBuilder<T> VerticalArea()
        {
            return new ChartSeriesBuilder<T>(Container.VerticalArea);
        }

        /// <summary>
        /// The verticalBoxPlot series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the verticalBoxPlot series settings.</param>
        public ChartSeriesBuilder<T> VerticalBoxPlot()
        {
            return new ChartSeriesBuilder<T>(Container.VerticalBoxPlot);
        }

        /// <summary>
        /// The verticalBullet series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the verticalBullet series settings.</param>
        public ChartSeriesBuilder<T> VerticalBullet()
        {
            return new ChartSeriesBuilder<T>(Container.VerticalBullet);
        }

        /// <summary>
        /// The verticalLine series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the verticalLine series settings.</param>
        public ChartSeriesBuilder<T> VerticalLine()
        {
            return new ChartSeriesBuilder<T>(Container.VerticalLine);
        }

        /// <summary>
        /// The waterfall series default settings.
        /// </summary>
        /// <param name="configurator">The configurator for the waterfall series settings.</param>
        public ChartSeriesBuilder<T> Waterfall()
        {
            return new ChartSeriesBuilder<T>(Container.Waterfall);
        }
    }
}
