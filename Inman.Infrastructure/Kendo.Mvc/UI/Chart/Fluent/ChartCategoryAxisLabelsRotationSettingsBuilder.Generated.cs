using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLabelsRotationSettings
    /// </summary>
    public partial class ChartCategoryAxisLabelsRotationSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated. Can be set to "auto" if the axis is horizontal in which case the labels will be rotated only if the slot size is not sufficient for the entire labels.
        /// </summary>
        /// <param name="value">The value for Angle</param>
        public ChartCategoryAxisLabelsRotationSettingsBuilder<T> Angle(object value)
        {
            Container.Angle = value;
            return this;
        }

        /// <summary>
        /// Specifies the rotation of the labels.
        /// </summary>
        /// <param name="value">The value for Align</param>
        public ChartCategoryAxisLabelsRotationSettingsBuilder<T> Align(ChartAxisLabelRotationAlignment value)
        {
            Container.Align = value;
            return this;
        }

    }
}
