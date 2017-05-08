using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorTool class
    /// </summary>
    public partial class EditorTool 
    {
        public IEnumerable<string> PaletteColors { get; set; } = new List<string>();

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            // Do manual serialization here

            if (Palette.HasValue && Palette != ColorPickerPalette.None)
            {
                settings["palette"] = Palette?.Serialize();
            }
            else if (PaletteColors != null && PaletteColors.Any())
            {
                settings["palette"] = PaletteColors;
            }

            return settings;
        }
    }
}
