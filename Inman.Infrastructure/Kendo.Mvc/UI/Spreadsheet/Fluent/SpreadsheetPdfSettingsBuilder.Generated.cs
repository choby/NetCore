using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetPdfSettings
    /// </summary>
    public partial class SpreadsheetPdfSettingsBuilder
        
    {
        /// <summary>
        /// The area to export. Possible values:
        /// </summary>
        /// <param name="value">The value for Area</param>
        public SpreadsheetPdfSettingsBuilder Area(string value)
        {
            Container.Area = value;
            return this;
        }

        /// <summary>
        /// The author of the PDF document.
        /// </summary>
        /// <param name="value">The value for Author</param>
        public SpreadsheetPdfSettingsBuilder Author(string value)
        {
            Container.Author = value;
            return this;
        }

        /// <summary>
        /// The creator of the PDF document.
        /// </summary>
        /// <param name="value">The value for Creator</param>
        public SpreadsheetPdfSettingsBuilder Creator(string value)
        {
            Container.Creator = value;
            return this;
        }

        /// <summary>
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <param name="value">The value for Date</param>
        public SpreadsheetPdfSettingsBuilder Date(DateTime value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for FileName</param>
        public SpreadsheetPdfSettingsBuilder FileName(string value)
        {
            Container.FileName = value;
            return this;
        }

        /// <summary>
        /// An option indicating whether to fit the spreadsheet content to page width.
        /// </summary>
        /// <param name="value">The value for FitWidth</param>
        public SpreadsheetPdfSettingsBuilder FitWidth(bool value)
        {
            Container.FitWidth = value;
            return this;
        }

        /// <summary>
        /// An option indicating whether to fit the spreadsheet content to page width.
        /// </summary>
        public SpreadsheetPdfSettingsBuilder FitWidth()
        {
            Container.FitWidth = true;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value for ForceProxy</param>
        public SpreadsheetPdfSettingsBuilder ForceProxy(bool value)
        {
            Container.ForceProxy = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        public SpreadsheetPdfSettingsBuilder ForceProxy()
        {
            Container.ForceProxy = true;
            return this;
        }

        /// <summary>
        /// An option indicating whether to export the cell guidelines.
        /// </summary>
        /// <param name="value">The value for Guidelines</param>
        public SpreadsheetPdfSettingsBuilder Guidelines(bool value)
        {
            Container.Guidelines = value;
            return this;
        }

        /// <summary>
        /// An option indicating whether to export the cell guidelines.
        /// </summary>
        public SpreadsheetPdfSettingsBuilder Guidelines()
        {
            Container.Guidelines = true;
            return this;
        }

        /// <summary>
        /// An option indicating whether to center the content horizontally.See also vCenter.
        /// </summary>
        /// <param name="value">The value for HCenter</param>
        public SpreadsheetPdfSettingsBuilder HCenter(bool value)
        {
            Container.HCenter = value;
            return this;
        }

        /// <summary>
        /// An option indicating whether to center the content horizontally.See also vCenter.
        /// </summary>
        public SpreadsheetPdfSettingsBuilder HCenter()
        {
            Container.HCenter = true;
            return this;
        }

        /// <summary>
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <param name="value">The value for Keywords</param>
        public SpreadsheetPdfSettingsBuilder Keywords(string value)
        {
            Container.Keywords = value;
            return this;
        }

        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        /// <param name="value">The value for Landscape</param>
        public SpreadsheetPdfSettingsBuilder Landscape(bool value)
        {
            Container.Landscape = value;
            return this;
        }

        /// <summary>
        /// Specifies the margins of the page (numbers or strings with units). Supported
		/// units are "mm", "cm", "in" and "pt" (default).
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public SpreadsheetPdfSettingsBuilder Margin(Action<SpreadsheetPdfMarginSettingsBuilder> configurator)
        {

            Container.Margin.Spreadsheet = Container.Spreadsheet;
            configurator(new SpreadsheetPdfMarginSettingsBuilder(Container.Margin));

            return this;
        }

        /// <summary>
        /// Specifies the paper size of the PDF document.
		/// The default "auto" means paper size is determined by content.Supported values:
        /// </summary>
        /// <param name="value">The value for PaperSize</param>
        public SpreadsheetPdfSettingsBuilder PaperSize(string value)
        {
            Container.PaperSize = value;
            return this;
        }

        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser is not capable of saving files locally, for example, Internet Explorer 9 and Safari.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with the "Content-Disposition" header set to
		/// attachment; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyURL</param>
        public SpreadsheetPdfSettingsBuilder ProxyURL(string value)
        {
            Container.ProxyURL = value;
            return this;
        }

        /// <summary>
        /// A name or keyword indicating where to display the document returned from the proxy.If you want to display the document in a new window or iframe,
		/// the proxy should set the "Content-Disposition" header to inline; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyTarget</param>
        public SpreadsheetPdfSettingsBuilder ProxyTarget(string value)
        {
            Container.ProxyTarget = value;
            return this;
        }

        /// <summary>
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <param name="value">The value for Subject</param>
        public SpreadsheetPdfSettingsBuilder Subject(string value)
        {
            Container.Subject = value;
            return this;
        }

        /// <summary>
        /// Sets the title of the PDF file.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public SpreadsheetPdfSettingsBuilder Title(string value)
        {
            Container.Title = value;
            return this;
        }

        /// <summary>
        /// An option indicating whether to center the content vertically.See also hCenter.
        /// </summary>
        /// <param name="value">The value for VCenter</param>
        public SpreadsheetPdfSettingsBuilder VCenter(bool value)
        {
            Container.VCenter = value;
            return this;
        }

        /// <summary>
        /// An option indicating whether to center the content vertically.See also hCenter.
        /// </summary>
        public SpreadsheetPdfSettingsBuilder VCenter()
        {
            Container.VCenter = true;
            return this;
        }

    }
}
