using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring BarcodeTextSettings
    /// </summary>
    public partial class BarcodeTextSettingsBuilder
        
    {
        /// <summary>
        /// The color of the text. Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public BarcodeTextSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font of the text.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public BarcodeTextSettingsBuilder Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The margin of the text
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public BarcodeTextSettingsBuilder Margin(Action<BarcodeTextMarginSettingsBuilder> configurator)
        {

            Container.Margin.Barcode = Container.Barcode;
            configurator(new BarcodeTextMarginSettingsBuilder(Container.Margin));

            return this;
        }

        /// <summary>
        /// If set to false the barcode will not display the value as a text below the barcode lines.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public BarcodeTextSettingsBuilder Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

    }
}
