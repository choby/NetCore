using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetRowCellBorderLeftSettings
    /// </summary>
    public partial class SpreadsheetSheetRowCellBorderLeftSettingsBuilder
        
    {
        /// <summary>
        /// The left border color of the cell.Many standard CSS formats are supported, but the canonical form is "#ccff00".
        /// </summary>
        /// <param name="value">The value for Color</param>
        public SpreadsheetSheetRowCellBorderLeftSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The width of the border in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public SpreadsheetSheetRowCellBorderLeftSettingsBuilder Size(string value)
        {
            Container.Size = value;
            return this;
        }

    }
}
