using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ColorPaletteTileSizeSettings
    /// </summary>
    public partial class ColorPaletteTileSizeSettingsBuilder
        
    {
        public ColorPaletteTileSizeSettingsBuilder(ColorPaletteTileSizeSettings container)
        {
            Container = container;
        }

        protected ColorPaletteTileSizeSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
