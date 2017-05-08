using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SortableCursorOffsetSettings
    /// </summary>
    public partial class SortableCursorOffsetSettingsBuilder
        
    {
        /// <summary>
        /// The left offset of the hint element relative to the mouse cursor/finger.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public SortableCursorOffsetSettingsBuilder Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The top offset of the hint element relative to the mouse cursor/finger.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public SortableCursorOffsetSettingsBuilder Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
