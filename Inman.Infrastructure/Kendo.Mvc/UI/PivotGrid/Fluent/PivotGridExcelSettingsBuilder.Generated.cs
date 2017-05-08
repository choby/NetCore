using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PivotGridExcelSettings
    /// </summary>
    public partial class PivotGridExcelSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Specifies the file name of the exported Excel file.
        /// </summary>
        /// <param name="value">The value for FileName</param>
        public PivotGridExcelSettingsBuilder<T> FileName(string value)
        {
            Container.FileName = value;
            return this;
        }

        /// <summary>
        /// Enables or disables column filtering in the Excel file. Not to be mistaken with the pivotgrid filtering feature.
        /// </summary>
        /// <param name="value">The value for Filterable</param>
        public PivotGridExcelSettingsBuilder<T> Filterable(bool value)
        {
            Container.Filterable = value;
            return this;
        }

        /// <summary>
        /// Enables or disables column filtering in the Excel file. Not to be mistaken with the pivotgrid filtering feature.
        /// </summary>
        public PivotGridExcelSettingsBuilder<T> Filterable()
        {
            Container.Filterable = true;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value for ForceProxy</param>
        public PivotGridExcelSettingsBuilder<T> ForceProxy(bool value)
        {
            Container.ForceProxy = value;
            return this;
        }

        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        public PivotGridExcelSettingsBuilder<T> ForceProxy()
        {
            Container.ForceProxy = true;
            return this;
        }

        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.Such browsers are IE version 9 and lower and Safari.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with the "Content-Disposition" header set to
		/// attachment; filename="&lt;fileName.xslx&gt;".
        /// </summary>
        /// <param name="value">The value for ProxyURL</param>
        public PivotGridExcelSettingsBuilder<T> ProxyURL(string value)
        {
            Container.ProxyURL = value;
            return this;
        }

    }
}
