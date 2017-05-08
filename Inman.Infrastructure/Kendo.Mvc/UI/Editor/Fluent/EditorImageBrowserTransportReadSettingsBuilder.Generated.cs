using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserTransportReadSettings
    /// </summary>
    public partial class EditorImageBrowserTransportReadSettingsBuilder
        
    {
        /// <summary>
        /// The content-type HTTP header sent to the server. Use "application/json" if the content is JSON.
		/// Refer to the jQuery.ajax documentation for further info.
        /// </summary>
        /// <param name="value">The value for ContentType</param>
        public EditorImageBrowserTransportReadSettingsBuilder ContentType(string value)
        {
            Container.ContentType = value;
            return this;
        }

        /// <summary>
        /// The type of data that you're expecting back from the server. Commonly used values are "json" and "jsonp".
		/// Refer to the jQuery.ajax documentation for further info.
        /// </summary>
        /// <param name="value">The value for DataType</param>
        public EditorImageBrowserTransportReadSettingsBuilder DataType(string value)
        {
            Container.DataType = value;
            return this;
        }

        /// <summary>
        /// The type of request to make ("POST", "GET", "PUT" or "DELETE"), default is "POST".
		/// Refer to the jQuery.ajax documentation for further info.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public EditorImageBrowserTransportReadSettingsBuilder Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// The remote url to call when fetching list of items.
        /// </summary>
        /// <param name="value">The value for Url</param>
        public EditorImageBrowserTransportReadSettingsBuilder Url(string value)
        {
            Container.UrlHandler = null;
            Container.Url = value;
            return this;
        }
        /// <summary>
        /// The remote url to call when fetching list of items.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorImageBrowserTransportReadSettingsBuilder UrlHandler(string handler)
        {
            Container.Url = null;
            Container.UrlHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The remote url to call when fetching list of items.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorImageBrowserTransportReadSettingsBuilder UrlHandler(Func<object, object> handler)
        {
            Container.Url = null;
            Container.UrlHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

    }
}
