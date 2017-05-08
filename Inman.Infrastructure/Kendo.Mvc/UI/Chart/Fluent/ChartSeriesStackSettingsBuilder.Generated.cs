using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesStackSettings
    /// </summary>
    public partial class ChartSeriesStackSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Indicates that the series should be stacked in a group with the specified name.
        /// </summary>
        /// <param name="value">The value for Group</param>
        public ChartSeriesStackSettingsBuilder<T> Group(string value)
        {
            Container.Group = value;
            return this;
        }

        /// <summary>
        /// Specifies the preferred stack type.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ChartSeriesStackSettingsBuilder<T> Type(ChartStackType value)
        {
            Container.Type = value;
            return this;
        }

    }
}
