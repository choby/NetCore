using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerPdfSettings
    /// </summary>
    public partial class SchedulerPdfSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The author of the PDF document.
        /// </summary>
        /// <param name="value">The value for Author</param>
        public SchedulerPdfSettingsBuilder<T> Author(string value)
        {
            Container.Author = value;
            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce actual hyperlinks in the exported PDF file.It's also possible to pass a CSS selector as argument. All matching links will be ignored.
        /// </summary>
        /// <param name="value">The value for AvoidLinks</param>
        public SchedulerPdfSettingsBuilder<T> AvoidLinks(bool value)
        {
            Container.AvoidLinks = value;
            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce actual hyperlinks in the exported PDF file.It's also possible to pass a CSS selector as argument. All matching links will be ignored.
        /// </summary>
        public SchedulerPdfSettingsBuilder<T> AvoidLinks()
        {
            Container.AvoidLinks = true;
            return this;
        }

        /// <summary>
        /// The creator of the PDF document.
        /// </summary>
        /// <param name="value">The value for Creator</param>
        public SchedulerPdfSettingsBuilder<T> Creator(string value)
        {
            Container.Creator = value;
            return this;
        }

        /// <summary>
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <param name="value">The value for Date</param>
        public SchedulerPdfSettingsBuilder<T> Date(DateTime value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for FileName</param>
        public SchedulerPdfSettingsBuilder<T> FileName(string value)
        {
            Container.FileName = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value for ForceProxy</param>
        public SchedulerPdfSettingsBuilder<T> ForceProxy(bool value)
        {
            Container.ForceProxy = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        public SchedulerPdfSettingsBuilder<T> ForceProxy()
        {
            Container.ForceProxy = true;
            return this;
        }

        /// <summary>
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for Keywords</param>
        public SchedulerPdfSettingsBuilder<T> Keywords(string value)
        {
            Container.Keywords = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        /// <param name="value">The value for Landscape</param>
        public SchedulerPdfSettingsBuilder<T> Landscape(bool value)
        {
            Container.Landscape = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        public SchedulerPdfSettingsBuilder<T> Landscape()
        {
            Container.Landscape = true;
            return this;
        }

        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser isn't capable of saving files locally.
		/// Such browsers are IE version 9 and lower and Safari.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with set "Content-Disposition" header.
        /// </summary>
        /// <param name="value">The value for ProxyURL</param>
        public SchedulerPdfSettingsBuilder<T> ProxyURL(string value)
        {
            Container.ProxyURL = value;
            return this;
        }

        /// <summary>
        /// A name or keyword indicating where to display the document returned from the proxy.If you want to display the document in a new window or iframe,
		/// the proxy should set the "Content-Disposition" header to inline; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyTarget</param>
        public SchedulerPdfSettingsBuilder<T> ProxyTarget(string value)
        {
            Container.ProxyTarget = value;
            return this;
        }

        /// <summary>
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <param name="value">The value for Subject</param>
        public SchedulerPdfSettingsBuilder<T> Subject(string value)
        {
            Container.Subject = value;
            return this;
        }

        /// <summary>
        /// Sets the title of the PDF file.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public SchedulerPdfSettingsBuilder<T> Title(string value)
        {
            Container.Title = value;
            return this;
        }

    }
}
