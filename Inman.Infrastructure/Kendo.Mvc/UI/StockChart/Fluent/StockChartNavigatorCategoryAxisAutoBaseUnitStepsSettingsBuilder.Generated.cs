using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The seconds unit steps.
        /// </summary>
        /// <param name="value">The value for Seconds</param>
        public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Seconds(params int[] value)
        {
            Container.Seconds = value;
            return this;
        }

        /// <summary>
        /// The minutes unit steps.
        /// </summary>
        /// <param name="value">The value for Minutes</param>
        public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Minutes(params int[] value)
        {
            Container.Minutes = value;
            return this;
        }

        /// <summary>
        /// The hours unit steps.
        /// </summary>
        /// <param name="value">The value for Hours</param>
        public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Hours(params int[] value)
        {
            Container.Hours = value;
            return this;
        }

        /// <summary>
        /// The days unit steps.
        /// </summary>
        /// <param name="value">The value for Days</param>
        public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Days(params int[] value)
        {
            Container.Days = value;
            return this;
        }

        /// <summary>
        /// The weeks unit steps.
        /// </summary>
        /// <param name="value">The value for Weeks</param>
        public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Weeks(params int[] value)
        {
            Container.Weeks = value;
            return this;
        }

        /// <summary>
        /// The months unit steps.
        /// </summary>
        /// <param name="value">The value for Months</param>
        public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Months(params int[] value)
        {
            Container.Months = value;
            return this;
        }

        /// <summary>
        /// The years unit steps.
        /// </summary>
        /// <param name="value">The value for Years</param>
        public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Years(params int[] value)
        {
            Container.Years = value;
            return this;
        }

    }
}
