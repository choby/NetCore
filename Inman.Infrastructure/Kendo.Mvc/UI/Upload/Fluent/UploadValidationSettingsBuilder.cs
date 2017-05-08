using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring UploadValidationSettings
    /// </summary>
    public partial class UploadValidationSettingsBuilder
        
    {
        public UploadValidationSettingsBuilder(UploadValidationSettings container)
        {
            Container = container;
        }

        protected UploadValidationSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
