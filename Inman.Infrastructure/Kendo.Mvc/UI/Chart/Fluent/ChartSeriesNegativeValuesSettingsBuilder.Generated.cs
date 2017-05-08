using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNegativeValuesSettings
    /// </summary>
    public partial class ChartSeriesNegativeValuesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the chart negative bubble values.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesNegativeValuesSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the negative bubbles. By default the negative bubbles are not displayed.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartSeriesNegativeValuesSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the negative bubbles. By default the negative bubbles are not displayed.
        /// </summary>
        public ChartSeriesNegativeValuesSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

    }
}
