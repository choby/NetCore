using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLabelsRotationSettings
    /// </summary>
    public partial class ChartYAxisLabelsRotationSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The alignment of the rotated labels relative to the slot center. The supported values are "end" and "center". By default the closest end of the label will be aligned to the center. If set to "center", the center of the rotated label will be aligned instead.
        /// </summary>
        /// <param name="value">The value for Align</param>
        public ChartYAxisLabelsRotationSettingsBuilder<T> Align(string value)
        {
            Container.Align = value;
            return this;
        }

        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated.
        /// </summary>
        /// <param name="value">The value for Angle</param>
        public ChartYAxisLabelsRotationSettingsBuilder<T> Angle(double value)
        {
            Container.Angle = value;
            return this;
        }

    }
}
