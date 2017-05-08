using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisLabelsDateFormatsSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The format used when categoryAxis.baseUnit is set to "days".
        /// </summary>
        /// <param name="value">The value for Days</param>
        public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Days(string value)
        {
            Container.Days = value;
            return this;
        }

        /// <summary>
        /// The format used when categoryAxis.baseUnit is set to "hours".
        /// </summary>
        /// <param name="value">The value for Hours</param>
        public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Hours(string value)
        {
            Container.Hours = value;
            return this;
        }

        /// <summary>
        /// The format used when categoryAxis.baseUnit is set to "months".
        /// </summary>
        /// <param name="value">The value for Months</param>
        public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Months(string value)
        {
            Container.Months = value;
            return this;
        }

        /// <summary>
        /// The format used when categoryAxis.baseUnit is set to "weeks".
        /// </summary>
        /// <param name="value">The value for Weeks</param>
        public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Weeks(string value)
        {
            Container.Weeks = value;
            return this;
        }

        /// <summary>
        /// The format used when categoryAxis.baseUnit is set to "years".
        /// </summary>
        /// <param name="value">The value for Years</param>
        public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Years(string value)
        {
            Container.Years = value;
            return this;
        }

    }
}
