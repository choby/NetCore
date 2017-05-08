using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring CalendarMonthSettings
    /// </summary>
    public partial class CalendarMonthSettingsBuilder
        
    {
        /// <summary>
        /// The template to be used for rendering the cells in "month" view, which are between the min/max range.
		///  By default, the widget renders the value of the corresponding day.
        /// </summary>
        /// <param name="value">The value for Content</param>
        public CalendarMonthSettingsBuilder Content(string value)
        {
            Container.Content = value;
            return this;
        }

        /// <summary>
        /// The template to be used for rendering the cells in the "month" view, which are not in the min/max range.
		///  By default, the widget renders an empty string.
        /// </summary>
        /// <param name="value">The value for Empty</param>
        public CalendarMonthSettingsBuilder Empty(string value)
        {
            Container.Empty = value;
            return this;
        }

    }
}
