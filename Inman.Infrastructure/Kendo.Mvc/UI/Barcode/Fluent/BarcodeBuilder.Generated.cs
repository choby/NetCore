using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Barcode
    /// </summary>
    public partial class BarcodeBuilder
        
    {
        /// <summary>
        /// Sets the preferred rendering engine.
		/// If it is not supported by the browser, the Barcode will switch to the first available mode.The supported values are:
        /// </summary>
        /// <param name="value">The value for RenderAs</param>
        public BarcodeBuilder RenderAs(RenderingMode value)
        {
            Container.RenderAs = value;
            return this;
        }

        /// <summary>
        /// The background of the barcode area.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public BarcodeBuilder Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the barcode area.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public BarcodeBuilder Border(Action<BarcodeBorderSettingsBuilder> configurator)
        {

            Container.Border.Barcode = Container;
            configurator(new BarcodeBorderSettingsBuilder(Container.Border));

            return this;
        }

        /// <summary>
        /// If set to true, the Barcode will display the checksum digit next to the value in the text area.
        /// </summary>
        /// <param name="value">The value for Checksum</param>
        public BarcodeBuilder Checksum(bool value)
        {
            Container.Checksum = value;
            return this;
        }

        /// <summary>
        /// If set to true, the Barcode will display the checksum digit next to the value in the text area.
        /// </summary>
        public BarcodeBuilder Checksum()
        {
            Container.Checksum = true;
            return this;
        }

        /// <summary>
        /// The color of the bar elements.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public BarcodeBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The height of the barcode in pixels.  By default the height is 100.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public BarcodeBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The padding of the barcode.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public BarcodeBuilder Padding(Action<BarcodePaddingSettingsBuilder> configurator)
        {

            Container.Padding.Barcode = Container;
            configurator(new BarcodePaddingSettingsBuilder(Container.Padding));

            return this;
        }

        /// <summary>
        /// Can be set to a JavaScript object which represents the text configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the text setting.</param>
        public BarcodeBuilder Text(Action<BarcodeTextSettingsBuilder> configurator)
        {

            Container.Text.Barcode = Container;
            configurator(new BarcodeTextSettingsBuilder(Container.Text));

            return this;
        }

        /// <summary>
        /// The initial value of the Barcode
        /// </summary>
        /// <param name="value">The value for Value</param>
        public BarcodeBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// The width of the barcode in pixels.  By default the width is 300.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public BarcodeBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }


        
    }
}

