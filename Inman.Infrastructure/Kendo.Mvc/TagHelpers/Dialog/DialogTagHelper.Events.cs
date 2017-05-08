using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    public partial class DialogTagHelper
    {
        /// <summary>
        /// Triggered when a Dialog is closed (by a user or through the close() method).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public string OnClose { get; set; }

        /// <summary>
        /// Triggered when a Dialog has finished its closing animation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the hide event.</param>
        public string OnHide { get; set; }

        /// <summary>
        /// Triggered when a Dialog is opened for the first time (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the initOpen event.</param>
        public string OnInitOpen { get; set; }

        /// <summary>
        /// Triggered when a Dialog is opened (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public string OnOpen { get; set; }

        /// <summary>
        /// Triggered when a Dialog has finished its opening animation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the show event.</param>
        public string OnShow { get; set; }


        protected override Dictionary<string, object> SerializeEvents()
        {
            var settings = new Dictionary<string, object>();

            if (OnClose?.HasValue() == true)
            {
                settings["close"] = CreateHandler(OnClose);
            }

            if (OnHide?.HasValue() == true)
            {
                settings["hide"] = CreateHandler(OnHide);
            }

            if (OnInitOpen?.HasValue() == true)
            {
                settings["initOpen"] = CreateHandler(OnInitOpen);
            }

            if (OnOpen?.HasValue() == true)
            {
                settings["open"] = CreateHandler(OnOpen);
            }

            if (OnShow?.HasValue() == true)
            {
                settings["show"] = CreateHandler(OnShow);
            }

            return settings;
        }
    }
}

