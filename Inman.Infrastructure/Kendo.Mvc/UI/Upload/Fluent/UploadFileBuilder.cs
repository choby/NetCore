using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring UploadFile
    /// </summary>
    public partial class UploadFileBuilder
        
    {
        public UploadFileBuilder(UploadFile container)
        {
            Container = container;
        }

        protected UploadFile Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
