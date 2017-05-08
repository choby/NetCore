using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetColumn
    /// </summary>
    public partial class SpreadsheetSheetColumnBuilder
        
    {
        /// <summary>
        /// The zero-based index of the column. Required to ensure correct positioning.
        /// </summary>
        /// <param name="value">The value for Index</param>
        public SpreadsheetSheetColumnBuilder Index(int value)
        {
            Container.Index = value;
            return this;
        }

        /// <summary>
        /// The width of the column in pixels. Defaults to columnWidth.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public SpreadsheetSheetColumnBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
