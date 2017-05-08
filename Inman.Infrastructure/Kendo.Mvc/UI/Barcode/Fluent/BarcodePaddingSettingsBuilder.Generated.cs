using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring BarcodePaddingSettings
    /// </summary>
    public partial class BarcodePaddingSettingsBuilder
        
    {
        /// <summary>
        /// The bottom padding of the barcode.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public BarcodePaddingSettingsBuilder Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the barcode.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public BarcodePaddingSettingsBuilder Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the barcode.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public BarcodePaddingSettingsBuilder Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the barcode.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public BarcodePaddingSettingsBuilder Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
