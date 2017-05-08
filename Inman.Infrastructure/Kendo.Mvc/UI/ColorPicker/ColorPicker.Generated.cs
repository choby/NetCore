using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ColorPicker component
    /// </summary>
    public partial class ColorPicker 
    {
        public bool? Buttons { get; set; }

        public bool? ClearButton { get; set; }

        public double? Columns { get; set; }

        public ColorPickerTileSizeSettings TileSize { get; } = new ColorPickerTileSizeSettings();

        public ColorPickerMessagesSettings Messages { get; } = new ColorPickerMessagesSettings();

        public bool? Opacity { get; set; }

        public bool? Preview { get; set; }

        public string ToolIcon { get; set; }

        public string Value { get; set; }

        public ColorPickerPalette? Palette { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Buttons.HasValue)
            {
                settings["buttons"] = Buttons;
            }

            if (ClearButton.HasValue)
            {
                settings["clearButton"] = ClearButton;
            }

            if (Columns.HasValue)
            {
                settings["columns"] = Columns;
            }

            var tileSize = TileSize.Serialize();
            if (tileSize.Any())
            {
                settings["tileSize"] = tileSize;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Preview.HasValue)
            {
                settings["preview"] = Preview;
            }

            if (ToolIcon?.HasValue() == true)
            {
                settings["toolIcon"] = ToolIcon;
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            if (Palette.HasValue)
            {
                settings["palette"] = Palette?.Serialize();
            }

            return settings;
        }
    }
}
