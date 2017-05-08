using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeGaugeAreaBorderSettings
    /// </summary>
    public partial class LinearGaugeGaugeAreaBorderSettingsBuilder
        
    {
        public LinearGaugeGaugeAreaBorderSettingsBuilder(LinearGaugeGaugeAreaBorderSettings container)
        {
            Container = container;
        }

        protected LinearGaugeGaugeAreaBorderSettings Container
        {
            get;
            private set;
        }

        public LinearGaugeGaugeAreaBorderSettingsBuilder Opacity(double opacity)
        {
            Container.Opacity = opacity;
            return this;
        }
    }
}
