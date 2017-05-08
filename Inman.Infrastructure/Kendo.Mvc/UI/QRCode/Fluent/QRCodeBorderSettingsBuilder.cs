using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring QRCodeBorderSettings
    /// </summary>
    public partial class QRCodeBorderSettingsBuilder
        
    {
        public QRCodeBorderSettingsBuilder(QRCodeBorderSettings container)
        {
            Container = container;
        }

        protected QRCodeBorderSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
