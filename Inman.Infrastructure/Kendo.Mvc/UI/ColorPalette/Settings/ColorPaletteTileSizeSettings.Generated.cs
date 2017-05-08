using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ColorPaletteTileSizeSettings class
    /// </summary>
    public partial class ColorPaletteTileSizeSettings 
    {
        public double? Width { get; set; }

        public double? Height { get; set; }


        public ColorPalette ColorPalette { get; set; }

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
