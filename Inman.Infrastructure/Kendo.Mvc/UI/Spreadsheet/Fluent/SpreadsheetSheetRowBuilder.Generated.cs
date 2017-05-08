using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetRow
    /// </summary>
    public partial class SpreadsheetSheetRowBuilder
        
    {
        /// <summary>
        /// The cells for this row.
        /// </summary>
        /// <param name="configurator">The configurator for the cells setting.</param>
        public SpreadsheetSheetRowBuilder Cells(Action<SpreadsheetSheetRowCellFactory> configurator)
        {

            configurator(new SpreadsheetSheetRowCellFactory(Container.Cells)
            {
                Spreadsheet = Container.Spreadsheet
            });

            return this;
        }

        /// <summary>
        /// The row height in pixels. Defaults to rowHeight.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public SpreadsheetSheetRowBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The absolute row index. Required to ensure correct positioning.
        /// </summary>
        /// <param name="value">The value for Index</param>
        public SpreadsheetSheetRowBuilder Index(int value)
        {
            Container.Index = value;
            return this;
        }

        /// <summary>
        /// The table row element role, in the context of the Grid table structure.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public SpreadsheetSheetRowBuilder Type(string value)
        {
            Container.Type = value;
            return this;
        }

    }
}
