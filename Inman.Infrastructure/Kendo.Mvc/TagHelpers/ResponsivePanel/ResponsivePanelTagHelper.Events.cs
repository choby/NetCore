using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    public partial class ResponsivePanelTagHelper
    {
        /// <summary>
        /// Triggered before the responsive panel is closed. Cancellable.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public string OnClose { get; set; }

        /// <summary>
        /// Triggered before the responsive panel is opened. Cancellable.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public string OnOpen { get; set; }


        protected override Dictionary<string, object> SerializeEvents()
        {
            var settings = new Dictionary<string, object>();

            if (OnClose?.HasValue() == true)
            {
                settings["close"] = CreateHandler(OnClose);
            }

            if (OnOpen?.HasValue() == true)
            {
                settings["open"] = CreateHandler(OnOpen);
            }

            return settings;
        }
    }
}

