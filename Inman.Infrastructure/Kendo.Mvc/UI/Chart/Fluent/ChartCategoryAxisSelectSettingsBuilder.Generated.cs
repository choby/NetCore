using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisSelectSettings
    /// </summary>
    public partial class ChartCategoryAxisSelectSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The lower boundary of the selected range.
        /// </summary>
        /// <param name="value">The value for From</param>
        public ChartCategoryAxisSelectSettingsBuilder<T> From(object value)
        {
            Container.From = value;
            return this;
        }

        /// <summary>
        /// The maximum value which the user can select.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public ChartCategoryAxisSelectSettingsBuilder<T> Max(object value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The minimum value which the user can select.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public ChartCategoryAxisSelectSettingsBuilder<T> Min(object value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// The mouse wheel configuration of the selection.
        /// </summary>
        /// <param name="configurator">The configurator for the mousewheel setting.</param>
        public ChartCategoryAxisSelectSettingsBuilder<T> Mousewheel(Action<ChartCategoryAxisSelectMousewheelSettingsBuilder<T>> configurator)
        {

            Container.Mousewheel.Chart = Container.Chart;
            configurator(new ChartCategoryAxisSelectMousewheelSettingsBuilder<T>(Container.Mousewheel));

            return this;
        }

        /// <summary>
        /// The upper boundary of the selected range.
        /// </summary>
        /// <param name="value">The value for To</param>
        public ChartCategoryAxisSelectSettingsBuilder<T> To(object value)
        {
            Container.To = value;
            return this;
        }

    }
}
