using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring BarcodeTextSettings
    /// </summary>
    public partial class BarcodeTextSettingsBuilder
        
    {
        public BarcodeTextSettingsBuilder(BarcodeTextSettings container)
        {
            Container = container;
        }

        protected BarcodeTextSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The margin of the text
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public BarcodeTextSettingsBuilder Margin(double margin)
        {

            Container.Margin.Barcode = Container.Barcode;

            Container.Margin.Top = margin;
            Container.Margin.Bottom = margin;
            Container.Margin.Left = margin;
            Container.Margin.Right = margin;

            return this;
        }
    }
}
