using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    public partial class TimePickerTagHelper
    {
        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public string OnChange { get; set; }

        /// <summary>
        /// Fires when the time drop-down list is closed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public string OnClose { get; set; }

        /// <summary>
        /// Fires when the time drop-down list is opened
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public string OnOpen { get; set; }


        protected override Dictionary<string, object> SerializeEvents()
        {
            var settings = new Dictionary<string, object>();

            if (OnChange?.HasValue() == true)
            {
                settings["change"] = CreateHandler(OnChange);
            }

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

