using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class ButtonTagHelper
    {
        /// <summary>
        /// Indicates whether the Button should be enabled or disabled. By default, it is enabled, unless a disabled="disabled" attribute is detected.
        /// </summary>
        public bool? Enable { get; set; }

        /// <summary>
        /// Defines a name of an existing icon in the Kendo UI theme sprite. The icon will be applied as background image of a span element inside the Button.
		/// The span element can be added automatically by the widget, or an existing element can be used, if it has a k-icon CSS class applied.
		/// For a list of available icon names, please refer to the Icons demo.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Defines a URL, which will be used for an img element inside the Button. The URL can be relative or absolute. In case it is relative, it will be evaluated with relation to the web page URL.The img element can be added automatically by the widget, or an existing element can be used, if it has a k-image CSS class applied.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Defines a CSS class (or multiple classes separated by spaces), which will be used for applying a background image to a span element inside the Button.
		/// In case you want to use an icon from the Kendo UI theme sprite background image, it is easier to use the icon property.The span element can be added automatically by the widget, or an existing element can be used, if it has a k-sprite CSS class applied.
        /// </summary>
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
