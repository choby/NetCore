using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImmutablesSettings
    /// </summary>
    public partial class EditorImmutablesSettingsBuilder
        
    {
        public EditorImmutablesSettingsBuilder(EditorImmutablesSettings container)
        {
            Container = container;
        }

        protected EditorImmutablesSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
