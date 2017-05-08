using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleLabelsBorderSettings
    /// </summary>
    public partial class LinearGaugeScaleLabelsBorderSettingsBuilder
        
    {
        public LinearGaugeScaleLabelsBorderSettingsBuilder(LinearGaugeScaleLabelsBorderSettings container)
        {
            Container = container;
        }

        protected LinearGaugeScaleLabelsBorderSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The opacity of the border.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public LinearGaugeScaleLabelsBorderSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;

            return this;
        }
    }
}
