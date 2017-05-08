using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring BarcodeTextMarginSettings
    /// </summary>
    public partial class BarcodeTextMarginSettingsBuilder
        
    {
        /// <summary>
        /// The bottom margin of the text.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public BarcodeTextMarginSettingsBuilder Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the text.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public BarcodeTextMarginSettingsBuilder Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the text.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public BarcodeTextMarginSettingsBuilder Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the text.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public BarcodeTextMarginSettingsBuilder Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
