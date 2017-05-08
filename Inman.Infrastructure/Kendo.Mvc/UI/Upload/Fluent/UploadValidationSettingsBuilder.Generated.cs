using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring UploadValidationSettings
    /// </summary>
    public partial class UploadValidationSettingsBuilder
        
    {
        /// <summary>
        /// Lists which file extensions are allowed to be uploaded. Recognizes entries of both .type and type values.
        /// </summary>
        /// <param name="value">The value for AllowedExtensions</param>
        public UploadValidationSettingsBuilder AllowedExtensions(params String[] value)
        {
            Container.AllowedExtensions = value;
            return this;
        }

        /// <summary>
        /// Defines the maximum file size that can be uploaded in bytes.
        /// </summary>
        /// <param name="value">The value for MaxFileSize</param>
        public UploadValidationSettingsBuilder MaxFileSize(double value)
        {
            Container.MaxFileSize = value;
            return this;
        }

        /// <summary>
        /// Defines the minimum file size that can be uploaded in bytes.
        /// </summary>
        /// <param name="value">The value for MinFileSize</param>
        public UploadValidationSettingsBuilder MinFileSize(double value)
        {
            Container.MinFileSize = value;
            return this;
        }

    }
}
