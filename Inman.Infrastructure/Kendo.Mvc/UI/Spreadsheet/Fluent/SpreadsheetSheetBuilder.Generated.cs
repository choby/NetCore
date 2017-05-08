using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheet
    /// </summary>
    public partial class SpreadsheetSheetBuilder
        
    {
        /// <summary>
        /// The active cell in the sheet, e.g. "A1".
        /// </summary>
        /// <param name="value">The value for ActiveCell</param>
        public SpreadsheetSheetBuilder ActiveCell(string value)
        {
            Container.ActiveCell = value;
            return this;
        }

        /// <summary>
        /// The name of the sheet.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public SpreadsheetSheetBuilder Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// An array defining the columns in this sheet and their content.
        /// </summary>
        /// <param name="configurator">The configurator for the columns setting.</param>
        public SpreadsheetSheetBuilder Columns(Action<SpreadsheetSheetColumnFactory> configurator)
        {

            configurator(new SpreadsheetSheetColumnFactory(Container.Columns)
            {
                Spreadsheet = Container.Spreadsheet
            });

            return this;
        }

        /// <summary>
        /// Defines the filtering criteria for this sheet, if any.
        /// </summary>
        /// <param name="configurator">The configurator for the filter setting.</param>
        public SpreadsheetSheetBuilder Filter(Action<SpreadsheetSheetFilterSettingsBuilder> configurator)
        {

            Container.Filter.Spreadsheet = Container.Spreadsheet;
            configurator(new SpreadsheetSheetFilterSettingsBuilder(Container.Filter));

            return this;
        }

        /// <summary>
        /// The number of frozen columns in this sheet.
        /// </summary>
        /// <param name="value">The value for FrozenColumns</param>
        public SpreadsheetSheetBuilder FrozenColumns(int value)
        {
            Container.FrozenColumns = value;
            return this;
        }

        /// <summary>
        /// The number of frozen rows in this sheet.
        /// </summary>
        /// <param name="value">The value for FrozenRows</param>
        public SpreadsheetSheetBuilder FrozenRows(int value)
        {
            Container.FrozenRows = value;
            return this;
        }

        /// <summary>
        /// An array of merged cell ranges, e.g. "B1:D2".
        /// </summary>
        /// <param name="value">The value for MergedCells</param>
        public SpreadsheetSheetBuilder MergedCells(params string[] value)
        {
            Container.MergedCells = value;
            return this;
        }

        /// <summary>
        /// The row data for this sheet.
        /// </summary>
        /// <param name="configurator">The configurator for the rows setting.</param>
        public SpreadsheetSheetBuilder Rows(Action<SpreadsheetSheetRowFactory> configurator)
        {

            configurator(new SpreadsheetSheetRowFactory(Container.Rows)
            {
                Spreadsheet = Container.Spreadsheet
            });

            return this;
        }

        /// <summary>
        /// The selected range in the sheet, e.g. "A1:B10".
        /// </summary>
        /// <param name="value">The value for Selection</param>
        public SpreadsheetSheetBuilder Selection(string value)
        {
            Container.Selection = value;
            return this;
        }

        /// <summary>
        /// A boolean value indicating if the sheet grid lines should be displayed.
        /// </summary>
        /// <param name="value">The value for ShowGridLines</param>
        public SpreadsheetSheetBuilder ShowGridLines(bool value)
        {
            Container.ShowGridLines = value;
            return this;
        }

        /// <summary>
        /// Defines the sort criteria for the sheet.
        /// </summary>
        /// <param name="configurator">The configurator for the sort setting.</param>
        public SpreadsheetSheetBuilder Sort(Action<SpreadsheetSheetSortSettingsBuilder> configurator)
        {

            Container.Sort.Spreadsheet = Container.Spreadsheet;
            configurator(new SpreadsheetSheetSortSettingsBuilder(Container.Sort));

            return this;
        }

    }
}
