using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    public partial class WindowTagHelper
    {
        /// <summary>
        /// Triggered when a Window has finished its opening animation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the activate event.</param>
        public string OnActivate { get; set; }

        /// <summary>
        /// Triggered when a Window is closed (by a user or through the close() method).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public string OnClose { get; set; }

        /// <summary>
        /// Triggered when a Window has finished its closing animation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the deactivate event.</param>
        public string OnDeactivate { get; set; }

        /// <summary>
        /// Triggered when a Window has been moved by a user.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragend event.</param>
        public string OnDragend { get; set; }

        /// <summary>
        /// Triggered when the user starts to move the window.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragstart event.</param>
        public string OnDragstart { get; set; }

        /// <summary>
        /// Triggered when an AJAX request for content fails.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public string OnError { get; set; }

        /// <summary>
        /// Triggered when the window has been minimized by the user. Introduced in 2016.Q1.SP1
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the maximize event.</param>
        public string OnMaximize { get; set; }

        /// <summary>
        /// Triggered when the window has been minimized by the user. Introduced in 2016.Q1.SP1
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the minimize event.</param>
        public string OnMinimize { get; set; }

        /// <summary>
        /// Triggered when a Window is opened (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public string OnOpen { get; set; }

        /// <summary>
        /// Triggered when the content of a Window has finished loading via AJAX,\n\t\t/// when the window iframe has finished loading, or when the refresh button\n\t\t/// has been clicked on a window with static content.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the refresh event.</param>
        public string OnRefresh { get; set; }

        /// <summary>
        /// Triggered when a window has been resized by a user.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the resize event.</param>
        public string OnResize { get; set; }


        protected override Dictionary<string, object> SerializeEvents()
        {
            var settings = new Dictionary<string, object>();

            if (OnActivate?.HasValue() == true)
            {
                settings["activate"] = CreateHandler(OnActivate);
            }

            if (OnClose?.HasValue() == true)
            {
                settings["close"] = CreateHandler(OnClose);
            }

            if (OnDeactivate?.HasValue() == true)
            {
                settings["deactivate"] = CreateHandler(OnDeactivate);
            }

            if (OnDragend?.HasValue() == true)
            {
                settings["dragend"] = CreateHandler(OnDragend);
            }

            if (OnDragstart?.HasValue() == true)
            {
                settings["dragstart"] = CreateHandler(OnDragstart);
            }

            if (OnError?.HasValue() == true)
            {
                settings["error"] = CreateHandler(OnError);
            }

            if (OnMaximize?.HasValue() == true)
            {
                settings["maximize"] = CreateHandler(OnMaximize);
            }

            if (OnMinimize?.HasValue() == true)
            {
                settings["minimize"] = CreateHandler(OnMinimize);
            }

            if (OnOpen?.HasValue() == true)
            {
                settings["open"] = CreateHandler(OnOpen);
            }

            if (OnRefresh?.HasValue() == true)
            {
                settings["refresh"] = CreateHandler(OnRefresh);
            }

            if (OnResize?.HasValue() == true)
            {
                settings["resize"] = CreateHandler(OnResize);
            }

            return settings;
        }
    }
}

