using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Button component
    /// </summary>
    public partial class Button 
    {
        public bool? Enable { get; set; }

        public string Icon { get; set; }

        public string ImageUrl { get; set; }

        public string SpriteCssClass { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Enable.HasValue)
            {
                settings["enable"] = Enable;
            }

            if (Icon?.HasValue() == true)
            {
                settings["icon"] = Icon;
            }

            if (ImageUrl?.HasValue() == true)
            {
                settings["imageUrl"] = ImageUrl;
            }

            if (SpriteCssClass?.HasValue() == true)
            {
                settings["spriteCssClass"] = SpriteCssClass;
            }

            return settings;
        }
    }
}
