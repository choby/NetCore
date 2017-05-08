using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetDefaultCellStyleSettings
    /// </summary>
    public partial class SpreadsheetDefaultCellStyleSettingsBuilder
        
    {
        /// <summary>
        /// The background CSS color of the cell.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public SpreadsheetDefaultCellStyleSettingsBuilder Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The text CSS color of the cell.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public SpreadsheetDefaultCellStyleSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font family for the cell.
        /// </summary>
        /// <param name="value">The value for FontFamily</param>
        public SpreadsheetDefaultCellStyleSettingsBuilder FontFamily(string value)
        {
            Container.FontFamily = value;
            return this;
        }

        /// <summary>
        /// The font size of the cell in pixels.
        /// </summary>
        /// <param name="value">The value for FontSize</param>
        public SpreadsheetDefaultCellStyleSettingsBuilder FontSize(string value)
        {
            Container.FontSize = value;
            return this;
        }

        /// <summary>
        /// Sets the cell font to italic, if set to true.
        /// </summary>
        /// <param name="value">The value for Italic</param>
        public SpreadsheetDefaultCellStyleSettingsBuilder Italic(bool value)
        {
            Container.Italic = value;
            return this;
        }

        /// <summary>
        /// Sets the cell font to bold, if set to true.
        /// </summary>
        /// <param name="value">The value for Bold</param>
        public SpreadsheetDefaultCellStyleSettingsBuilder Bold(bool value)
        {
            Container.Bold = value;
            return this;
        }

        /// <summary>
        /// Sets the cell font to underline, if set to true.
        /// </summary>
        /// <param name="value">The value for Underline</param>
        public SpreadsheetDefaultCellStyleSettingsBuilder Underline(bool value)
        {
            Container.Underline = value;
            return this;
        }

        /// <summary>
        /// Sets the cell wrap, if set to true.
        /// </summary>
        /// <param name="value">The value for Wrap</param>
        public SpreadsheetDefaultCellStyleSettingsBuilder Wrap(bool value)
        {
            Container.Wrap = value;
            return this;
        }

    }
}
