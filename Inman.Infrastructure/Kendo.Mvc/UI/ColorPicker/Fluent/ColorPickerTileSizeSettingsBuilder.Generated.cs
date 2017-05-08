using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ColorPickerTileSizeSettings
    /// </summary>
    public partial class ColorPickerTileSizeSettingsBuilder
        
    {
        /// <summary>
        /// The width of the color cell.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ColorPickerTileSizeSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The height of the color cell.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public ColorPickerTileSizeSettingsBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

    }
}
