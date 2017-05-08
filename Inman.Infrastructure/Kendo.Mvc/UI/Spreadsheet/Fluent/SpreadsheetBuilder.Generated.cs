using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Spreadsheet
    /// </summary>
    public partial class SpreadsheetBuilder
        
    {
        /// <summary>
        /// The name of the currently active sheet.Must match one of the (sheet names)[#configuration-sheets.name] exactly.
        /// </summary>
        /// <param name="value">The value for ActiveSheet</param>
        public SpreadsheetBuilder ActiveSheet(string value)
        {
            Container.ActiveSheet = value;
            return this;
        }

        /// <summary>
        /// The default column width in pixels.
        /// </summary>
        /// <param name="value">The value for ColumnWidth</param>
        public SpreadsheetBuilder ColumnWidth(double value)
        {
            Container.ColumnWidth = value;
            return this;
        }

        /// <summary>
        /// The number of columns in the document.
        /// </summary>
        /// <param name="value">The value for Columns</param>
        public SpreadsheetBuilder Columns(double value)
        {
            Container.Columns = value;
            return this;
        }

        /// <summary>
        /// The default cell styles to be applyied to sheet cells.
        /// </summary>
        /// <param name="configurator">The configurator for the defaultcellstyle setting.</param>
        public SpreadsheetBuilder DefaultCellStyle(Action<SpreadsheetDefaultCellStyleSettingsBuilder> configurator)
        {

            Container.DefaultCellStyle.Spreadsheet = Container;
            configurator(new SpreadsheetDefaultCellStyleSettingsBuilder(Container.DefaultCellStyle));

            return this;
        }

        /// <summary>
        /// The height of the header row in pixels.
        /// </summary>
        /// <param name="value">The value for HeaderHeight</param>
        public SpreadsheetBuilder HeaderHeight(double value)
        {
            Container.HeaderHeight = value;
            return this;
        }

        /// <summary>
        /// The width of the header column in pixels.
        /// </summary>
        /// <param name="value">The value for HeaderWidth</param>
        public SpreadsheetBuilder HeaderWidth(double value)
        {
            Container.HeaderWidth = value;
            return this;
        }

        /// <summary>
        /// Configures the Kendo UI Spreadsheet Excel export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the excel setting.</param>
        public SpreadsheetBuilder Excel(Action<SpreadsheetExcelSettingsBuilder> configurator)
        {

            Container.Excel.Spreadsheet = Container;
            configurator(new SpreadsheetExcelSettingsBuilder(Container.Excel));

            return this;
        }

        /// <summary>
        /// Configures the Kendo UI Spreadsheet PDF export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the pdf setting.</param>
        public SpreadsheetBuilder Pdf(Action<SpreadsheetPdfSettingsBuilder> configurator)
        {

            Container.Pdf.Spreadsheet = Container;
            configurator(new SpreadsheetPdfSettingsBuilder(Container.Pdf));

            return this;
        }

        /// <summary>
        /// The default row height in pixels.
        /// </summary>
        /// <param name="value">The value for RowHeight</param>
        public SpreadsheetBuilder RowHeight(double value)
        {
            Container.RowHeight = value;
            return this;
        }

        /// <summary>
        /// The number of rows in the document.
        /// </summary>
        /// <param name="value">The value for Rows</param>
        public SpreadsheetBuilder Rows(double value)
        {
            Container.Rows = value;
            return this;
        }

        /// <summary>
        /// An array defining the document sheets and their content.
        /// </summary>
        /// <param name="configurator">The configurator for the sheets setting.</param>
        public SpreadsheetBuilder Sheets(Action<SpreadsheetSheetFactory> configurator)
        {

            configurator(new SpreadsheetSheetFactory(Container.Sheets)
            {
                Spreadsheet = Container
            });

            return this;
        }

        /// <summary>
        /// A boolean value indicating if the sheetsbar should be displayed.
        /// </summary>
        /// <param name="value">The value for Sheetsbar</param>
        public SpreadsheetBuilder Sheetsbar(bool value)
        {
            Container.Sheetsbar = value;
            return this;
        }

        /// <summary>
        /// A boolean value indicating if the toolbar should be displayed.
        /// </summary>
        /// <param name="configurator">The configurator for the toolbar setting.</param>
        public SpreadsheetBuilder Toolbar(Action<SpreadsheetToolbarSettingsBuilder> configurator)
        {
            Container.Toolbar.Enabled = true;

            Container.Toolbar.Spreadsheet = Container;
            configurator(new SpreadsheetToolbarSettingsBuilder(Container.Toolbar));

            return this;
        }

        /// <summary>
        /// A boolean value indicating if the toolbar should be displayed.
        /// </summary>
        /// <param name="enabled">Enables or disables the toolbar option.</param>
        public SpreadsheetBuilder Toolbar(bool enabled)
        {
            Container.Toolbar.Enabled = enabled;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Spreadsheet()
        ///       .Name("Spreadsheet")
        ///       .Events(events => events
        ///           .InsertSheet("onInsertSheet")
        ///       )
        /// )
        /// </code>
        /// </example>
        public SpreadsheetBuilder Events(Action<SpreadsheetEventBuilder> configurator)
        {
            configurator(new SpreadsheetEventBuilder(Container.Events));
            return this;
        }
        
    }
}

