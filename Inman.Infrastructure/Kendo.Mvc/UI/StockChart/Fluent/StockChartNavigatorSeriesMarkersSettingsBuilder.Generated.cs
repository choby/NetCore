using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesMarkersSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesMarkersSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the current series markers.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the markers.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Border(Action<StockChartNavigatorSeriesMarkersBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesMarkersBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The rotation angle of the markers.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The marker size.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// Configures the markers shape type.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// The markers visibility.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The markers visibility.
        /// </summary>
        public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

    }
}
