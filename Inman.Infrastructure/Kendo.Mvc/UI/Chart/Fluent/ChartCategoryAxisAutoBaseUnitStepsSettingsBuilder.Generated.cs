using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisAutoBaseUnitStepsSettings
    /// </summary>
    public partial class ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The milliseconds unit steps.
        /// </summary>
        /// <param name="value">The value for Milliseconds</param>
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Milliseconds(params int[] value)
        {
            Container.Milliseconds = value;
            return this;
        }

        /// <summary>
        /// The seconds unit steps.
        /// </summary>
        /// <param name="value">The value for Seconds</param>
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Seconds(params int[] value)
        {
            Container.Seconds = value;
            return this;
        }

        /// <summary>
        /// The minutes unit steps.
        /// </summary>
        /// <param name="value">The value for Minutes</param>
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Minutes(params int[] value)
        {
            Container.Minutes = value;
            return this;
        }

        /// <summary>
        /// The hours unit steps.
        /// </summary>
        /// <param name="value">The value for Hours</param>
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Hours(params int[] value)
        {
            Container.Hours = value;
            return this;
        }

        /// <summary>
        /// The days unit steps.
        /// </summary>
        /// <param name="value">The value for Days</param>
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Days(params int[] value)
        {
            Container.Days = value;
            return this;
        }

        /// <summary>
        /// The weeks unit steps.
        /// </summary>
        /// <param name="value">The value for Weeks</param>
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Weeks(params int[] value)
        {
            Container.Weeks = value;
            return this;
        }

        /// <summary>
        /// The months unit steps.
        /// </summary>
        /// <param name="value">The value for Months</param>
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Months(params int[] value)
        {
            Container.Months = value;
            return this;
        }

        /// <summary>
        /// The years unit steps.
        /// </summary>
        /// <param name="value">The value for Years</param>
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Years(params int[] value)
        {
            Container.Years = value;
            return this;
        }

    }
}
