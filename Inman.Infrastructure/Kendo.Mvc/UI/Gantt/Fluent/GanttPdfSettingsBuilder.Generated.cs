using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttPdfSettings
    /// </summary>
    public partial class GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The author of the PDF document.
        /// </summary>
        /// <param name="value">The value for Author</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Author(string value)
        {
            Container.Author = value;
            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce actual hyperlinks in the exported PDF file.It's also possible to pass a CSS selector as argument. All matching links will be ignored.
        /// </summary>
        /// <param name="value">The value for AvoidLinks</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> AvoidLinks(bool value)
        {
            Container.AvoidLinks = value;
            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce actual hyperlinks in the exported PDF file.It's also possible to pass a CSS selector as argument. All matching links will be ignored.
        /// </summary>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> AvoidLinks()
        {
            Container.AvoidLinks = true;
            return this;
        }

        /// <summary>
        /// The creator of the PDF document.
        /// </summary>
        /// <param name="value">The value for Creator</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Creator(string value)
        {
            Container.Creator = value;
            return this;
        }

        /// <summary>
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <param name="value">The value for Date</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Date(DateTime value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for FileName</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> FileName(string value)
        {
            Container.FileName = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value for ForceProxy</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> ForceProxy(bool value)
        {
            Container.ForceProxy = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> ForceProxy()
        {
            Container.ForceProxy = true;
            return this;
        }

        /// <summary>
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for Keywords</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Keywords(string value)
        {
            Container.Keywords = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        /// <param name="value">The value for Landscape</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Landscape(bool value)
        {
            Container.Landscape = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Landscape()
        {
            Container.Landscape = true;
            return this;
        }

        /// <summary>
        /// Specifies the margins of the page (numbers or strings with units). Supported
		/// units are "mm", "cm", "in" and "pt" (default).
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Margin(Action<GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
        {

            Container.Margin.Gantt = Container.Gantt;
            configurator(new GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel>(Container.Margin));

            return this;
        }

        /// <summary>
        /// Specifies the paper size of the PDF document.
		/// The default "auto" means paper size is determined by content.Supported values:
        /// </summary>
        /// <param name="value">The value for PaperSize</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> PaperSize(string value)
        {
            Container.PaperSize = value;
            return this;
        }

        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser isn't capable of saving files locally.
		/// Such browsers are IE version 9 and lower and Safari.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with set "Content-Disposition" header.
        /// </summary>
        /// <param name="value">The value for ProxyURL</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> ProxyURL(string value)
        {
            Container.ProxyURL = value;
            return this;
        }

        /// <summary>
        /// A name or keyword indicating where to display the document returned from the proxy.If you want to display the document in a new window or iframe,
		/// the proxy should set the "Content-Disposition" header to inline; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyTarget</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> ProxyTarget(string value)
        {
            Container.ProxyTarget = value;
            return this;
        }

        /// <summary>
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <param name="value">The value for Subject</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Subject(string value)
        {
            Container.Subject = value;
            return this;
        }

        /// <summary>
        /// Sets the title of the PDF file.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Title(string value)
        {
            Container.Title = value;
            return this;
        }

    }
}
