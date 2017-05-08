using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ColorPickerTileSizeSettings class
    /// </summary>
    public partial class ColorPickerTileSizeSettings 
    {
        public double? Width { get; set; }

        public double? Height { get; set; }


        public ColorPicker ColorPicker { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            return settings;
        }
    }
}
