using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListSortableSettings
    /// </summary>
    public partial class TreeListSortableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true the user can get the treelist in its unsorted state by clicking the sorted column header.
        /// </summary>
        /// <param name="value">The value for AllowUnsort</param>
        public TreeListSortableSettingsBuilder<T> AllowUnsort(bool value)
        {
            Container.AllowUnsort = value;
            return this;
        }

        /// <summary>
        /// Defines the sort modes supported by Kendo UI TreeList for ASP.NET MVC
        /// </summary>
        /// <param name="value">The value for Mode</param>
        public TreeListSortableSettingsBuilder<T> Mode(TreeListSortMode value)
        {
            Container.Mode = value;
            return this;
        }

    }
}
