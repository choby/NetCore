using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListPdfSettings
    /// </summary>
    public partial class TreeListPdfSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The author of the PDF document.
        /// </summary>
        /// <param name="value">The value for Author</param>
        public TreeListPdfSettingsBuilder<T> Author(string value)
        {
            Container.Author = value;
            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce actual hyperlinks in the exported PDF file.It's also possible to pass a CSS selector as argument. All matching links will be ignored.
        /// </summary>
        /// <param name="value">The value for AvoidLinks</param>
        public TreeListPdfSettingsBuilder<T> AvoidLinks(bool value)
        {
            Container.AvoidLinks = value;
            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce actual hyperlinks in the exported PDF file.It's also possible to pass a CSS selector as argument. All matching links will be ignored.
        /// </summary>
        public TreeListPdfSettingsBuilder<T> AvoidLinks()
        {
            Container.AvoidLinks = true;
            return this;
        }

        /// <summary>
        /// The creator of the PDF document.
        /// </summary>
        /// <param name="value">The value for Creator</param>
        public TreeListPdfSettingsBuilder<T> Creator(string value)
        {
            Container.Creator = value;
            return this;
        }

        /// <summary>
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <param name="value">The value for Date</param>
        public TreeListPdfSettingsBuilder<T> Date(DateTime value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for FileName</param>
        public TreeListPdfSettingsBuilder<T> FileName(string value)
        {
            Container.FileName = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value for ForceProxy</param>
        public TreeListPdfSettingsBuilder<T> ForceProxy(bool value)
        {
            Container.ForceProxy = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        public TreeListPdfSettingsBuilder<T> ForceProxy()
        {
            Container.ForceProxy = true;
            return this;
        }

        /// <summary>
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for Keywords</param>
        public TreeListPdfSettingsBuilder<T> Keywords(string value)
        {
            Container.Keywords = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions such that width is the larger edge.
        /// </summary>
        /// <param name="value">The value for Landscape</param>
        public TreeListPdfSettingsBuilder<T> Landscape(bool value)
        {
            Container.Landscape = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions such that width is the larger edge.
        /// </summary>
        public TreeListPdfSettingsBuilder<T> Landscape()
        {
            Container.Landscape = true;
            return this;
        }

        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser isn't capable of saving files locally.
		/// Such browsers are IE version 9 and lower, and Safari.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with the "Content-Disposition" header set to
		/// attachment; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyURL</param>
        public TreeListPdfSettingsBuilder<T> ProxyURL(string value)
        {
            Container.ProxyURL = value;
            return this;
        }

        /// <summary>
        /// A name or keyword indicating where to display the document returned from the proxy.If you want to display the document in a new window or iframe,
		/// the proxy should set the "Content-Disposition" header to inline; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyTarget</param>
        public TreeListPdfSettingsBuilder<T> ProxyTarget(string value)
        {
            Container.ProxyTarget = value;
            return this;
        }

        /// <summary>
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <param name="value">The value for Subject</param>
        public TreeListPdfSettingsBuilder<T> Subject(string value)
        {
            Container.Subject = value;
            return this;
        }

        /// <summary>
        /// Sets the title of the PDF file.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public TreeListPdfSettingsBuilder<T> Title(string value)
        {
            Container.Title = value;
            return this;
        }

    }
}
