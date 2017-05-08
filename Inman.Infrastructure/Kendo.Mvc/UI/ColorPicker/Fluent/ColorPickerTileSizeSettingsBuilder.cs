using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ColorPickerTileSizeSettings
    /// </summary>
    public partial class ColorPickerTileSizeSettingsBuilder
        
    {
        public ColorPickerTileSizeSettingsBuilder(ColorPickerTileSizeSettings container)
        {
            Container = container;
        }

        protected ColorPickerTileSizeSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
