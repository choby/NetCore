using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetSortSettings
    /// </summary>
    public partial class SpreadsheetSheetSortSettingsBuilder
        
    {
        /// <summary>
        /// Specifies the sort options for individual columns.
        /// </summary>
        /// <param name="configurator">The configurator for the columns setting.</param>
        public SpreadsheetSheetSortSettingsBuilder Columns(Action<SpreadsheetSheetSortSettingsColumnFactory> configurator)
        {

            configurator(new SpreadsheetSheetSortSettingsColumnFactory(Container.Columns)
            {
                Spreadsheet = Container.Spreadsheet
            });

            return this;
        }

        /// <summary>
        /// The sorted range, e.g. "A1:D5".
        /// </summary>
        /// <param name="value">The value for Ref</param>
        public SpreadsheetSheetSortSettingsBuilder Ref(string value)
        {
            Container.Ref = value;
            return this;
        }

    }
}
