using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    public partial class SplitterTagHelper
    {
        /// <summary>
        /// Triggered when a pane of a Splitter is collapsed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the collapse event.</param>
        public string OnCollapse { get; set; }

        /// <summary>
        /// Triggered when the content for a pane has finished loading.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the contentLoad event.</param>
        public string OnContentLoad { get; set; }

        /// <summary>
        /// Triggered when the AJAX request that fetches a pane content has failed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public string OnError { get; set; }

        /// <summary>
        /// Triggered when a pane of a Splitter is expanded.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the expand event.</param>
        public string OnExpand { get; set; }

        /// <summary>
        /// This event is now obsolete and will be removed in the future. Please use the resize event instead.Fires when the splitter layout has changed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the layoutChange event.</param>
        public string OnLayoutChange { get; set; }

        /// <summary>
        /// Triggered when a pane is resized.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the resize event.</param>
        public string OnResize { get; set; }


        protected override Dictionary<string, object> SerializeEvents()
        {
            var settings = new Dictionary<string, object>();

            if (OnCollapse?.HasValue() == true)
            {
                settings["collapse"] = CreateHandler(OnCollapse);
            }

            if (OnContentLoad?.HasValue() == true)
            {
                settings["contentLoad"] = CreateHandler(OnContentLoad);
            }

            if (OnError?.HasValue() == true)
            {
                settings["error"] = CreateHandler(OnError);
            }

            if (OnExpand?.HasValue() == true)
            {
                settings["expand"] = CreateHandler(OnExpand);
            }

            if (OnLayoutChange?.HasValue() == true)
            {
                settings["layoutChange"] = CreateHandler(OnLayoutChange);
            }

            if (OnResize?.HasValue() == true)
            {
                settings["resize"] = CreateHandler(OnResize);
            }

            return settings;
        }
    }
}

