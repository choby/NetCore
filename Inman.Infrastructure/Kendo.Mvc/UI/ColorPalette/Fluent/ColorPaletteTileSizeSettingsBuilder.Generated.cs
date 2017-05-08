using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ColorPaletteTileSizeSettings
    /// </summary>
    public partial class ColorPaletteTileSizeSettingsBuilder
        
    {
        /// <summary>
        /// The width of the color cell.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ColorPaletteTileSizeSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The height of the color cell.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public ColorPaletteTileSizeSettingsBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

    }
}
