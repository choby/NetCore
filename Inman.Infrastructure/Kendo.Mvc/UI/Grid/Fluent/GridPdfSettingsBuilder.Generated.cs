using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridPdfSettings
    /// </summary>
    public partial class GridPdfSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Exports all grid pages, starting from the first one.
        /// </summary>
        /// <param name="value">The value for AllPages</param>
        public GridPdfSettingsBuilder<T> AllPages(bool value)
        {
            Container.AllPages = value;
            return this;
        }

        /// <summary>
        /// Exports all grid pages, starting from the first one.
        /// </summary>
        public GridPdfSettingsBuilder<T> AllPages()
        {
            Container.AllPages = true;
            return this;
        }

        /// <summary>
        /// The author of the PDF document.
        /// </summary>
        /// <param name="value">The value for Author</param>
        public GridPdfSettingsBuilder<T> Author(string value)
        {
            Container.Author = value;
            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce actual hyperlinks in the exported PDF file.It's also possible to pass a CSS selector as argument. All matching links will be ignored.
        /// </summary>
        /// <param name="value">The value for AvoidLinks</param>
        public GridPdfSettingsBuilder<T> AvoidLinks(bool value)
        {
            Container.AvoidLinks = value;
            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce actual hyperlinks in the exported PDF file.It's also possible to pass a CSS selector as argument. All matching links will be ignored.
        /// </summary>
        public GridPdfSettingsBuilder<T> AvoidLinks()
        {
            Container.AvoidLinks = true;
            return this;
        }

        /// <summary>
        /// The creator of the PDF document.
        /// </summary>
        /// <param name="value">The value for Creator</param>
        public GridPdfSettingsBuilder<T> Creator(string value)
        {
            Container.Creator = value;
            return this;
        }

        /// <summary>
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <param name="value">The value for Date</param>
        public GridPdfSettingsBuilder<T> Date(DateTime value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for FileName</param>
        public GridPdfSettingsBuilder<T> FileName(string value)
        {
            Container.FileName = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value for ForceProxy</param>
        public GridPdfSettingsBuilder<T> ForceProxy(bool value)
        {
            Container.ForceProxy = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        public GridPdfSettingsBuilder<T> ForceProxy()
        {
            Container.ForceProxy = true;
            return this;
        }

        /// <summary>
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for Keywords</param>
        public GridPdfSettingsBuilder<T> Keywords(string value)
        {
            Container.Keywords = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        /// <param name="value">The value for Landscape</param>
        public GridPdfSettingsBuilder<T> Landscape(bool value)
        {
            Container.Landscape = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        public GridPdfSettingsBuilder<T> Landscape()
        {
            Container.Landscape = true;
            return this;
        }

        /// <summary>
        /// A piece of HTML to be included in each page.  Can be used to display headers and footers.  See the documentation in drawDOM.Available template variables include:
		/// * pageNum
		/// * totalPages
        /// </summary>
        /// <param name="value">The value for Template</param>
        public GridPdfSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// A piece of HTML to be included in each page.  Can be used to display headers and footers.  See the documentation in drawDOM.Available template variables include:
		/// * pageNum
		/// * totalPages
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public GridPdfSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Set this to true to repeat the grid headers on each page.
        /// </summary>
        /// <param name="value">The value for RepeatHeaders</param>
        public GridPdfSettingsBuilder<T> RepeatHeaders(bool value)
        {
            Container.RepeatHeaders = value;
            return this;
        }

        /// <summary>
        /// Set this to true to repeat the grid headers on each page.
        /// </summary>
        public GridPdfSettingsBuilder<T> RepeatHeaders()
        {
            Container.RepeatHeaders = true;
            return this;
        }

        /// <summary>
        /// A scale factor.  In many cases, text size on screen will be too big for print, so you can use this option to scale down the output in PDF.  See the documentation in drawDOM.
        /// </summary>
        /// <param name="value">The value for Scale</param>
        public GridPdfSettingsBuilder<T> Scale(double value)
        {
            Container.Scale = value;
            return this;
        }

        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser is not capable of saving files locally, for example, Internet Explorer 9 and Safari.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with the "Content-Disposition" header set to
		/// attachment; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyURL</param>
        public GridPdfSettingsBuilder<T> ProxyURL(string value)
        {
            Container.ProxyURL = value;
            return this;
        }

        /// <summary>
        /// A name or keyword indicating where to display the document returned from the proxy.If you want to display the document in a new window or iframe,
		/// the proxy should set the "Content-Disposition" header to inline; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyTarget</param>
        public GridPdfSettingsBuilder<T> ProxyTarget(string value)
        {
            Container.ProxyTarget = value;
            return this;
        }

        /// <summary>
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <param name="value">The value for Subject</param>
        public GridPdfSettingsBuilder<T> Subject(string value)
        {
            Container.Subject = value;
            return this;
        }

        /// <summary>
        /// Sets the title of the PDF file.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public GridPdfSettingsBuilder<T> Title(string value)
        {
            Container.Title = value;
            return this;
        }

    }
}
