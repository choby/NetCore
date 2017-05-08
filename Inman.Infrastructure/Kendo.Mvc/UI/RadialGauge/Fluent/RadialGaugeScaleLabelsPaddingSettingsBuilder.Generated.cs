using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeScaleLabelsPaddingSettings
    /// </summary>
    public partial class RadialGaugeScaleLabelsPaddingSettingsBuilder
        
    {
        /// <summary>
        /// The top padding of the labels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public RadialGaugeScaleLabelsPaddingSettingsBuilder Top(double value)
        {
            Container.Top = value;
            return this;
        }

        /// <summary>
        /// The bottom padding of the labels.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public RadialGaugeScaleLabelsPaddingSettingsBuilder Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the labels.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public RadialGaugeScaleLabelsPaddingSettingsBuilder Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the labels.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public RadialGaugeScaleLabelsPaddingSettingsBuilder Right(double value)
        {
            Container.Right = value;
            return this;
        }

    }
}
