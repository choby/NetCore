using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetFilterSettings
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsBuilder
        
    {
        /// <summary>
        /// An array defining the filter configuration of individual columns.
        /// </summary>
        /// <param name="configurator">The configurator for the columns setting.</param>
        public SpreadsheetSheetFilterSettingsBuilder Columns(Action<SpreadsheetSheetFilterSettingsColumnFactory> configurator)
        {

            configurator(new SpreadsheetSheetFilterSettingsColumnFactory(Container.Columns)
            {
                Spreadsheet = Container.Spreadsheet
            });

            return this;
        }

        /// <summary>
        /// The active range for the filter, e.g. "B1:D8".
        /// </summary>
        /// <param name="value">The value for Ref</param>
        public SpreadsheetSheetFilterSettingsBuilder Ref(string value)
        {
            Container.Ref = value;
            return this;
        }

    }
}
