using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridGroupableSettings
    /// </summary>
    public partial class GridGroupableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// When set  to false grouping is considered disabled.
        /// </summary>
        /// <param name="value">The value for Enabled</param>
        public GridGroupableSettingsBuilder<T> Enabled(bool value)
        {
            Container.Enabled = value;
            return this;
        }

        /// <summary>
        /// When enabled the group footer rows will remain visible when the corresponding group is collapsed.
        /// </summary>
        /// <param name="value">The value for ShowFooter</param>
        public GridGroupableSettingsBuilder<T> ShowFooter(bool value)
        {
            Container.ShowFooter = value;
            return this;
        }

        /// <summary>
        /// When enabled the group footer rows will remain visible when the corresponding group is collapsed.
        /// </summary>
        public GridGroupableSettingsBuilder<T> ShowFooter()
        {
            Container.ShowFooter = true;
            return this;
        }

    }
}
