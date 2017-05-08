using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ColorPalette component
    /// </summary>
    public partial class ColorPalette 
    {
        public int? Columns { get; set; }

        public ColorPaletteTileSizeSettings TileSize { get; } = new ColorPaletteTileSizeSettings();

        public string Value { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Columns.HasValue)
            {
                settings["columns"] = Columns;
            }

            var tileSize = TileSize.Serialize();
            if (tileSize.Any())
            {
                settings["tileSize"] = tileSize;
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            return settings;
        }
    }
}
