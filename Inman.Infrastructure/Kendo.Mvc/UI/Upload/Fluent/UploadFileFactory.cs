using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<UploadFile>
    /// </summary>
    public partial class UploadFileFactory
        
    {
        public UploadFileFactory(List<UploadFile> container)
        {
            Container = container;
        }

        protected List<UploadFile> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
