using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLabelsRotationSettings
    /// </summary>
    public partial class ChartXAxisLabelsRotationSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated. Can be set to "auto" in which case the labels will be rotated only if the slot size is not sufficient for the entire labels.
        /// </summary>
        /// <param name="value">The value for Angle</param>
        public ChartXAxisLabelsRotationSettingsBuilder<T> Angle(double value)
        {
            Container.Angle = value;
            return this;
        }

        /// <summary>
        /// Specifies the rotation of the labels.
        /// </summary>
        /// <param name="value">The value for Align</param>
        public ChartXAxisLabelsRotationSettingsBuilder<T> Align(ChartAxisLabelRotationAlignment value)
        {
            Container.Align = value;
            return this;
        }

    }
}
