using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI QRCode
    /// </summary>
    public partial class QRCodeBuilder
        
    {
        /// <summary>
        /// The background color of the QR code. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public QRCodeBuilder Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the QR code.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public QRCodeBuilder Border(Action<QRCodeBorderSettingsBuilder> configurator)
        {

            Container.Border.QRCode = Container;
            configurator(new QRCodeBorderSettingsBuilder(Container.Border));

            return this;
        }

        /// <summary>
        /// The color of the QR code. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public QRCodeBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// Sets the minimum distance in pixels that should be left between the border and the QR modules.
        /// </summary>
        /// <param name="value">The value for Padding</param>
        public QRCodeBuilder Padding(double value)
        {
            Container.Padding = value;
            return this;
        }

        /// <summary>
        /// Sets the preferred rendering engine.
		/// If it is not supported by the browser, the QRCode will switch to the first available mode.The supported values are:
        /// </summary>
        /// <param name="value">The value for RenderAs</param>
        public QRCodeBuilder RenderAs(RenderingMode value)
        {
            Container.RenderAs = value;
            return this;
        }

        /// <summary>
        /// Specifies the size of a QR code in pixels (i.e. "200px"). Numeric values are treated as pixels.
		/// If no size is specified, it will be determined from the element width and height.
		/// In case the element has width or height of zero, a default value of 200 pixels will be used.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public QRCodeBuilder Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// The value of the QRCode.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public QRCodeBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Specifies a QR code encoding mode.
        /// </summary>
        /// <param name="value">The value for Encoding</param>
        public QRCodeBuilder Encoding(QREncoding value)
        {
            Container.Encoding = value;
            return this;
        }

        /// <summary>
        /// Specifies a QR code error correction level.
        /// </summary>
        /// <param name="value">The value for ErrorCorrection</param>
        public QRCodeBuilder ErrorCorrection(QRErrorCorrectionLevel value)
        {
            Container.ErrorCorrection = value;
            return this;
        }


        
    }
}

