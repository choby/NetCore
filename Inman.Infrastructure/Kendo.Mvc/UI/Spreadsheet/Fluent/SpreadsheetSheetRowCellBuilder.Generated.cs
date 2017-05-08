using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetRowCell
    /// </summary>
    public partial class SpreadsheetSheetRowCellBuilder
        
    {
        /// <summary>
        /// The background color of the cell.Many standard CSS formats are supported, but the canonical form is "#ccff00".
        /// </summary>
        /// <param name="value">The value for Background</param>
        public SpreadsheetSheetRowCellBuilder Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The style information for the bottom border of the cell.
        /// </summary>
        /// <param name="configurator">The configurator for the borderbottom setting.</param>
        public SpreadsheetSheetRowCellBuilder BorderBottom(Action<SpreadsheetSheetRowCellBorderBottomSettingsBuilder> configurator)
        {

            Container.BorderBottom.Spreadsheet = Container.Spreadsheet;
            configurator(new SpreadsheetSheetRowCellBorderBottomSettingsBuilder(Container.BorderBottom));

            return this;
        }

        /// <summary>
        /// The style information for the left border of the cell.
        /// </summary>
        /// <param name="configurator">The configurator for the borderleft setting.</param>
        public SpreadsheetSheetRowCellBuilder BorderLeft(Action<SpreadsheetSheetRowCellBorderLeftSettingsBuilder> configurator)
        {

            Container.BorderLeft.Spreadsheet = Container.Spreadsheet;
            configurator(new SpreadsheetSheetRowCellBorderLeftSettingsBuilder(Container.BorderLeft));

            return this;
        }

        /// <summary>
        /// The style information for the top border of the cell.
        /// </summary>
        /// <param name="configurator">The configurator for the bordertop setting.</param>
        public SpreadsheetSheetRowCellBuilder BorderTop(Action<SpreadsheetSheetRowCellBorderTopSettingsBuilder> configurator)
        {

            Container.BorderTop.Spreadsheet = Container.Spreadsheet;
            configurator(new SpreadsheetSheetRowCellBorderTopSettingsBuilder(Container.BorderTop));

            return this;
        }

        /// <summary>
        /// The style information for the right border of the cell.
        /// </summary>
        /// <param name="configurator">The configurator for the borderright setting.</param>
        public SpreadsheetSheetRowCellBuilder BorderRight(Action<SpreadsheetSheetRowCellBorderRightSettingsBuilder> configurator)
        {

            Container.BorderRight.Spreadsheet = Container.Spreadsheet;
            configurator(new SpreadsheetSheetRowCellBorderRightSettingsBuilder(Container.BorderRight));

            return this;
        }

        /// <summary>
        /// The font color of the cell.Many standard CSS formats are supported, but the canonical form is "#ccff00".
        /// </summary>
        /// <param name="value">The value for Color</param>
        public SpreadsheetSheetRowCellBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font family for the cell.
        /// </summary>
        /// <param name="value">The value for FontFamily</param>
        public SpreadsheetSheetRowCellBuilder FontFamily(string value)
        {
            Container.FontFamily = value;
            return this;
        }

        /// <summary>
        /// The font size of the cell in pixels.
        /// </summary>
        /// <param name="value">The value for FontSize</param>
        public SpreadsheetSheetRowCellBuilder FontSize(double value)
        {
            Container.FontSize = value;
            return this;
        }

        /// <summary>
        /// Sets the cell font to italic, if set to true.
        /// </summary>
        /// <param name="value">The value for Italic</param>
        public SpreadsheetSheetRowCellBuilder Italic(bool value)
        {
            Container.Italic = value;
            return this;
        }

        /// <summary>
        /// Sets the cell font to bold, if set to true.
        /// </summary>
        /// <param name="value">The value for Bold</param>
        public SpreadsheetSheetRowCellBuilder Bold(bool value)
        {
            Container.Bold = value;
            return this;
        }

        /// <summary>
        /// Disables the cell, if set to false.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public SpreadsheetSheetRowCellBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// The format of the cell text.See Create or delete a custom number format on MS Office.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public SpreadsheetSheetRowCellBuilder Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The cell formula without the leading equals sign, e.g. A1 * 10.
        /// </summary>
        /// <param name="value">The value for Formula</param>
        public SpreadsheetSheetRowCellBuilder Formula(string value)
        {
            Container.Formula = value;
            return this;
        }

        /// <summary>
        /// The zero-based index of the cell. Required to ensure correct positioning.
        /// </summary>
        /// <param name="value">The value for Index</param>
        public SpreadsheetSheetRowCellBuilder Index(int value)
        {
            Container.Index = value;
            return this;
        }

        /// <summary>
        /// The hyperlink (URL) of the cell.
        /// </summary>
        /// <param name="value">The value for Link</param>
        public SpreadsheetSheetRowCellBuilder Link(string value)
        {
            Container.Link = value;
            return this;
        }

        /// <summary>
        /// Sets the cell font to underline, if set to true.
        /// </summary>
        /// <param name="value">The value for Underline</param>
        public SpreadsheetSheetRowCellBuilder Underline(bool value)
        {
            Container.Underline = value;
            return this;
        }

        /// <summary>
        /// The cell value.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public SpreadsheetSheetRowCellBuilder Value(object value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// The validation rule applied to the cell.
        /// </summary>
        /// <param name="configurator">The configurator for the validation setting.</param>
        public SpreadsheetSheetRowCellBuilder Validation(Action<SpreadsheetSheetRowCellValidationSettingsBuilder> configurator)
        {

            Container.Validation.Spreadsheet = Container.Spreadsheet;
            configurator(new SpreadsheetSheetRowCellValidationSettingsBuilder(Container.Validation));

            return this;
        }

        /// <summary>
        /// Will wrap the cell content if set to true.
        /// </summary>
        /// <param name="value">The value for Wrap</param>
        public SpreadsheetSheetRowCellBuilder Wrap(bool value)
        {
            Container.Wrap = value;
            return this;
        }

        /// <summary>
        /// Specifies the text alignment in the cell
        /// </summary>
        /// <param name="value">The value for TextAlign</param>
        public SpreadsheetSheetRowCellBuilder TextAlign(SpreadsheetTextAlign value)
        {
            Container.TextAlign = value;
            return this;
        }

        /// <summary>
        /// Specifies the text vertical alignment in the cell
        /// </summary>
        /// <param name="value">The value for VerticalAlign</param>
        public SpreadsheetSheetRowCellBuilder VerticalAlign(SpreadsheetVerticalAlign value)
        {
            Container.VerticalAlign = value;
            return this;
        }

    }
}
