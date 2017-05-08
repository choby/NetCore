using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI QRCode
    /// </summary>
    public partial class QRCodeBuilder: WidgetBuilderBase<QRCode, QRCodeBuilder>
        
    {
        public QRCodeBuilder(QRCode component) : base(component)
        {
        }

        /// <summary>
        /// The border of the QR code.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public QRCodeBuilder Border(string color, int width)
        {

            Container.Border.QRCode = Container;

            Container.Border.Color = color;
            Container.Border.Width = width;

            return this;
        }
    }
}

