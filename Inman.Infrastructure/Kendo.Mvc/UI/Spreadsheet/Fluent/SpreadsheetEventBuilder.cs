using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Spreadsheet for ASP.NET MVC events.
    /// </summary>
    public class SpreadsheetEventBuilder: EventBuilder
    {
        public SpreadsheetEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered when sheet is inserted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the insertSheet event.</param>
        public SpreadsheetEventBuilder InsertSheet(string handler)
        {
            Handler("insertSheet", handler);

            return this;
        }

        /// <summary>
        /// Triggered when sheet is inserted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder InsertSheet(Func<object, object> handler)
        {
            Handler("insertSheet", handler);

            return this;
        }

        /// <summary>
        /// Triggered when sheet will be removed. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the removeSheet event.</param>
        public SpreadsheetEventBuilder RemoveSheet(string handler)
        {
            Handler("removeSheet", handler);

            return this;
        }

        /// <summary>
        /// Triggered when sheet will be removed. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder RemoveSheet(Func<object, object> handler)
        {
            Handler("removeSheet", handler);

            return this;
        }

        /// <summary>
        /// Triggered when sheet will be renamed. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the renameSheet event.</param>
        public SpreadsheetEventBuilder RenameSheet(string handler)
        {
            Handler("renameSheet", handler);

            return this;
        }

        /// <summary>
        /// Triggered when sheet will be renamed. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder RenameSheet(Func<object, object> handler)
        {
            Handler("renameSheet", handler);

            return this;
        }

        /// <summary>
        /// Triggered when sheet will be activated. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the selectSheet event.</param>
        public SpreadsheetEventBuilder SelectSheet(string handler)
        {
            Handler("selectSheet", handler);

            return this;
        }

        /// <summary>
        /// Triggered when sheet will be activated. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder SelectSheet(Func<object, object> handler)
        {
            Handler("selectSheet", handler);

            return this;
        }

        /// <summary>
        /// Triggered when column will be shown. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the unhideColumn event.</param>
        public SpreadsheetEventBuilder UnhideColumn(string handler)
        {
            Handler("unhideColumn", handler);

            return this;
        }

        /// <summary>
        /// Triggered when column will be shown. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder UnhideColumn(Func<object, object> handler)
        {
            Handler("unhideColumn", handler);

            return this;
        }

        /// <summary>
        /// Triggered when row will be shown. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the unhideRow event.</param>
        public SpreadsheetEventBuilder UnhideRow(string handler)
        {
            Handler("unhideRow", handler);

            return this;
        }

        /// <summary>
        /// Triggered when row will be shown. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder UnhideRow(Func<object, object> handler)
        {
            Handler("unhideRow", handler);

            return this;
        }

        /// <summary>
        /// Triggered when column will be hidden. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the hideColumn event.</param>
        public SpreadsheetEventBuilder HideColumn(string handler)
        {
            Handler("hideColumn", handler);

            return this;
        }

        /// <summary>
        /// Triggered when column will be hidden. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder HideColumn(Func<object, object> handler)
        {
            Handler("hideColumn", handler);

            return this;
        }

        /// <summary>
        /// Triggered when row will be hidden. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the hideRow event.</param>
        public SpreadsheetEventBuilder HideRow(string handler)
        {
            Handler("hideRow", handler);

            return this;
        }

        /// <summary>
        /// Triggered when row will be hidden. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder HideRow(Func<object, object> handler)
        {
            Handler("hideRow", handler);

            return this;
        }

        /// <summary>
        /// Triggered when column will be deleted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the deleteColumn event.</param>
        public SpreadsheetEventBuilder DeleteColumn(string handler)
        {
            Handler("deleteColumn", handler);

            return this;
        }

        /// <summary>
        /// Triggered when column will be deleted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder DeleteColumn(Func<object, object> handler)
        {
            Handler("deleteColumn", handler);

            return this;
        }

        /// <summary>
        /// Triggered when row will be deleted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the deleteRow event.</param>
        public SpreadsheetEventBuilder DeleteRow(string handler)
        {
            Handler("deleteRow", handler);

            return this;
        }

        /// <summary>
        /// Triggered when row will be deleted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder DeleteRow(Func<object, object> handler)
        {
            Handler("deleteRow", handler);

            return this;
        }

        /// <summary>
        /// Triggered when column will be inserted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the insertColumn event.</param>
        public SpreadsheetEventBuilder InsertColumn(string handler)
        {
            Handler("insertColumn", handler);

            return this;
        }

        /// <summary>
        /// Triggered when column will be inserted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder InsertColumn(Func<object, object> handler)
        {
            Handler("insertColumn", handler);

            return this;
        }

        /// <summary>
        /// Triggered when row will be inserted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the insertRow event.</param>
        public SpreadsheetEventBuilder InsertRow(string handler)
        {
            Handler("insertRow", handler);

            return this;
        }

        /// <summary>
        /// Triggered when row will be inserted. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder InsertRow(Func<object, object> handler)
        {
            Handler("insertRow", handler);

            return this;
        }

        /// <summary>
        /// Triggered when spreadsheet selection is changed. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public SpreadsheetEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Triggered when spreadsheet selection is changed. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Triggered when range format is changed from the UI. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the changeFormat event.</param>
        public SpreadsheetEventBuilder ChangeFormat(string handler)
        {
            Handler("changeFormat", handler);

            return this;
        }

        /// <summary>
        /// Triggered when range format is changed from the UI. Introduced in 2017 Q1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder ChangeFormat(Func<object, object> handler)
        {
            Handler("changeFormat", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a value in the spreadsheet has been changed. Introduced in 2016.Q1.SP1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public SpreadsheetEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a value in the spreadsheet has been changed. Introduced in 2016.Q1.SP1.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Triggered after the widget has completed rendering.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the render event.</param>
        public SpreadsheetEventBuilder Render(string handler)
        {
            Handler("render", handler);

            return this;
        }

        /// <summary>
        /// Triggered after the widget has completed rendering.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder Render(Func<object, object> handler)
        {
            Handler("render", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to Excel" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the excelExport event.</param>
        public SpreadsheetEventBuilder ExcelExport(string handler)
        {
            Handler("excelExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to Excel" toolbar button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder ExcelExport(Func<object, object> handler)
        {
            Handler("excelExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Open" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the excelImport event.</param>
        public SpreadsheetEventBuilder ExcelImport(string handler)
        {
            Handler("excelImport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Open" toolbar button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder ExcelImport(Func<object, object> handler)
        {
            Handler("excelImport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user initiates PDF export.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pdfExport event.</param>
        public SpreadsheetEventBuilder PdfExport(string handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user initiates PDF export.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SpreadsheetEventBuilder PdfExport(Func<object, object> handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

    }
}

