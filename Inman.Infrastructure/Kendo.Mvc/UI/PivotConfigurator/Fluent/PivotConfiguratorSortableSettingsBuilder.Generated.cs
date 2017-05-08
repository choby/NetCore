using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PivotConfiguratorSortableSettings
    /// </summary>
    public partial class PivotConfiguratorSortableSettingsBuilder
        
    {
        /// <summary>
        /// If set to true the user can get the widget in unsorted state by clicking the sorted dimension field.
        /// </summary>
        /// <param name="value">The value for AllowUnsort</param>
        public PivotConfiguratorSortableSettingsBuilder AllowUnsort(bool value)
        {
            Container.AllowUnsort = value;
            return this;
        }

        /// <summary>
        /// If set to true the user can get the widget in unsorted state by clicking the sorted dimension field.
        /// </summary>
        public PivotConfiguratorSortableSettingsBuilder AllowUnsort()
        {
            Container.AllowUnsort = true;
            return this;
        }

    }
}
