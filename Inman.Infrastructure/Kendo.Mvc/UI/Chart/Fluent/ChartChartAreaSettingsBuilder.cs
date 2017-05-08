using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartChartAreaSettings
    /// </summary>
    public partial class ChartChartAreaSettingsBuilder<T>
        where T : class
    {
        public ChartChartAreaSettingsBuilder(ChartChartAreaSettings<T> container)
        {
            Container = container;
        }

        protected ChartChartAreaSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        /// <summary>
        /// The margin of the chart area. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartChartAreaSettingsBuilder<T> Margin(int value)
        {
            Container.Margin.Top = value;
            Container.Margin.Right = value;
            Container.Margin.Bottom = value;
            Container.Margin.Left = value;
            
            return this;
        }
    }
}
