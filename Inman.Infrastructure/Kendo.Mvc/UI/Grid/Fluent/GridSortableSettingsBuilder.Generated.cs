using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridSortableSettings
    /// </summary>
    public partial class GridSortableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true the user can get the grid in unsorted state by clicking the sorted column header.
        /// </summary>
        /// <param name="value">The value for AllowUnsort</param>
        public GridSortableSettingsBuilder<T> AllowUnsort(bool value)
        {
            Container.AllowUnsort = value;
            return this;
        }

        /// <summary>
        /// Determines the inital (from un-sorted to sorted state) sort direction. The supported values are asc and desc.
        /// </summary>
        /// <param name="value">The value for InitialDirection</param>
        public GridSortableSettingsBuilder<T> InitialDirection(string value)
        {
            Container.InitialDirection = value;
            return this;
        }

        /// <summary>
        /// Defines the sort modes supported by Kendo UI Grid for ASP.NET MVC
        /// </summary>
        /// <param name="value">The value for SortMode</param>
        public GridSortableSettingsBuilder<T> SortMode(GridSortMode value)
        {
            Container.SortMode = value;
            return this;
        }

    }
}
