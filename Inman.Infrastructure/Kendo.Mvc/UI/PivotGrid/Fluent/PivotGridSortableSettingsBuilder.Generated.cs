using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PivotGridSortableSettings
    /// </summary>
    public partial class PivotGridSortableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true the user can get the pivotgrid in unsorted state by clicking the sorted dimension field.
        /// </summary>
        /// <param name="value">The value for AllowUnsort</param>
        public PivotGridSortableSettingsBuilder<T> AllowUnsort(bool value)
        {
            Container.AllowUnsort = value;
            return this;
        }

    }
}
