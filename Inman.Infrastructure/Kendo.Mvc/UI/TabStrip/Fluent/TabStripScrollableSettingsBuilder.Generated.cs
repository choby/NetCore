using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TabStripScrollableSettings
    /// </summary>
    public partial class TabStripScrollableSettingsBuilder
        
    {
        /// <summary>
        /// Sets the scroll amount (in pixels) applied when the user clicks on a scroll button.
        /// </summary>
        /// <param name="value">The value for Distance</param>
        public TabStripScrollableSettingsBuilder Distance(int value)
        {
            Container.Distance = value;
            return this;
        }

    }
}
