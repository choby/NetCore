using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisSelectMousewheelSettings
    /// </summary>
    public partial class ChartCategoryAxisSelectMousewheelSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true will reverse the mouse wheel direction. The normal direction is down for "zoom out", up for "zoom in".
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public ChartCategoryAxisSelectMousewheelSettingsBuilder<T> Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// Specifies the mousehweel zoom type.
        /// </summary>
        /// <param name="value">The value for Zoom</param>
        public ChartCategoryAxisSelectMousewheelSettingsBuilder<T> Zoom(ChartZoomDirection value)
        {
            Container.Zoom = value;
            return this;
        }

    }
}
