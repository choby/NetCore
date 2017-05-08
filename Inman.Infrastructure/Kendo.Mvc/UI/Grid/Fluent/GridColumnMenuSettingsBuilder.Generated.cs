using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridColumnMenuSettings
    /// </summary>
    public partial class GridColumnMenuSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true the column menu would allow the user to select (show and hide) grid columns. By default the column menu allows column selection.
        /// </summary>
        /// <param name="value">The value for Columns</param>
        public GridColumnMenuSettingsBuilder<T> Columns(bool value)
        {
            Container.Columns = value;
            return this;
        }

        /// <summary>
        /// If set to true the column menu would allow the user to filter the grid. By default the column menu allows the user to filter if filtering is enabled via the filterable.
        /// </summary>
        /// <param name="value">The value for Filterable</param>
        public GridColumnMenuSettingsBuilder<T> Filterable(bool value)
        {
            Container.Filterable = value;
            return this;
        }

        /// <summary>
        /// If set to true the column menu would allow the user to sort the grid by the column field. By default the column menu allows the user to sort if sorting is enabled via the sortable option.
        /// </summary>
        /// <param name="value">The value for Sortable</param>
        public GridColumnMenuSettingsBuilder<T> Sortable(bool value)
        {
            Container.Sortable = value;
            return this;
        }

    }
}
