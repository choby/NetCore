using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorDeserializationSettings
    /// </summary>
    public partial class EditorDeserializationSettingsBuilder
        
    {
        public EditorDeserializationSettingsBuilder(EditorDeserializationSettings container)
        {
            Container = container;
        }

        protected EditorDeserializationSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
