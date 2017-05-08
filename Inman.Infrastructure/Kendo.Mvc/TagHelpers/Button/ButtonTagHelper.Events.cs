using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    public partial class ButtonTagHelper
    {
        /// <summary>
        /// Fires when the Button is clicked with the mouse, touched on a touch device, or ENTER (or SPACE) is pressed while the Button is focused.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the click event.</param>
        public string OnClick { get; set; }


        protected override Dictionary<string, object> SerializeEvents()
        {
            var settings = new Dictionary<string, object>();

            if (OnClick?.HasValue() == true)
            {
                settings["click"] = CreateHandler(OnClick);
            }

            return settings;
        }
    }
}

