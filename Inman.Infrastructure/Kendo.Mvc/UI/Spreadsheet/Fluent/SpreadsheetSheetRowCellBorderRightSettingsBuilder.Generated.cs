using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetRowCellBorderRightSettings
    /// </summary>
    public partial class SpreadsheetSheetRowCellBorderRightSettingsBuilder
        
    {
        /// <summary>
        /// The right border color of the cell.Many standard CSS formats are supported, but the canonical form is "#ccff00".
        /// </summary>
        /// <param name="value">The value for Color</param>
        public SpreadsheetSheetRowCellBorderRightSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The width of the border in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public SpreadsheetSheetRowCellBorderRightSettingsBuilder Size(string value)
        {
            Container.Size = value;
            return this;
        }

    }
}
