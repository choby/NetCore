using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorTool
    /// </summary>
    public partial class EditorToolBuilder

    {
        public EditorToolBuilder(EditorTool container)
        {
            Container = container;
        }

        protected EditorTool Container
        {
            get;
            private set;
        }

        // Place custom settings here

        public EditorToolBuilder Palette(IEnumerable<string> colors)
        {
            Container.PaletteColors = colors;
            Container.Palette = null;

            return this;
        }
        
        public EditorToolBuilder Palette(ColorPickerPalette palette)
        {
            Container.PaletteColors = null;
            Container.Palette = palette;

            return this;
        }

        [Obsolete("The property is deprecated. Please use the Tooltip property instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public EditorToolBuilder ToolTip(string value)
        {
            Container.Tooltip = value;
            return this;
        }
    }
}
