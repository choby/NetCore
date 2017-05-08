using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring UploadFile
    /// </summary>
    public partial class UploadFileBuilder
        
    {
        /// <summary>
        /// The extension of the initial file.
        /// </summary>
        /// <param name="value">The value for Extension</param>
        public UploadFileBuilder Extension(string value)
        {
            Container.Extension = value;
            return this;
        }

        /// <summary>
        /// The name of the initial file.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public UploadFileBuilder Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The size of the initial file.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public UploadFileBuilder Size(double value)
        {
            Container.Size = value;
            return this;
        }

    }
}
