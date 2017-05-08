using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI StockChart
    /// </summary>
    public partial class StockChartBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The field containing the point date.
		/// It is used as a default categoryField for all series.The data item field value must be either:
        /// </summary>
        /// <param name="value">The value for DateField</param>
        public StockChartBuilder<T> DateField(string value)
        {
            Container.DateField = value;
            return this;
        }

        /// <summary>
        /// The data navigator configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the navigator setting.</param>
        public StockChartBuilder<T> Navigator(Action<StockChartNavigatorSettingsBuilder<T>> configurator)
        {

            Container.Navigator.StockChart = Container;
            configurator(new StockChartNavigatorSettingsBuilder<T>(Container.Navigator));

            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().StockChart()
        ///       .Name("StockChart")
        ///       .Events(events => events
        ///           .AxisLabelClick("onAxisLabelClick")
        ///       )
        /// )
        /// </code>
        /// </example>
        public StockChartBuilder<T> Events(Action<StockChartEventBuilder> configurator)
        {
            configurator(new StockChartEventBuilder(Container.Events));
            return this;
        }
        
    }
}

