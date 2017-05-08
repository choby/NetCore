using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorSerializationSettings
    /// </summary>
    public partial class EditorSerializationSettingsBuilder
        
    {
        public EditorSerializationSettingsBuilder(EditorSerializationSettings container)
        {
            Container = container;
        }

        protected EditorSerializationSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
