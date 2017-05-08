using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetSortSettingsColumn
    /// </summary>
    public partial class SpreadsheetSheetSortSettingsColumnBuilder
        
    {
        /// <summary>
        /// Indicates if the data in the cell should be sorted ascending (true) or descending or (false).
        /// </summary>
        /// <param name="value">The value for Ascending</param>
        public SpreadsheetSheetSortSettingsColumnBuilder Ascending(bool value)
        {
            Container.Ascending = value;
            return this;
        }

        /// <summary>
        /// The index of the column within the sheet.For example, column C will have index 2.
        /// </summary>
        /// <param name="value">The value for Index</param>
        public SpreadsheetSheetSortSettingsColumnBuilder Index(double value)
        {
            Container.Index = value;
            return this;
        }

    }
}
