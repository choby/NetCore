using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Barcode
    /// </summary>
    public partial class BarcodeBuilder: WidgetBuilderBase<Barcode, BarcodeBuilder>
        
    {
        public BarcodeBuilder(Barcode component) : base(component)
        {
        }

        /// <summary>
        /// The padding of the barcode.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public BarcodeBuilder Padding(double padding)
        {
            Container.Padding.Barcode = Container;

            Container.Padding.Bottom = padding;
            Container.Padding.Top = padding;
            Container.Padding.Left = padding;
            Container.Padding.Right = padding;

            return this;
        }

        /// <summary>
        /// The padding of the barcode.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public BarcodeBuilder Encoding(BarcodeSymbology encoding)
        {
            Container.Encoding = encoding;

            return this;
        }
    }
}

