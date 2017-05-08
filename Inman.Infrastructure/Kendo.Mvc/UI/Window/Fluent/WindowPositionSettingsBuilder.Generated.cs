using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring WindowPositionSettings
    /// </summary>
    public partial class WindowPositionSettingsBuilder
        
    {
        /// <summary>
        /// Specifies the initial top position of the window. Numeric values are treated as pixels. String values can specify pixels, percentages, ems or other valid values.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public WindowPositionSettingsBuilder Top(double value)
        {
            Container.Top = value;
            return this;
        }

        /// <summary>
        /// Specifies the initial left position of the window. Numeric values are treated as pixels. String values can specify pixels or percentages, ems or other valid values.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public WindowPositionSettingsBuilder Left(double value)
        {
            Container.Left = value;
            return this;
        }

    }
}
